using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Byte;

namespace TheByte
{
    public class Recipe : FoodItem // Recipe inherits from FoodItem
    {
        public List<string> Ingredients { get; set; }
        public string Instructions { get; set; }
        public TimeSpan CookTime { get; set; }
        public bool IsFavourited { get; set; }
        public string ImagePath { get; set; }

        public Recipe(int id, string name) : base(id, name)
        {
            Ingredients = new List<string>();
        }
    }

    public class Recipes
    {
        public List<Recipe> RecipeList { get; set; }

        public Recipes()
        {
            RecipeList = new List<Recipe>
            {
                new Recipe(1, "Spaghetti Bolognese")
                {
                    Ingredients = new List<string> { "400g spaghetti", "2 tbsp olive oil", "400g minced beef", "1 onion, chopped", "2 garlic cloves, crushed", "100g carrots, grated", "2 x 400g cans chopped tomatoes", "2 tsp dried oregano", "2 tsp dried basil", "salt and pepper" },
                    Instructions = "Cook the spaghetti according to the packet instructions. \nMeanwhile, heat the oil in a pan and cook the beef until browned. \nAdd the onion, garlic and carrots and cook for a few minutes. \nAdd the tomatoes, oregano, basil, and seasoning. \nSimmer for 20 minutes. \nDrain the spaghetti and serve with the sauce.",
                    CookTime = TimeSpan.FromMinutes(30),
                    ImagePath = "../MyImages/SpaghettiBolognese.png",
                    IsFavourited = false
                },
                new Recipe(2, "Chicken Curry")
                {
                    Ingredients = new List<string> { "500g chicken breasts, cut into chunks", "2 tbsp vegetable oil", "1 onion, chopped", "2 garlic cloves, crushed", "1 tbsp curry powder", "400g can chopped tomatoes", "200ml chicken stock", "salt and pepper" },
                    Instructions = "Heat the oil in a pan and cook the chicken until browned. \nAdd the onion and garlic and cook for a few minutes. \nStir in the curry powder, tomatoes, chicken stock, and seasoning. \nSimmer for 20 minutes until the chicken is cooked through. \nServe with rice.",
                    CookTime = TimeSpan.FromMinutes(30),
                    ImagePath = "../MyImages/ChickenCurry.png",
                    IsFavourited = false
                },
                new Recipe (3, "Chocolate Cake")
                {
                    Ingredients = new List<string> { "200g self-raising flour", "200g caster sugar", "200g butter, softened", "4 eggs", "2 tbsp cocoa powder", "100g dark chocolate, melted", "2 tbsp milk" },
                    Instructions = "Preheat the oven to 180C/160C fan/gas 4. \nGrease and line two 20cm cake tins. \nBeat the flour, sugar, butter, eggs and cocoa powder together until smooth. \nStir in the melted chocolate and milk. \nDivide the mixture between the tins and bake for 20-25 minutes until risen and firm to the touch. \nCool in the tins for 10 minutes. \nTurn out onto a wire rack to cool completely.",
                    CookTime = TimeSpan.FromMinutes(45),
                    ImagePath = "../MyImages/ChocolateCake.png",
                    IsFavourited = false
                },
                new Recipe (4, "Greek Salad")
                {
                    Ingredients = new List<string> { "2 large tomatoes, chopped", "1 cucumber, sliced", "1 red onion, thinly sliced", "200g feta cheese, crumbled", "100g black olives", "2 tbsp olive oil", "1 tbsp red wine vinegar", "1 tsp dried oregano", "Salt and pepper to taste" },
                    Instructions = "In a large bowl, combine tomatoes, cucumber, red onion, feta cheese, and olives. \nIn a small bowl, whisk together olive oil, red wine vinegar, oregano, salt, and pepper. \nPour the dressing over the salad and toss gently to combine. \nServe chilled.",
                    CookTime = TimeSpan.FromMinutes(15),
                    ImagePath = "../MyImages/GreekSalad.png",
                    IsFavourited = false
                },
                new Recipe (5, "Vegetable Stir-Fry")
                {
                    Ingredients = new List<string> { "1 broccoli head, cut into florets", "1 bell pepper, thinly sliced", "1 carrot, julienned", "100g snow peas", "2 tbsp soy sauce", "1 tbsp sesame oil", "2 cloves garlic, minced", "1 tsp ginger, grated", "2 tbsp vegetable oil", "Salt and pepper to taste" },
                    Instructions = "Heat vegetable oil in a large skillet or wok over medium-high heat. \nAdd garlic and ginger, and cook for 1 minute. \nAdd broccoli, bell pepper, carrot, and snow peas. \nStir-fry for 5-7 minutes until vegetables are tender-crisp. \nDrizzle soy sauce and sesame oil over the vegetables, and toss to combine. \nSeason with salt and pepper. \nServe hot.",
                    CookTime = TimeSpan.FromMinutes(20),
                    ImagePath = "../MyImages/VegetableStirFry.png",
                    IsFavourited = false
                },
                new Recipe (6, "Caesar Salad")
                {
                    Ingredients = new List<string> { "1 head of lettuce, chopped", "1/2 cup Caesar salad dressing", "1/4 cup grated Parmesan cheese", "1 cup croutons", "Salt and pepper to taste" },
                    Instructions = "In a large bowl, combine chopped romaine lettuce, Caesar salad dressing, and grated Parmesan cheese. \nToss until the lettuce is evenly coated. \nAdd croutons and toss again. \nSeason with salt and pepper to taste. \nServe immediately.",
                    CookTime = TimeSpan.FromMinutes(10),
                    ImagePath = "../MyImages/CaesarSalad.png",
                    IsFavourited = false
                },
                new Recipe (7, "Beef Tacos")
                {
                    Ingredients = new List<string> { "500g ground beef", "1 packet taco seasoning", "8 small flour tortillas", "1 cup shredded lettuce", "1 cup diced tomatoes", "1/2 cup shredded cheddar cheese", "1/4 cup chopped fresh cilantro", "1/4 cup sour cream", "1 lime, cut into wedges" },
                    Instructions = "In a large skillet, cook ground beef over medium heat until browned. \nStir in taco seasoning and cook for an additional 5 minutes. \nWarm tortillas according to package instructions. \nFill each tortilla with beef mixture, lettuce, tomatoes, cheese, cilantro, and a dollop of sour cream. \nSqueeze lime juice over the top. \nServe immediately.",
                    CookTime = TimeSpan.FromMinutes(20),
                    ImagePath = "../MyImages/BeefTacos.png",
                    IsFavourited = false
                },
                new Recipe (8, "Vegetable Lasagna")
                {
                    Ingredients = new List<string> { "9 lasagna noodles", "2 cups marinara sauce", "2 cups ricotta cheese", "2 cups shredded mozzarella cheese", "1/2 cup grated Parmesan cheese", "2 cups assorted vegetables (such as spinach, zucchini, and bell peppers), chopped", "2 cloves garlic, minced", "1 tsp dried basil", "1 tsp dried oregano", "Salt and pepper to taste" },
                    Instructions = "Preheat the oven to 375°F (190°C). \nCook lasagna noodles according to package instructions. \nIn a large skillet, sauté garlic and assorted vegetables until tender. \nIn a separate bowl, combine ricotta cheese, basil, oregano, salt, and pepper. \nSpread a thin layer of marinara sauce on the bottom of a 9x13-inch baking dish. \nLayer with lasagna noodles, ricotta mixture, vegetable mixture, and mozzarella cheese. \nRepeat layers until all ingredients are used, ending with a layer of mozzarella cheese. \nSprinkle Parmesan cheese over the top. \nCover with foil and bake for 30 minutes. \nRemove foil and bake for an additional 10 minutes until bubbly and golden. \nLet stand for 10 minutes before serving.",
                    CookTime = TimeSpan.FromMinutes(60),
                    ImagePath = "../MyImages/VegetableLasagna.png",
                    IsFavourited = false
                },
                new Recipe(11, "Pancakes")
                {
                    Ingredients = new List<string> { "1 1/2 cups all-purpose flour", "3 1/2 tsp baking powder", "1 tsp salt", "1 tbsp white sugar", "1 1/4 cups milk", "1 egg", "3 tbsp melted butter" },
                    Instructions ="In a large bowl, sift together the flour, baking powder, salt, and sugar.\n" +
                                  "Make a well in the center and pour in the milk, egg, and melted butter. Mix until smooth.\n" +
                                  "Heat a lightly oiled griddle or frying pan over medium-high heat.\n" +
                                  "Pour or scoop the batter onto the griddle, using approximately 1/4 cup for each pancake.\n" +
                                  "Cook until bubbles form on the surface, then flip with a spatula and cook until browned on the other side.\n" +
                                  "Serve hot with your favorite toppings such as maple syrup, fresh fruit, or whipped cream.",
                    CookTime = TimeSpan.FromMinutes(15),
                    ImagePath = "../MyImages/Pancakes.png",
                    IsFavourited = false
                }
            };
        }
    }
}
