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
    public partial class Score : Form
    {
        int result;
        int maxQuestion;
        int userID;
        int bestScore;

        public Score(int score,int max,int id)
        {
            InitializeComponent();

            result = score;
            maxQuestion = max;
            userID = id;
        }


        private void Score_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;

            label2.Text = result.ToString() + " / " + maxQuestion;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DB dB = new DB();

            String sql = "SELECT `score`.`score` FROM `projectwinform`.`score` where userID = @id;";

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlConnection connection = dB.getConnection();
            MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = userID;

            MySqlDataReader dataReader = command.ExecuteReader();
           
            while (dataReader.Read())
            {
                bestScore = Convert.ToInt32(dataReader[0].ToString());
            }

            connection.Close();

            if (result > bestScore)
            {
                connection = dB.getConnection();
                sql = "UPDATE `projectwinform`.`score` SET `score` = @score WHERE `userID` = @id";
                command = new MySqlCommand(sql,connection);
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = userID;
                command.Parameters.Add("@score", MySqlDbType.VarChar).Value = result;
                command.ExecuteNonQuery();
                connection.Close();
            }
            this.Hide();
            Menu main = new Menu(userID);            
            main.Show();
        }
    }
}
