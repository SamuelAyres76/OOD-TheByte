using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TheByte;

namespace My_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Recipes recipes;

        [TestInitialize]
        public void Setup()
        {
            // Arrange: Initialize Recipes object
            recipes = new Recipes();
        }

        [TestMethod]
        public void Recipes_LoadedSuccessfully()
        {
            // Act
            int expectedRecipeCount = 9;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedRecipeCount, recipes.RecipeList.Count);
        }

        [TestMethod]
        public void Recipe_Favoriting()
        {
            // Arrange
            Recipe recipe = new Recipe(10, "Test Recipe");

            // Act
            recipe.IsFavourited = true;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(recipe.IsFavourited);
        }

        [TestMethod]
        public void Recipe_CookTimeFormat()
        {
            // Arrange
            TimeSpan cookTime = TimeSpan.FromMinutes(45);

            // Act
            string formattedCookTime = cookTime.ToString(@"hh\:mm");

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("00:45", formattedCookTime);
        }

        [TestMethod]
        public void Recipe_InstructionsNotEmpty()
        {
            // Arrange
            Recipe recipe = new Recipe(10, "Test Recipe");
            recipe.Instructions = "Test instructions";

            // Act
            bool instructionsNotEmpty = !string.IsNullOrEmpty(recipe.Instructions);

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(instructionsNotEmpty);
        }
    }
}