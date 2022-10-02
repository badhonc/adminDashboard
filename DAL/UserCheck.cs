using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Domain;

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
    }
}
