using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace nekiProjekt
{
    class totalNumberQuestion
    {
        public int numberQuestions()
        {
            DB dB = new DB();

            String sql = "SELECT * FROM `projectwinform`.`questions`;";

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlConnection connection2 = dB.getConnection();
            MySqlCommand command = new MySqlCommand(sql, connection2);

            adapter.SelectCommand = command;

            adapter.Fill(table);

            return table.Rows.Count;
        }
    }
}
