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

        public Recipe(int id, string name) : base(id, name)
        {
            Ingredients = new List<string>();
        }
    }

    internal class Recipes
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
                    IsFavourited = false
                },
                new Recipe(2, "Chicken Curry")
                {
                    Ingredients = new List<string> { "500g chicken breasts, cut into chunks", "2 tbsp vegetable oil", "1 onion, chopped", "2 garlic cloves, crushed", "1 tbsp curry powder", "400g can chopped tomatoes", "200ml chicken stock", "salt and pepper" },
                    Instructions = "Heat the oil in a pan and cook the chicken until browned. \nAdd the onion and garlic and cook for a few minutes. \nStir in the curry powder, tomatoes, chicken stock, and seasoning. \nSimmer for 20 minutes until the chicken is cooked through. \nServe with rice.",
                    CookTime = TimeSpan.FromMinutes(30),
                    IsFavourited = false
                },
                new Recipe (3, "Chocolate Cake")
                {
                    Ingredients = new List<string> { "200g self-raising flour", "200g caster sugar", "200g butter, softened", "4 eggs", "2 tbsp cocoa powder", "100g dark chocolate, melted", "2 tbsp milk" },
                    Instructions = "Preheat the oven to 180C/160C fan/gas 4. \nGrease and line two 20cm cake tins. \nBeat the flour, sugar, butter, eggs and cocoa powder together until smooth. \nStir in the melted chocolate and milk. \nDivide the mixture between the tins and bake for 20-25 minutes until risen and firm to the touch. \nCool in the tins for 10 minutes. \nTurn out onto a wire rack to cool completely.",
                    CookTime = TimeSpan.FromMinutes(45),
                    IsFavourited = false
                },
                new Recipe (4, "Greek Salad")
                {
                    Ingredients = new List<string> { "2 large tomatoes, chopped", "1 cucumber, sliced", "1 red onion, thinly sliced", "200g feta cheese, crumbled", "100g black olives", "2 tbsp olive oil", "1 tbsp red wine vinegar", "1 tsp dried oregano", "Salt and pepper to taste" },
                    Instructions = "In a large bowl, combine tomatoes, cucumber, red onion, feta cheese, and olives. \nIn a small bowl, whisk together olive oil, red wine vinegar, oregano, salt, and pepper. \nPour the dressing over the salad and toss gently to combine. \nServe chilled.",
                    CookTime = TimeSpan.FromMinutes(15),
                    IsFavourited = false
                },
                new Recipe (5, "Vegetable Stir-Fry")
                {
                    Ingredients = new List<string> { "1 broccoli head, cut into florets", "1 bell pepper, thinly sliced", "1 carrot, julienned", "100g snow peas", "2 tbsp soy sauce", "1 tbsp sesame oil", "2 cloves garlic, minced", "1 tsp ginger, grated", "2 tbsp vegetable oil", "Salt and pepper to taste" },
                    Instructions = "Heat vegetable oil in a large skillet or wok over medium-high heat. \nAdd garlic and ginger, and cook for 1 minute. \nAdd broccoli, bell pepper, carrot, and snow peas. \nStir-fry for 5-7 minutes until vegetables are tender-crisp. \nDrizzle soy sauce and sesame oil over the vegetables, and toss to combine. \nSeason with salt and pepper. \nServe hot.",
                    CookTime = TimeSpan.FromMinutes(20),
                    IsFavourited = false
                },
                new Recipe (6, "Classic Caesar Salad")
                {
                    Ingredients = new List<string> { "1 head romaine lettuce, chopped", "1/2 cup Caesar salad dressing", "1/4 cup grated Parmesan cheese", "1 cup croutons", "Salt and pepper to taste" },
                    Instructions = "In a large bowl, combine chopped romaine lettuce, Caesar salad dressing, and grated Parmesan cheese. \nToss until the lettuce is evenly coated. \nAdd croutons and toss again. \nSeason with salt and pepper to taste. \nServe immediately.",
                    CookTime = TimeSpan.FromMinutes(10),
                    IsFavourited = false
                },
                new Recipe (7, "Beef Tacos")
                {
                    Ingredients = new List<string> { "500g ground beef", "1 packet taco seasoning", "8 small flour tortillas", "1 cup shredded lettuce", "1 cup diced tomatoes", "1/2 cup shredded cheddar cheese", "1/4 cup chopped fresh cilantro", "1/4 cup sour cream", "1 lime, cut into wedges" },
                    Instructions = "In a large skillet, cook ground beef over medium heat until browned. \nStir in taco seasoning and cook for an additional 5 minutes. \nWarm tortillas according to package instructions. \nFill each tortilla with beef mixture, lettuce, tomatoes, cheese, cilantro, and a dollop of sour cream. \nSqueeze lime juice over the top. \nServe immediately.",
                    CookTime = TimeSpan.FromMinutes(20),
                    IsFavourited = false
                },
                new Recipe (8, "Vegetable Lasagna")
                {
                    Ingredients = new List<string> { "9 lasagna noodles", "2 cups marinara sauce", "2 cups ricotta cheese", "2 cups shredded mozzarella cheese", "1/2 cup grated Parmesan cheese", "2 cups assorted vegetables (such as spinach, zucchini, and bell peppers), chopped", "2 cloves garlic, minced", "1 tsp dried basil", "1 tsp dried oregano", "Salt and pepper to taste" },
                    Instructions = "Preheat the oven to 375°F (190°C). \nCook lasagna noodles according to package instructions. \nIn a large skillet, sauté garlic and assorted vegetables until tender. \nIn a separate bowl, combine ricotta cheese, basil, oregano, salt, and pepper. \nSpread a thin layer of marinara sauce on the bottom of a 9x13-inch baking dish. \nLayer with lasagna noodles, ricotta mixture, vegetable mixture, and mozzarella cheese. \nRepeat layers until all ingredients are used, ending with a layer of mozzarella cheese. \nSprinkle Parmesan cheese over the top. \nCover with foil and bake for 30 minutes. \nRemove foil and bake for an additional 10 minutes until bubbly and golden. \nLet stand for 10 minutes before serving.",
                    CookTime = TimeSpan.FromMinutes(60),
                    IsFavourited = false
                },
                new Recipe (9, "Mango Salsa")
                {
                    Ingredients = new List<string> { "2 ripe mangoes, diced", "1/2 red onion, finely chopped", "1 red bell pepper, diced", "1 jalapeno pepper, seeded and minced", "1/4 cup fresh cilantro, chopped", "Juice of 1 lime", "Salt and pepper to taste" },
                    Instructions = "In a medium bowl, combine diced mangoes, red onion, red bell pepper, jalapeno pepper, and cilantro. \nSqueeze lime juice over the top and toss gently to combine. \nSeason with salt and pepper to taste. \nCover and refrigerate for at least 30 minutes before serving.",
                    CookTime = TimeSpan.FromMinutes(15),
                    IsFavourited = false
                }
            };
        }
    }
}
