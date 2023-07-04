using System.Data.SQLite;

namespace маршрутка_онлайн.Models.sql
{
    public class sql_taxi
    {

        public sql_taxi(string name)
        {
            this.connectionString = name;
        }


        public string connectionString;
        public void rider(List<card_taxi> list)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = $"SELECT * FROM card_taxi";
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                list.Add(new card_taxi());
                                list[i].zag = reader.GetString(0);
                                list[i].text = reader.GetString(1);
                                list[i].num = reader.GetString(2);
                                list[i].img = reader.GetString(3);
                                list[i].ins = reader.GetString(4);
                                list[i].ok = reader.GetString(5);
                                list[i].vb = reader.GetString(6);
                                list[i].wa = reader.GetString(8);
                                list[i].vk = reader.GetString(9);

                                i++;
                            }
                        }
                    }
                }

                connection.Close();
            }
        }
        public async Task Add(card_taxi message)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                await connection.OpenAsync();
                string insertQuery = "INSERT INTO card_taxi (header, text, num, img, instagram, ok, telegram, viber, whatsapp, vk) VALUES (@header, @text, @num, @img, @instagram, @ok, @telegram, @viber, @whatsapp, @vk)";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@header", message.zag);
                    insertCommand.Parameters.AddWithValue("@text", message.text);
                    insertCommand.Parameters.AddWithValue("@num", message.num);
                    insertCommand.Parameters.AddWithValue("@img", "~"+message.img);
                    insertCommand.Parameters.AddWithValue("@instagram", message.ins);
                    insertCommand.Parameters.AddWithValue("@ok", message.ok);
                    insertCommand.Parameters.AddWithValue("@telegram", message.tg);
                    insertCommand.Parameters.AddWithValue("@viber", message.vb);
                    insertCommand.Parameters.AddWithValue("@whatsapp", message.wa);
                    insertCommand.Parameters.AddWithValue("@vk", message.vk);
                    await insertCommand.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Update(card_taxi message)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                await connection.OpenAsync();
                string updateQuery = "UPDATE card_taxi SET text = @text, num = @num, img = @img, instagram = @instagram, ok = @ok, telegram = @telegram, viber = @viber, whatsapp = @whatsapp, vk = @vk WHERE header = @header";
                using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@header", message.zag);
                    updateCommand.Parameters.AddWithValue("@text", message.text);
                    updateCommand.Parameters.AddWithValue("@num", message.num);
                    updateCommand.Parameters.AddWithValue("@img", "~" + message.img);
                    updateCommand.Parameters.AddWithValue("@instagram", message.ins);
                    updateCommand.Parameters.AddWithValue("@ok", message.ok);
                    updateCommand.Parameters.AddWithValue("@telegram", message.tg);
                    updateCommand.Parameters.AddWithValue("@viber", message.vb);
                    updateCommand.Parameters.AddWithValue("@whatsapp", message.wa);
                    updateCommand.Parameters.AddWithValue("@vk", message.vk);
                    await updateCommand.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task Delete(card_taxi message)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                await connection.OpenAsync();
                string deleteQuery = "DELETE FROM card_taxi WHERE header = @header";
                using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@header", message.zag);
                    deleteCommand.ExecuteNonQuery();
                    await deleteCommand.ExecuteNonQueryAsync();
                }
                
            }
        }
    }
}
