using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace nekiProjekt
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
           
            String username = textBoxUsernameReg.Text;
            String password = textBoxPasswordReg.Text;
            String repeatPassword = textBoxRepeatPassword.Text;

            if (String.Compare(password,repeatPassword)==0)
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT `users`.`Username` FROM `projectwinform`.`users` where Username =@usr;", db.getConnection());

                command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = username;
               // command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

                adapter.SelectCommand = command;

                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    label5.Text = "This username is not available.";
                   
                }
                else
                {
                    
                    String sql = "INSERT INTO  `projectwinform`.`users` values (NULL, @user, @pass);";

                    DB con = new DB();
                    MySqlConnection conn = con.getConnection();
                    MySqlCommand command2 = new MySqlCommand(sql,conn);
                    command2.CommandType = CommandType.Text;

                    command2.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
                    command2.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
                    
                    command2.ExecuteNonQuery();
                 
                    label5.Text = "Registration Success";
                }
            }
            else
            {
                label5.Text = "Password must be equal.";
            }

            db.getConnection().Close();
        }
    }
}
