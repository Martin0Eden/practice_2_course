using System.Data;
using System.Data.SQLite;

namespace маршрутка_онлайн.Models
{
    public class sql
    {
        string connectionString = "Data Source=C:\\Users\\Administrator\\DataGripProjects\\бд\\public_transport_city.sqlite";
        /*string connectionString = "Data Source=..\\..\\public_transport_city.sqlite";*/

        public void vyvod(List<card_index>card_)
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
                                card_.Add(new card_index());
                                card_[i].zag = reader.GetString(0);
                                card_[i].text1 = reader.GetString(1);
                                card_[i].text2 = reader.GetString(2);
                                card_[i].text3 = reader.GetString(3);
                                card_[i].img= reader.GetString(4);
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


