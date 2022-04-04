using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nekiProjekt
{
   
   public class DB
    {
               
        public  MySqlConnection getConnection()
        {
            string  sql ="Server=localhost;Port=3306;Username=root;Password=9nhtgrbD7272;Database=projectwinform;SSL Mode=None";

            MySqlConnection con = new MySqlConnection(sql);

            con.Open();

            return con;
        }
       
    }
}
