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

        /*public static DataTable GetRoles(string objName)
        {
            using (OracleConnection connection = GetOracleConnection())
            {
                try
                {
                    connection.Open();

                    OracleCommand command = new OracleCommand();
                    command.Connection = connection;
                    command.CommandText = "GET_OBJECT_PRIVILEGES";
                    command.CommandType = CommandType.StoredProcedure;

                    // Khởi tạo tham số đầu vào
                    OracleParameter inputParam = new OracleParameter();
                    inputParam.OracleDbType = OracleDbType.Varchar2;
                    inputParam.Direction = ParameterDirection.Input;
                    inputParam.ParameterName = "p_obj_name";
                    inputParam.Value = objName;
                    command.Parameters.Add(inputParam);

                    // Khởi tạo tham số đầu ra
                    OracleParameter outputParam = new OracleParameter();
                    outputParam.OracleDbType = OracleDbType.RefCursor;
                    outputParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParam);

                    OracleDataAdapter adapter = new OracleDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }
        */

            public static DataTable GetRoles() {

            DataTable dataTable = new DataTable();

            using (OracleConnection connection = GetOracleConnection())
            {
                try
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GET_OBJECT_PRIVILEGES";

                    OracleParameter parameter = new OracleParameter();
                    parameter.OracleDbType = OracleDbType.Varchar2;
                    parameter.Direction = ParameterDirection.Input;
                    parameter.ParameterName = "p_obj_name";
                    parameter.Value = "TAIKHOAN";

                    command.Parameters.Add(parameter);

                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    //DataTable dataTable = new DataTable();
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







        // Thêm các phương thức truy vấn dữ liệu khác tại đây
    }
}
