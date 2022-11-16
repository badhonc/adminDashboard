using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace DAL
{
    public class UserCheck
    {

        public static Users CheckLogin(Users objUser)
        {
            string selectUser = "select user_name,password from Users where user_name =@Username and password = @password";

            var con = DbConnection.GetConnection();
            return con.Query<Users>(selectUser, objUser).FirstOrDefault();
        }
        public static bool Insert(Users u)
        {
            string inUser = "insert into users (user_name,password,firstName,lastName,email,contact_no) values (@username,@password,@firstname,@lastname,@email,@contact_no)";
            using(var con = DbConnection.GetConnection())
            {
                return con.Execute(inUser, u) > 0;
            }
        }
    }
}
