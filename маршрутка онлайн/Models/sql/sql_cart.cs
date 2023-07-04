using System.Data.SQLite;

namespace маршрутка_онлайн.Models.sql
{
    public class sql_cart
    {
        public string connectionString = "Data Source=C:\\Users\\Administrator\\DataGripProjects\\бд\\public_transport_city.sqlite";
        public void rider(List<cart> list)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM path";
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                list.Add(new cart());
                                list[i].name = reader.GetString(0);
                                list[i].price = reader.GetString(1);
                                list[i].time_start = reader.GetString(2);
                                list[i].time_end = reader.GetString(3);
                                list[i].interval = reader.GetString(4);
                                list[i].point_start = reader.GetString(5);
                                list[i].point_end = reader.GetString(6);
                                list[i].full_path = reader.GetString(7);
                                list[i].work = reader.GetString(8);
                                list[i].color = reader.GetString(9);
                                i++;
                            }
                        }
                    }
                }

                connection.Close();
            }
        }
        public async Task Add(cart message)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                await connection.OpenAsync();
                string insertQuery = $"INSERT INTO path (name, price, time_start, time_end, interval, point_start, point_end, full_path, work, color) VALUES (@name, @price, @time_start, @time_end, @interval, @point_start, @point_end, @full_path, @work, @color)";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@name", message.name);
                    insertCommand.Parameters.AddWithValue("@price", message.price);
                    insertCommand.Parameters.AddWithValue("@time_start", message.time_start);
                    insertCommand.Parameters.AddWithValue("@time_end", message.time_end);
                    insertCommand.Parameters.AddWithValue("@interval", message.interval);
                    insertCommand.Parameters.AddWithValue("@point_start", message.point_start);
                    insertCommand.Parameters.AddWithValue("@point_end", message.point_end);
                    insertCommand.Parameters.AddWithValue("@full_path", message.full_path);
                    insertCommand.Parameters.AddWithValue("@work", message.work);
                    insertCommand.Parameters.AddWithValue("@color", message.color);
                    await insertCommand.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Update(cart message)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                await connection.OpenAsync();
                string updateQuery = @"UPDATE path 
                      SET  
                          price = @price, 
                          time_start = @time_start, 
                          time_end = @time_end, 
                          interval = @interval, 
                          point_start = @point_start, 
                          point_end = @point_end, 
                          full_path = @full_path, 
                          work = @work, 
                          color = @color 
                      WHERE name = @name";
                using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@name", message.name);
                    updateCommand.Parameters.AddWithValue("@price", message.price);
                    updateCommand.Parameters.AddWithValue("@time_start", message.time_start);
                    updateCommand.Parameters.AddWithValue("@time_end", message.time_end);
                    updateCommand.Parameters.AddWithValue("@interval", message.interval);
                    updateCommand.Parameters.AddWithValue("@point_start", message.point_start);
                    updateCommand.Parameters.AddWithValue("@point_end", message.point_end);
                    updateCommand.Parameters.AddWithValue("@full_path", message.full_path);
                    updateCommand.Parameters.AddWithValue("@work", message.work);
                    updateCommand.Parameters.AddWithValue("@color", message.color);
                    await updateCommand.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task Delete(cart message)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                await connection.OpenAsync();
                string deleteQuery = $"DELETE FROM path  WHERE name = @name";
                using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@name", message.name);
                    deleteCommand.ExecuteNonQuery();
                    await deleteCommand.ExecuteNonQueryAsync();
                }

            }
        }
    }
}
