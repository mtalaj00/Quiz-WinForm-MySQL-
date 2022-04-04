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
    public partial class QuizMain : Form
    {
        int userId;
        int correctQuestion = 0;
        int questionNumber = 1;
        int totalQuestionMySql;
        const int totalQuizQuestion = 5;
        int tagCorrectAnswer;
        
        int[] arrayID = new int[totalQuizQuestion];

        public QuizMain(int id)
        {
            InitializeComponent();

            userId = id;

            Random random = new Random();
            List<int> randomNumbers = new List<int>();
            totalNumberQuestion totalNumberQuestion = new totalNumberQuestion();

            totalQuestionMySql = totalNumberQuestion.numberQuestions();
                               

            for (int i = 0; i < totalQuizQuestion; i++)
            {
                int number;

                do number = random.Next(1, totalQuestionMySql+1);
                while (randomNumbers.Contains(number));

                randomNumbers.Add(number);
            }

            for (int i = 0; i < totalQuizQuestion; i++)
            {
                arrayID[i] = randomNumbers[i];
            }

            askQuestion(questionNumber);
        }

        private void Currect_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == tagCorrectAnswer)
            {
                correctQuestion++;
            }
            if (questionNumber == totalQuizQuestion)
            {
                // end of quiz
                Score score = new Score(correctQuestion, totalQuizQuestion,userId);
                this.Hide();
                score.Show();               
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int izbor)
        {
            DB dB = new DB();

            String sql = "SELECT * FROM `projectwinform`.`questions`;";

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlConnection connection = dB.getConnection();
            MySqlCommand command = new MySqlCommand(sql, connection);

           
            switch (izbor)
            {
                case 1:
                 
                    sql = "SELECT `questions`.`text` FROM `projectwinform`.`questions` where questionID = @id;";

                    command = new MySqlCommand(sql, connection);
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[0];
                    MySqlDataReader dataReader = command.ExecuteReader();

                    label1.BackColor = System.Drawing.Color.Transparent;
                    while (dataReader.Read())
                    {
                        label1.Text = dataReader[0].ToString();
                    }
                    
                    connection.Close();

                    // currect answer

                    String correctAnswer = "";

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`currectAnswer` FROM `projectwinform`.`questions` where questionID = @id;";

                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[0];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        correctAnswer = dataReader[0].ToString();
                    }

                    connection.Close();

                    // answer on buttonA

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer1` FROM `projectwinform`.`questions` where questionID = @id;";

                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[0];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonA.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonA.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 1;
                    }
                   
                    connection.Close();

                    // answer on buttonB

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer2` FROM `projectwinform`.`questions` where questionID = @id;";
                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[0];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonB.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonB.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 2;
                    }
                    
                    connection.Close();

                    // answer on buttonC

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer3` FROM `projectwinform`.`questions` where questionID = @id;";
                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[0];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonC.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonC.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 3;
                    }
                    connection.Close();

                    // answer on buttonD

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer4` FROM `projectwinform`.`questions` where questionID = @id;";
                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[0];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonD.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonD.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 4;
                    }
                    connection.Close();

                    break;

                case 2:
              
                    sql = "SELECT `questions`.`text` FROM `projectwinform`.`questions` where questionID = @id;";

                    command = new MySqlCommand(sql, connection);
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[1];
                    dataReader = command.ExecuteReader();

                    label1.BackColor = System.Drawing.Color.Transparent;
                    while (dataReader.Read())
                    {
                        label1.Text = dataReader[0].ToString();
                    }

                    connection.Close();

                    // currect answer

                    correctAnswer = "";

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`currectAnswer` FROM `projectwinform`.`questions` where questionID = @id;";

                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[1];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        correctAnswer = dataReader[0].ToString();
                    }

                    connection.Close();

                    // answer on buttonA

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer1` FROM `projectwinform`.`questions` where questionID = @id;";

                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[1];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonA.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonA.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 1;
                    }

                    connection.Close();

                    // answer on buttonB

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer2` FROM `projectwinform`.`questions` where questionID = @id;";
                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[1];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonB.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonB.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 2;
                    }

                    connection.Close();

                    // answer on buttonC

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer3` FROM `projectwinform`.`questions` where questionID = @id;";
                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[1];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonC.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonC.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 3;
                    }
                    connection.Close();

                    // answer on buttonD

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer4` FROM `projectwinform`.`questions` where questionID = @id;";
                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[1];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonD.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonD.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 4;
                    }
                    connection.Close();

                    break;

                case 3:

                    sql = "SELECT `questions`.`text` FROM `projectwinform`.`questions` where questionID = @id;";

                    command = new MySqlCommand(sql, connection);
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[2];
                    dataReader = command.ExecuteReader();

                    label1.BackColor = System.Drawing.Color.Transparent;
                    while (dataReader.Read())
                    {
                        label1.Text = dataReader[0].ToString();
                    }

                    connection.Close();

                    // currect answer

                    correctAnswer = "";

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`currectAnswer` FROM `projectwinform`.`questions` where questionID = @id;";

                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[2];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        correctAnswer = dataReader[0].ToString();
                    }

                    connection.Close();

                    // answer on buttonA

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer1` FROM `projectwinform`.`questions` where questionID = @id;";

                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[2];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonA.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonA.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 1;
                    }

                    connection.Close();

                    // answer on buttonB

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer2` FROM `projectwinform`.`questions` where questionID = @id;";
                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[2];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonB.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonB.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 2;
                    }

                    connection.Close();

                    // answer on buttonC

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer3` FROM `projectwinform`.`questions` where questionID = @id;";
                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[2];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonC.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonC.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 3;
                    }
                    connection.Close();

                    // answer on buttonD

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer4` FROM `projectwinform`.`questions` where questionID = @id;";
                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[2];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonD.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonD.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 4;
                    }
                    connection.Close();

                    break;

                case 4:

                   
                    sql = "SELECT `questions`.`text` FROM `projectwinform`.`questions` where questionID = @id;";

                    command = new MySqlCommand(sql, connection);
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[3];
                    dataReader = command.ExecuteReader();

                    label1.BackColor = System.Drawing.Color.Transparent;
                    while (dataReader.Read())
                    {
                        label1.Text = dataReader[0].ToString();
                    }

                    connection.Close();

                    // currect answer

                    correctAnswer = "";

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`currectAnswer` FROM `projectwinform`.`questions` where questionID = @id;";

                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[3];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        correctAnswer = dataReader[0].ToString();
                    }

                    connection.Close();

                    // answer on buttonA

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer1` FROM `projectwinform`.`questions` where questionID = @id;";

                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[3];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonA.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonA.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 1;
                    }

                    connection.Close();

                    // answer on buttonB

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer2` FROM `projectwinform`.`questions` where questionID = @id;";
                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[3];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonB.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonB.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 2;
                    }

                    connection.Close();

                    // answer on buttonC

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer3` FROM `projectwinform`.`questions` where questionID = @id;";
                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[3];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonC.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonC.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 3;
                    }
                    connection.Close();

                    // answer on buttonD

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer4` FROM `projectwinform`.`questions` where questionID = @id;";
                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[3];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonD.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonD.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 4;
                    }
                    connection.Close();

                    break;

                case 5:

                   
                    sql = "SELECT `questions`.`text` FROM `projectwinform`.`questions` where questionID = @id;";

                    command = new MySqlCommand(sql, connection);
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[4];
                    dataReader = command.ExecuteReader();

                    label1.BackColor = System.Drawing.Color.Transparent;
                    while (dataReader.Read())
                    {
                        label1.Text = dataReader[0].ToString();
                    }

                    connection.Close();

                    // currect answer

                    correctAnswer = "";

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`currectAnswer` FROM `projectwinform`.`questions` where questionID = @id;";

                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[4];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        correctAnswer = dataReader[0].ToString();
                    }

                    connection.Close();

                    // answer on buttonA

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer1` FROM `projectwinform`.`questions` where questionID = @id;";

                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[4];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonA.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonA.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 1;
                    }

                    connection.Close();

                    // answer on buttonB

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer2` FROM `projectwinform`.`questions` where questionID = @id;";
                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[4];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonB.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonB.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 2;
                    }

                    connection.Close();

                    // answer on buttonC

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer3` FROM `projectwinform`.`questions` where questionID = @id;";
                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[4];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonC.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonC.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 3;
                    }
                    connection.Close();

                    // answer on buttonD

                    connection = dB.getConnection();
                    sql = "SELECT `questions`.`Answer4` FROM `projectwinform`.`questions` where questionID = @id;";
                    command = new MySqlCommand(sql, connection);

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = arrayID[4];
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        buttonD.Text = dataReader[0].ToString();
                    }
                    if (String.Compare(buttonD.Text, correctAnswer) == 0)
                    {
                        tagCorrectAnswer = 4;
                    }
                    connection.Close();

                    break;
            }


        }


    }
}
