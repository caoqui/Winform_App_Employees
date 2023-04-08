ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
BEGIN
          EXECUTE IMMEDIATE 'DROP TABLE TAIKHOAN';
      EXCEPTION
          WHEN OTHERS THEN NULL;
      END;
      /
CREATE TABLE TAIKHOAN(
    TENTK VARCHAR2(20),
    MATK VARCHAR2(10),
    MATKHAU VARCHAR2(20),
    PRIMARY KEY (MATK));BEGIN
          EXECUTE IMMEDIATE 'DROP TABLE TAIKHOAN';
      EXCEPTION
          WHEN OTHERS THEN NULL;
      END;
      /
CREATE TABLE TAIKHOAN(
    TENTK VARCHAR2(20),
    MATK VARCHAR2(10),
    MATKHAU VARCHAR2(20),
    PRIMARY KEY (MATK));


/
--INSERT DULIEU MAU
insert into TAIKHOAN VALUES('HIEU','001','123');

--TAO USER
CREATE OR REPLACE PROCEDURE p_CreateUser
AS
    CURSOR CUR IS (SELECT TENTK
                    FROM TAIKHOAN   
                    WHERE UPPER(TENTK) NOT IN (SELECT USERNAME
                                        FROM ALL_USERS));
    strSQL VARCHAR(2000);
    ck_User INT;
    Usr VARCHAR2(30);
BEGIN
    OPEN CUR;
    strSQL := 'alter session set "_ORACLE_SCRIPT"=true';
    EXECUTE IMMEDIATE (strSQL);
    LOOP
        FETCH CUR INTO Usr;
        EXIT WHEN CUR%NOTFOUND;
        
        strSQL := 'CREATE USER '||Usr||' IDENTIFIED BY 1234';
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'GRANT CREATE SESSION TO '||Usr;
        EXECUTE IMMEDIATE (strSQL);
    END LOOP;
    strSQL := 'alter session set "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE (strSQL);
END;
/
EXEC P_CREATEUSER;
/
CREATE OR REPLACE PROCEDURE P_LISTUSERS
AS
    L_USERS SYS_REFCURSOR;
    L_USERNAME all_users.username%TYPE;
    L_PASS all_users.user_id%TYPE;
BEGIN
    OPEN L_USERS FOR
    SELECT USERNAME, user_id
    FROM ALL_USERS;
    loop 
        fetch l_users
        into l_username, l_pass;
        exit when l_users%notfound;
        dbms_output.put_line(l_username||'-'||l_pass);
    end loop;
    close l_users;
END;    
/
EXEC P_LISTUSERS;
/
----xem danh sach nguowfi dung trong he thong
DECLARE
  user_list SYS_REFCURSOR;
    user_id   all_users.user_id%TYPE;
  user_name all_users.username%TYPE;
BEGIN 
  OPEN user_list FOR
    SELECT user_id, username FROM all_users;

  LOOP 
    FETCH user_list
    INTO  user_id, user_name;
    EXIT WHEN user_list%NOTFOUND;
    DBMS_OUTPUT.PUT_LINE(user_id || ' - ' || user_name);
  END LOOP;
  CLOSE user_list;  
END;
/
 