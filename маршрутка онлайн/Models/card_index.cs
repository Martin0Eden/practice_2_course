namespace маршрутка_онлайн.Models
{
    public class card_index
    {
        public string zag { get; set; }

        public string text1 { get; set; }

        public string text2 { get; set; }

        public string text3 { get; set; }

        public string img { get; set; }

        public card_index(string zag, string text1, string text2, string text3, string img)
        {
            this.zag = zag;
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.img = img;
        }

        public card_index() {}
    }
}
