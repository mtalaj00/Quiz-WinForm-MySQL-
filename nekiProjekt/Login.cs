using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace nekiProjekt
{
    
    public partial class Login : Form
    {
        public int id;

        public Login()
        {
            InitializeComponent();
                  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT `users`.`UserId`,`users`.`Username`,`users`.`Password` FROM `projectwinform`.`users` where Username =@usr and Password = @pass;", db.getConnection());

            command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {                
                String sql = "SELECT `users`.`UserId` FROM `projectwinform`.`users` where Username =@user and Password = @passw;";
                command = new MySqlCommand(sql, db.getConnection());
                command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@passw", MySqlDbType.VarChar).Value = password;

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    id =Convert.ToInt32( dataReader[0].ToString());
                }

               
                Menu menu = new Menu(id);
                this.Hide();              
                menu.Show();
            }
            else
            {
                label6.Text = "Invalid username or password";
            }
            db.getConnection().Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
           this.Hide();       
           Registration registration = new Registration();
           registration.Show();
        }

       
    }
}
 