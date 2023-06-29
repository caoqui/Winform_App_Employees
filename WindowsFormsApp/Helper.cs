using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using System.Windows.Forms;
using System;



namespace MyApp
{
    using Oracle.ManagedDataAccess.Client;
    public static class OracleHelper
    {
        public static OracleConnection GetOracleConnection()
        {
            //string connectionString = "Data Source=Project;User Id=sys;Password=123321ok;";
            //string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)" +"(HOST=localhost)(PORT=1521))" +"(CONNECT_DATA=(SERVICE_NAME=XE)));User Id=sys;Password=123321ok";
            string connectionString = @"Data Source=(DESCRIPTION =
    (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))
    (CONNECT_DATA =
      (SERVER = DEDICATED)
      (SERVICE_NAME = XE)
    )
  );User Id=sys;Password=123321ok;DBA Privilege=SYSDBA;";
            OracleConnection connection = new OracleConnection(connectionString);
            return connection;
        }

        // view all users on system
        public static DataTable GetAccounts()
        {
            DataTable dataTable = new DataTable();

            using (OracleConnection connection = GetOracleConnection())
            {
                try
                {
                    connection.Open();

                    OracleCommand command = new OracleCommand();

                    command.Connection = connection;
                    command.CommandText = "P_LISTUSERS";

                    command.CommandType = CommandType.StoredProcedure;

                    //

                    // Khởi tạo tham số đầu ra
                    OracleParameter outputParam = new OracleParameter();
                    outputParam.OracleDbType = OracleDbType.RefCursor;
                    outputParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParam);

                    OracleDataAdapter adapter = new OracleDataAdapter(command);

                    adapter.Fill(dataTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return dataTable;
        }
        
        //change password of user.
        public static DataTable Manager_User_Role(string p_user_role_name, string p_password, string p_action)
        {
            DataTable dataTable = new DataTable();

            using (OracleConnection connection = GetOracleConnection())
            {
                try
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "manage_user_role";

                    // Thêm tham số p_user_role_name
                    OracleParameter parameter1 = new OracleParameter();
                    parameter1.OracleDbType = OracleDbType.Varchar2;
                    parameter1.Direction = ParameterDirection.Input;
                    parameter1.ParameterName = "p_user_role_name";
                    parameter1.Value = p_user_role_name;
                    command.Parameters.Add(parameter1);

                    // Thêm tham số p_action
                    OracleParameter parameter2 = new OracleParameter();
                    parameter2.OracleDbType = OracleDbType.Varchar2;
                    parameter2.Direction = ParameterDirection.Input;
                    parameter2.ParameterName = "p_action";
                    parameter2.Value = p_action;
                    command.Parameters.Add(parameter2);

                    // Thêm tham số p_password
                    OracleParameter parameter3 = new OracleParameter();
                    parameter3.OracleDbType = OracleDbType.Varchar2;
                    parameter3.Direction = ParameterDirection.Input;
                    parameter3.ParameterName = "p_password";
                    parameter3.Value = p_password;
                    parameter3.Value = p_password;
                    command.Parameters.Add(parameter3);



                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }

            return dataTable;
        }


        // grant privigele for user on table TAIKHOAN
        public static void Grant(string p_user_role_name, string p_action, string p_table, string p_row, string p_allowgrant)
        {
            DataTable dataTable = new DataTable();

            using (OracleConnection connection = GetOracleConnection())
            {
                try
                {
                    connection.Open();

                    string queryString;

                    if (p_action.ToUpper() == "INSERT" || p_action.ToUpper() == "DELETE")
                    {
                        queryString = "GRANT " + p_action + " ON ATBM." + p_table + " TO " + p_user_role_name + " " + p_allowgrant;
                    }

                    else if (p_action.ToUpper() == "SELECT" || p_action.ToUpper() == "UPDATE")
                    {
                        queryString = "GRANT " + p_action + " ON ATBM." + p_table + " TO " + p_user_role_name + " " + p_allowgrant;
                    }
                    else
                    {
                        return;
                    }


                    OracleCommand command = new OracleCommand(queryString, connection);

                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    adapter.Fill(dataTable);
                    MessageBox.Show("Cấp quyền thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public static void Revoke(string p_user_role_name, string p_action, string p_table, string p_row)
        {
            DataTable dataTable = new DataTable();

            using (OracleConnection connection = GetOracleConnection())
            {
                try
                {
                    connection.Open();

                    string queryString;

                    if (p_action.ToUpper() == "INSERT" || p_action.ToUpper() == "DELETE")
                    {
                        queryString = "REVOKE " + p_action + " ON " + p_table + " FROM " + p_user_role_name;
                    }

                    else if (p_action.ToUpper() == "SELECT" || p_action.ToUpper() == "UPDATE")
                    {
                        queryString = "REVOKE " + p_action + " (" + p_row + " ) ON " + p_table + " FROM " + p_user_role_name;
                    }
                    else
                    {
                        return;
                    }

                    OracleCommand command = new OracleCommand(queryString, connection);

                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        //get all privileges all users on TAIKHOAN
        public static DataTable GET_OBJECT_PRIVILEGES(string p_table)
        {
            DataTable dataTable = new DataTable();

            using (OracleConnection connection = GetOracleConnection())
            {
                try
                {
                    connection.Open();

                    //string queryString = "BEGIN GET_OBJECT_PRIVILEGES('" + p_table + "'); END;";
                    /*string queryString = string.Format("SELECT GRANTEE, TABLE_NAME, PRIVILEGE, GRANTABLE   FROM DBA_TAB_PRIVS WHERE owner = 'SYS' AND table_name = {0};", p_table);*/
                    string queryString = string.Format("SELECT GRANTEE, TABLE_NAME, PRIVILEGE, GRANTABLE FROM DBA_TAB_PRIVS WHERE owner = 'ATBM' AND table_name = '{0}'", p_table);


                    OracleCommand command = new OracleCommand(queryString, connection);

                    OracleParameter parameter = new OracleParameter();
/*                    parameter.OracleDbType = OracleDbType.Varchar2;
                    parameter.Direction = ParameterDirection.Input;
                    parameter.ParameterName = "p_obj_name";
                    parameter.Value = p_table;
                    command.Parameters.Add(parameter);*/


                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return dataTable;
        }


        public static void DELETE_USER(string p_user_role_name)
        {
            DataTable dataTable = new DataTable();

            using (OracleConnection connection = GetOracleConnection())
            {
                try
                {
                    connection.Open();

                    string queryString1 = "REVOKE ALL PRIVILEGES FROM " + p_user_role_name;
                    string queryString2 = "DROP USER " + p_user_role_name;


                    //string queryString = "REVOKE ALL PRIVILEGES FROM "+ p_user_role_name + "; DROP USER " + p_user_role_name + ";";

                    //string queryString = "REVOKE ALL PRIVILEGES FROM " + p_user_role_name + "; DROP USER " + p_user_role_name;




                    new OracleCommand(queryString1, connection);
                    OracleCommand command = new OracleCommand(queryString2, connection);

                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        /*
        public static void AddUser(string p_user_role_name)
        {
            DataTable dataTable = new DataTable();


            using (OracleConnection connection = GetOracleConnection())
            {
                try
                {
                    connection.Open();


                    string queryString1 = "INSERT INTO TAIKHOAN VALUES('" + p_user_role_name + "','123')";


                    //string queryString = "REVOKE ALL PRIVILEGES FROM "+ p_user_role_name + "; DROP USER " + p_user_role_name + ";";

                    //string queryString = "REVOKE ALL PRIVILEGES FROM " + p_user_role_name + "; DROP USER " + p_user_role_name;




                    //new OracleCommand(queryString1, connection);

                    OracleCommand command = new OracleCommand(queryString1, connection);

                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            };

        }

        public static DataTable ExecCreate()
        {

            DataTable dataTable = new DataTable();

            using (OracleConnection connection = GetOracleConnection())
            {
                try
                {
                    connection.Open();

                    OracleCommand command = new OracleCommand();

                    command.Connection = connection;
                    command.CommandText = "P_CREATEUSER";

                    command.CommandType = CommandType.StoredProcedure;

                    //

                    // Khởi tạo tham số đầu ra
                    OracleParameter outputParam = new OracleParameter();
                    outputParam.OracleDbType = OracleDbType.RefCursor;
                    outputParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParam);

                    OracleDataAdapter adapter = new OracleDataAdapter(command);

                    adapter.Fill(dataTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return dataTable;
        }
        */

        public static void AddUser(string p_user_role_name)
        {
            DataTable dataTable = new DataTable();


            using (OracleConnection connection = GetOracleConnection())
            {
                try
                {
                    connection.Open();


                    string queryString1 = "INSERT INTO TAIKHOAN VALUES('" + p_user_role_name + "','123')";
                    OracleCommand command = new OracleCommand(queryString1, connection);
                    OracleDataReader reader = command.ExecuteReader();

                    // Tạo đối tượng OracleCommand để thực thi Procedure
                    string procedureName = "P_CREATEUSER";
                    OracleCommand procedureCommand = new OracleCommand(procedureName, connection);
                    procedureCommand.CommandType = CommandType.StoredProcedure;

                    // Thực thi Procedure
                    procedureCommand.ExecuteNonQuery();

                    connection.Close();
                }catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            };

        }


        // Thêm các phương thức truy vấn dữ liệu khác tại đây
    }
}
