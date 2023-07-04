using System.Data.SQLite;

namespace маршрутка_онлайн.Models.sql
{
    public class sql_index
    {
        public string connectionString = "Data Source=C:\\Users\\Administrator\\DataGripProjects\\бд\\public_transport_city.sqlite";
        public  void rider(List<card_index> list)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM card_index";
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                list.Add(new card_index());
                                list[i].zag = reader.GetString(0);
                                list[i].text1 = reader.GetString(1);
                                list[i].text2 = reader.GetString(2);
                                list[i].text3 = reader.GetString(3);
                                list[i].img = reader.GetString(4);
                                i++;
                            }
                        }
                    }
                }

                connection.Close();
            }
        }
        public async Task Add(card_index message)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                await connection.OpenAsync();
                string insertQuery = $"INSERT INTO card_index (head, Text1, Text2, Text3, img) VALUES (@head, @Text1, @Text2, @Text3, @img)";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@head", message.zag);
                    insertCommand.Parameters.AddWithValue("@Text1", message.text1);
                    insertCommand.Parameters.AddWithValue("@Text2", message.text2);
                    insertCommand.Parameters.AddWithValue("@img", "~" + message.img);
                    insertCommand.Parameters.AddWithValue("@Text3", message.text3);
                    await insertCommand.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Update(card_index message)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                await connection.OpenAsync();
                string updateQuery = "UPDATE card_index SET Text1 = @Text1, Text2 = @Text2, Text3 = @Text3, img = @img WHERE head = @head";
                using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@head", message.zag);
                    updateCommand.Parameters.AddWithValue("@Text1", message.text1);
                    updateCommand.Parameters.AddWithValue("@Text2", message.text2);
                    updateCommand.Parameters.AddWithValue("@img", "~" + message.img);
                    updateCommand.Parameters.AddWithValue("@Text3", message.text3);
                    await updateCommand.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task Delete(card_index message)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                await connection.OpenAsync();
                string deleteQuery = $"DELETE FROM card_index  WHERE head = @head";
                using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@head", message.zag);
                    deleteCommand.ExecuteNonQuery();
                    await deleteCommand.ExecuteNonQueryAsync();
                }

            }
        }
    }

}
