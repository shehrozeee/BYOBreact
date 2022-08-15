namespace BYOBreact.Model
{
    public class Burger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BurgerMuffins BurgerMuffins { get; set; }
        public int BurgerMuffinsId { get; set; }
        public Meat Meat { get; set; }
        public byte MeatId { get; set; }
        public Vegetables Vegetables { get; set; }
        public int VegetablesId { get; set; }
        public Sauces Sauces { get; set; }
        public int SaucesId { get; set; }
        public bool WithCheese { get; set; }
    }
}
