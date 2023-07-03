using System.Data.SQLite;

namespace маршрутка_онлайн.Models.sql
{
    public class sql_ad
    {
        private readonly string connectionString;

        public sql_ad(string name)
        {
            this.connectionString = name;
        }

        public void rider(List<admin> list)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = $"SELECT * FROM admin";
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                list.Add(new admin());
                                list[i].log = reader.GetString(0);
                                list[i].pass = reader.GetString(1);

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
