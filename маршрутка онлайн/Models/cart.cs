namespace маршрутка_онлайн.Models
{
    public class cart
    {
        public string name { get; set; }
        public string price { get; set; }
        public string time_start { get; set; }
        public string time_end { get; set; }
        public string interval { get; set; }
        public string point_start { get; set; }
        public string point_end { get; set; }
        public string full_path { get; set; }
        public string work { get; set; }
        public string color { get; set; }

        public string[] SplitAndRemoveSpaces(string input)
        {
            string[] splitted = input.Split(',');

            for (int i = 0; i < splitted.Length; i++)
            {
                splitted[i] = splitted[i].Replace(" ", "");
            }

            return splitted;
        }


        public cart(string name, string price, string time_start, string time_end, string interval, string point_start, string point_end, string full_path, string work, string color)
        {
            this.name = name;
            this.price = price;
            this.time_start = time_start;
            this.time_end = time_end;
            this.interval = interval;
            this.point_start = point_start;
            this.point_end = point_end;
            this.full_path = full_path;
            this.work = work;
            this.color = color;
        }

        public cart() { }
    }
}
