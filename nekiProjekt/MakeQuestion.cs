using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nekiProjekt
{
    public partial class MakeQuestion : Form
    {
        int userID;

        public MakeQuestion(int x)
        {
            InitializeComponent();

            userID = x;

            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;

            checkBoxA.BackColor = System.Drawing.Color.Transparent;
            checkBoxB.BackColor = System.Drawing.Color.Transparent;
            checkBoxC.BackColor = System.Drawing.Color.Transparent;
            checkBoxD.BackColor = System.Drawing.Color.Transparent;
        }
        CheckBox lastChecked;
        private void chk_Click(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBoxQuestion.Text.Length > 0 && textBoxA.Text.Length > 0 && textBoxB.Text.Length > 0 && textBoxC.Text.Length > 0 && textBoxD.Text.Length > 0 && (checkBoxA.Checked || checkBoxB.Checked || checkBoxC.Checked || checkBoxD.Checked))
            {
                DB dB = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                MySqlConnection connection = new MySqlConnection();
                String sql = "INSERT INTO `projectwinform`.`questions` values (NULL, @question, @correctAnswer, @answerA, @answerB, @answerC, @answerD);";

                connection = dB.getConnection();
                command = new MySqlCommand(sql,connection);

                command.Parameters.Add("@question", MySqlDbType.VarChar).Value = textBoxQuestion.Text;
                command.Parameters.Add("@answerA", MySqlDbType.VarChar).Value = textBoxA.Text;
                command.Parameters.Add("@answerB", MySqlDbType.VarChar).Value = textBoxB.Text;
                command.Parameters.Add("@answerC", MySqlDbType.VarChar).Value = textBoxC.Text;
                command.Parameters.Add("@answerD", MySqlDbType.VarChar).Value = textBoxD.Text;

                if (checkBoxA.Checked)
                {
                    command.Parameters.Add("@correctAnswer", MySqlDbType.VarChar).Value = textBoxA.Text;
                }
                else if (checkBoxB.Checked)
                {
                    command.Parameters.Add("@correctAnswer", MySqlDbType.VarChar).Value = textBoxB.Text;
                }
                else if (checkBoxC.Checked)
                {
                    command.Parameters.Add("@correctAnswer", MySqlDbType.VarChar).Value = textBoxC.Text;
                }
                else
                {
                    command.Parameters.Add("@correctAnswer", MySqlDbType.VarChar).Value = textBoxD.Text;
                }

                command.ExecuteNonQuery();
                label4.Text = "Question is saved.";
                connection.Close();
            }
            else
            {
                label4.Text = "Your request is not valid !";               
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
