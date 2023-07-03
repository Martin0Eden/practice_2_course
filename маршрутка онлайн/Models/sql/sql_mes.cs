using System.Data.SQLite;

namespace маршрутка_онлайн.Models.sql
{
    public class sql_mes
    {
        private readonly string connectionString;

        public sql_mes(string connectionString)
        {
            this.connectionString = connectionString;
        }



        public async Task Add(message message)
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
