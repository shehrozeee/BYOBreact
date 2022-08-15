using BYOBreact.Model;

namespace BYOBreact.ViewModel
{
    public class BurgerViewModel
    {
        public IEnumerable<BurgerMuffins> BurgerMuffins { get; set; }
        public IEnumerable<Sauces> Sauces { get; set; }
        public IEnumerable<Vegetables> Vegetables { get; set; }
        public IEnumerable<Meat> Meats { get; set; }
        public Burger Burger { get; set; }
    }
}
