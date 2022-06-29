using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaTime.Models;

namespace PizzaTime.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzaBuilderModel> pizzaDb = new List<PizzaBuilderModel>()
        {
            new PizzaBuilderModel()
            {
                ImageTitle = "Margerita",
                PizzaName = "Margerita",
                BasePrice = 10, 
                RedSauce = true, 
                Mozzarella = true,
                FinalPrice = 14
            },
            new PizzaBuilderModel() { ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice = 14, Mozzarella= true, FinalPrice = 5 },
            new PizzaBuilderModel() { ImageTitle = "Hawaiian", PizzaName = "Hawaiian", BasePrice = 2, RedSauce = true, Mozzarella = true, Pineapple = true, FinalPrice = 15 },
            new PizzaBuilderModel() { ImageTitle = "Carbonara", PizzaName = "Carbonara", BasePrice = 2, RedSauce = true, Mozzarella = true, FinalPrice = 6 },
            new PizzaBuilderModel() { ImageTitle = "MeatFeast", PizzaName = "MeatFeast", BasePrice = 2, RedSauce = true, FinalPrice = 6 },
            new PizzaBuilderModel() { ImageTitle = "Mushroom", PizzaName = "Mushroom", BasePrice = 2, RedSauce = true, Mozzarella = true, FinalPrice = 5 },
            new PizzaBuilderModel() { ImageTitle = "Pepperoni", PizzaName = "Pepperoni", BasePrice = 2, RedSauce = true, Mozzarella = true, FinalPrice = 5 },
            new PizzaBuilderModel() { ImageTitle = "Seafood", PizzaName = "Seafood", BasePrice = 2, RedSauce = true, Mozzarella = true, FinalPrice = 5 },
            new PizzaBuilderModel() { ImageTitle = "Vegetarian", PizzaName = "Vegetarian", BasePrice = 2, RedSauce = true, Mozzarella = true, Pineapple = true, FinalPrice = 12 }
        };

        public void OnGet()
        {
        }
    }
}
