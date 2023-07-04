namespace маршрутка_онлайн.Models
{
    public class Combomodel
    {
       public card_index card_Index;
        public card_taxi card_Taxi;
        public message message;

        public Combomodel(card_index card_Index, card_taxi card_taxi, message message)
        {
            this.card_Index = card_Index;
            this.card_Taxi = card_taxi;
            this.message = message;
        }

        public Combomodel() { }
    }
}
