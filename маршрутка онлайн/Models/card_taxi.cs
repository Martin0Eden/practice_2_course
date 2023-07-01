namespace маршрутка_онлайн.Models
{
    public class card_taxi
    {
        public string zag { get; set; }

        public string text { get; set; }

        public string num { get; set; }

        public string img { get; set; }
        public string ins { get; set; }
        public string ok { get; set; }
        public string tg { get; set; }
        public string vb { get; set; }
        public string wa { get; set; }
        public string vk { get; set; }

        public card_taxi(string zag, string text1, string text3, string img)
        {
            this.zag = zag;
            this.text = text1;
            this.num = text3;
            this.img = img;
        }

        public card_taxi() { }
    }
}
