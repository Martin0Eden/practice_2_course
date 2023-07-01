using System.Data.SQLite;

namespace маршрутка_онлайн.Models.sql
{
    public class sql_taxi
    {
        public string name;

        public sql_taxi(string name)
        {
            this.name = name;
        }


        public string connectionString = "Data Source=C:\\Users\\Administrator\\DataGripProjects\\бд\\public_transport_city.sqlite";
        public void rider(List<card_taxi> list)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = $"SELECT * FROM {name}";
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
    }
}
