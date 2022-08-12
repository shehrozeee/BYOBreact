namespace BYOBreact.Model
{
    public class Burger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BurgerBun BurgerBun { get; set; }
        public byte BurgerBunId { get; set; }
        public Bread Bread { get; set; }
        public byte BreadId { get; set; }
        public Meat Meat { get; set; }
        public byte MeatId { get; set; }
        public Vegetables Vegetables { get; set; }
        public byte MeatId { get; set; }
    }
}
