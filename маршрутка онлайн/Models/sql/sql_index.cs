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
    }

}
