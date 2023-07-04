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
    }
}
