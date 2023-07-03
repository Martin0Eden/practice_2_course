namespace маршрутка_онлайн.Models
{
    public class Combomodel
    {
        card_index card_Index;
        card_taxi card_Taxi;
        message message;

        public Combomodel(card_index card_Index, card_taxi card_taxi, message message)
        {
            this.card_Index = card_Index;
            this.card_Taxi = card_taxi;
            this.message = message;
        }
    }
}
