using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nekiProjekt
{
    public partial class Ranking : Form
    {
        int id;
        int userID;
        public Ranking(int x)
        {
            InitializeComponent();
            for (int i = 1; i < 6; i++)
                Ispis(i);

            userID = x;
        }

        private void Ranking_Load(object sender, EventArgs e)
        {

            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label16.BackColor = System.Drawing.Color.Transparent;

        }

        public void Ispis(int num)
        {
            DB db = new DB();

            String sql = "SELECT * FROM `projectwinform`.`questions`;";

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlConnection connection = db.getConnection();
            MySqlCommand command = new MySqlCommand(sql,connection);

        

            
            switch (num)
            {
                case 1:

                    connection = db.getConnection();
                    sql = "SELECT `score`.`userID` FROM `projectwinform`.`score` order by score desc limit 5;";
                    command = new MySqlCommand(sql, connection);

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        id = Convert.ToInt32(dataReader[0].ToString());
                    }
                    connection.Close();

                    sql = "SELECT `users`.`Username` FROM `projectwinform`.`users` where UserId = @id;";
                    connection = db.getConnection();
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        label6.Text = dataReader[0].ToString();
                    }
                    label6.BackColor = System.Drawing.Color.Transparent;
                    connection.Close();

                    connection = db.getConnection();
                    sql = "SELECT `score`.`score` FROM `projectwinform`.`score` where userID = @ids";

                    command = new MySqlCommand(sql,connection);
                    command.Parameters.Add("@ids", MySqlDbType.VarChar).Value = id;

                    dataReader = command.ExecuteReader();

                    label7.BackColor = System.Drawing.Color.Transparent;
                    while (dataReader.Read())
                    {
                        label7.Text = dataReader[0].ToString()+" / 5";
                    }

                    connection.Close();

                    break;

                case 2:

                    connection = db.getConnection();
                    sql = "SELECT `score`.`userID` FROM `projectwinform`.`score` order by score desc limit 4;";
                    command = new MySqlCommand(sql, connection);

                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        id = Convert.ToInt32(dataReader[0].ToString());
                    }
                    connection.Close();

                    sql = "SELECT `users`.`Username` FROM `projectwinform`.`users` where UserId = @id;";
                    connection = db.getConnection();
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        label8.Text = dataReader[0].ToString();
                    }
                    label8.BackColor = System.Drawing.Color.Transparent;
                    connection.Close();

                    connection = db.getConnection();
                    sql = "SELECT `score`.`score` FROM `projectwinform`.`score` where userID = @ids";

                    command = new MySqlCommand(sql, connection);
                    command.Parameters.Add("@ids", MySqlDbType.VarChar).Value = id;

                    dataReader = command.ExecuteReader();

                    label9.BackColor = System.Drawing.Color.Transparent;
                    while (dataReader.Read())
                    {
                        label9.Text = dataReader[0].ToString() + " / 5";
                    }

                    connection.Close();

                    break;

                case 3:

                    connection = db.getConnection();
                    sql = "SELECT `score`.`userID` FROM `projectwinform`.`score` order by score desc limit 3;";
                    command = new MySqlCommand(sql, connection);

                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        id = Convert.ToInt32(dataReader[0].ToString());
                    }
                    connection.Close();

                    sql = "SELECT `users`.`Username` FROM `projectwinform`.`users` where UserId = @id;";
                    connection = db.getConnection();
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        label10.Text = dataReader[0].ToString();
                    }
                    label10.BackColor = System.Drawing.Color.Transparent;
                    connection.Close();

                    connection = db.getConnection();
                    sql = "SELECT `score`.`score` FROM `projectwinform`.`score` where userID = @ids";

                    command = new MySqlCommand(sql, connection);
                    command.Parameters.Add("@ids", MySqlDbType.VarChar).Value = id;

                    dataReader = command.ExecuteReader();

                    label11.BackColor = System.Drawing.Color.Transparent;
                    while (dataReader.Read())
                    {
                        label11.Text = dataReader[0].ToString() + " / 5";
                    }

                    connection.Close();

                    break;

                case 4:

                    connection = db.getConnection();
                    sql = "SELECT `score`.`userID` FROM `projectwinform`.`score` order by score desc limit 2;";
                    command = new MySqlCommand(sql, connection);

                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        id = Convert.ToInt32(dataReader[0].ToString());
                    }
                    connection.Close();

                    sql = "SELECT `users`.`Username` FROM `projectwinform`.`users` where UserId = @id;";
                    connection = db.getConnection();
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        label12.Text = dataReader[0].ToString();
                    }
                    label12.BackColor = System.Drawing.Color.Transparent;
                    connection.Close();

                    connection = db.getConnection();
                    sql = "SELECT `score`.`score` FROM `projectwinform`.`score` where userID = @ids";

                    command = new MySqlCommand(sql, connection);
                    command.Parameters.Add("@ids", MySqlDbType.VarChar).Value = id;

                    dataReader = command.ExecuteReader();

                    label13.BackColor = System.Drawing.Color.Transparent;
                    while (dataReader.Read())
                    {
                        label13.Text = dataReader[0].ToString() + " / 5";
                    }

                    connection.Close();

                    break;

                case 5:

                    connection = db.getConnection();
                    sql = "SELECT `score`.`userID` FROM `projectwinform`.`score` order by score desc limit 1;";
                    command = new MySqlCommand(sql, connection);

                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        id = Convert.ToInt32(dataReader[0].ToString());
                    }
                    connection.Close();

                    sql = "SELECT `users`.`Username` FROM `projectwinform`.`users` where UserId = @id;";
                    connection = db.getConnection();
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        label14.Text = dataReader[0].ToString();
                    }
                    label14.BackColor = System.Drawing.Color.Transparent;
                    connection.Close();

                    connection = db.getConnection();
                    sql = "SELECT `score`.`score` FROM `projectwinform`.`score` where userID = @ids";

                    command = new MySqlCommand(sql, connection);
                    command.Parameters.Add("@ids", MySqlDbType.VarChar).Value = id;

                    dataReader = command.ExecuteReader();

                    label15.BackColor = System.Drawing.Color.Transparent;
                    while (dataReader.Read())
                    {
                        label15.Text = dataReader[0].ToString() + " / 5";
                    }

                    connection.Close();

                    break;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(userID);
            menu.Show();
        }
    }
   
           
    
}
