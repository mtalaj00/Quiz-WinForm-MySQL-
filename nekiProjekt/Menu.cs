using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nekiProjekt
{
    public partial class Menu : Form
    {
        public int userId;
        public Menu(int id)
        {
            InitializeComponent();
            userId = id;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlConnection connection = db.getConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            String sql = "SELECT* FROM `projectwinform`.`score` where userID = @id;";
            MySqlCommand command = new MySqlCommand(sql,connection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = userId;
            
            adapter.SelectCommand = command;

            adapter.Fill(table);
            connection.Close();
            if (table.Rows.Count < 1)
            {
                connection.Open();
                sql = "INSERT INTO  `projectwinform`.`score` values (@userid , 0);";                            
                command = new MySqlCommand(sql, connection);
                command.Parameters.Add("@userid", MySqlDbType.VarChar).Value = userId;

                command.ExecuteNonQuery();
                connection.Close();

            }
                       
            QuizMain quizMain = new QuizMain(userId);
            this.Hide();            
            quizMain.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ranking ranking = new Ranking(userId);
            ranking.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakeQuestion makeQuestion = new MakeQuestion(userId);
            makeQuestion.Show();
        }
    }
}
