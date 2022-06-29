namespace PizzaTime.Models
{
    public class PizzaBuilderModel
    {
        public string ImageTitle { get; set; }

        public string PizzaName { get; set; }

        public bool RedSauce { get; set; }

        public bool WhiteSauce { get; set; }

        public bool Mozzarella { get; set; }

        public bool Pepperoni { get; set; }

        public bool Mushrooms { get; set; }

        public bool Pineapple { get; set; }

        public bool Spinach { get; set; }

        public bool Onions { get; set; }

        public float BasePrice { get; set; }

        public float FinalPrice { get; set; }
    }
}
