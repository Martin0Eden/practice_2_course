using System.Data.SQLite;

namespace маршрутка_онлайн.Models.sql
{
    public class sql_mes
    {
        public string connectionString = "Data Source=C:\\Users\\Administrator\\DataGripProjects\\бд\\public_transport_city.sqlite";

        public async Task add(message message)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                await connection.OpenAsync();
                string insertQuery = "INSERT INTO message (fio, e_mail, mes) VALUES (@fio, @e_mail, @mes)";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@fio", message.Name);
                    insertCommand.Parameters.AddWithValue("@e_mail", message.E_mail);
                    insertCommand.Parameters.AddWithValue("@mes", message.Mes);
                    await insertCommand.ExecuteNonQueryAsync();
                }
            }
        }

    }
}
