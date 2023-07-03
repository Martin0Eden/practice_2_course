namespace маршрутка_онлайн.Models
{
    public class message
    {
        public string Name { get; set; }
        public string E_mail { get; set; }
        public string Mes { get; set; }

        public message(string name, string e_mail, string mes)
        {
            Name = name;
            E_mail = e_mail;
            Mes = mes;
        }

        public message(){}

    }
}
