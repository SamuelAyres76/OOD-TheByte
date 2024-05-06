using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TheByte;

namespace The_Byte
{
    public partial class MainWindow : Window
    {
        private List<string> sortingOptions = new List<string> { "Cook Time", "Alphabetical Order", "Favorited" };
        private Recipes recipes;
        private MediaPlayer mediaPlayer;
        private int currentRecipeId = -1;

        public MainWindow()
        {
            InitializeComponent();
            recipes = new Recipes();

            // Initialize the media player
            mediaPlayer = new MediaPlayer();

            // Load the media file
            LoadMediaFile("BGM.mp3");

            // Play the media file
            PlayMedia();

            // Play background music
            mediaPlayer.Play();

            // Populate the ListBox with recipe names
            foreach (Recipe recipe in recipes.RecipeList)
            {
                lbx_RecipesList.Items.Add(recipe.Name);
            }

            // Populate the ComboBox with sorting options
            cbx_SortByBox.ItemsSource = sortingOptions;

            Loaded += MainWindow_Loaded;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Set the text of tbx_Date to today's date
            tbx_Date.Text = DateTime.Today.ToString("dd-MM-yyyy");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lbx_CookTime_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // Favouriting a recipe.
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // Check if a recipe is currently displayed
            if (currentRecipeId != -1)
            {
                // Toggle the favourited status of the current recipe
                Recipe currentRecipe = recipes.RecipeList.FirstOrDefault(r => r.Id == currentRecipeId);
                if (currentRecipe != null)
                {
                    currentRecipe.IsFavourited = true;
                }
            }
        }

        private void tbx_CookTime_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cbx_SortByBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /*
         * SORTING MY RECIPES
         */
        private void btn_SortRecipes_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected sorting option
            string selectedSortingOption = cbx_SortByBox.SelectedItem as string;

            // Check if any sorting option is selected
            if (!string.IsNullOrEmpty(selectedSortingOption))
            {
                // Create a temporary list to hold sorted recipes
                List<Recipe> sortedRecipes = new List<Recipe>();

                // Sort the recipes based on the selected criteria
                switch (selectedSortingOption)
                {
                    case "Cook Time":
                        sortedRecipes = recipes.RecipeList.OrderBy(recipe => recipe.CookTime).ToList();
                        break;
                    case "Alphabetical Order":
                        sortedRecipes = recipes.RecipeList.OrderBy(recipe => recipe.Name).ToList();
                        break;
                    case "Favorited":
                        // Filter favorited recipes
                        sortedRecipes = recipes.RecipeList.Where(recipe => recipe.IsFavourited).ToList();
                        break;
                    default:
                        break;
                }

                // Clear the ListBox and repopulate it with the sorted recipes
                lbx_RecipesList.Items.Clear();
                foreach (Recipe recipe in sortedRecipes)
                {
                    lbx_RecipesList.Items.Add(recipe.Name);
                }
            }
        }

        private void lbx_RecipesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the name of the selected recipe
            string selectedRecipeName = lbx_RecipesList.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedRecipeName))
            {
                // Find the selected recipe by name
                Recipe selectedRecipe = recipes.RecipeList.FirstOrDefault(recipe => recipe.Name == selectedRecipeName);

                if (selectedRecipe != null)
                {
                    // Store the ID of the currently displayed recipe
                    currentRecipeId = selectedRecipe.Id;

                    tbx_RecipeName.Text = selectedRecipe.Name;
                    tbx_CookTime.Text = selectedRecipe.CookTime.ToString();
                    lbx_IngredientsList.ItemsSource = selectedRecipe.Ingredients;

                    // Clearing the previous instructions.
                    lbx_InstructionsList.Items.Clear();

                    // Adding numbers to the end of each cooking/baking instruction.
                    string[] instructions = selectedRecipe.Instructions.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                    for (int i = 0; i < instructions.Length; i++)
                    {
                        // Adding the aforementioned instructions with numbers.
                        lbx_InstructionsList.Items.Add($"{i + 1}. {instructions[i]}");
                    }

                    // Update the checkbox based on the favourited status of the selected recipe
                    chk_LikeRecipe.IsChecked = selectedRecipe.IsFavourited;
                }
            }
        }


        private void tbx_CookTime_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lbx_IngredientsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lbx_InstructionsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /* 
         * SURPRISE ME Button
         */
        private void btn_SurpriseMe_Click(object sender, RoutedEventArgs e)
        {
            // Grab a random recipe ID from one to nine.
            Random random = new Random();
            int randomRecipeId = random.Next(1, 10);

            // Find the recipe with the ID we just got.
            Recipe selectedRecipe = recipes.RecipeList.FirstOrDefault(recipe => recipe.Id == randomRecipeId);

            if (selectedRecipe != null)
            {
                // Store the ID of the currently displayed recipe.
                currentRecipeId = selectedRecipe.Id;

                // Update the right side of the screen with the selected recipe's information!
                tbx_RecipeName.Text = selectedRecipe.Name;
                tbx_CookTime.Text = selectedRecipe.CookTime.ToString();
                lbx_IngredientsList.ItemsSource = selectedRecipe.Ingredients;

                // Clear the previous information.
                lbx_InstructionsList.Items.Clear();

                // Number the Instructions.
                string[] instructions = selectedRecipe.Instructions.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                for (int i = 0; i < instructions.Length; i++)
                {
                    lbx_InstructionsList.Items.Add($"{i + 1}. {instructions[i]}");
                }

                // Update the checkbox based on the favourited status of the selected recipe.
                chk_LikeRecipe.IsChecked = selectedRecipe.IsFavourited;
            }
        }

        /*
         * MUSIC PLAYER
         */

        private void LoadMediaFile(string filename)
        {
            try
            {
                // Getting the full path of the music file.
                string mediaPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);

                // Checking if the file exists.
                if (File.Exists(mediaPath))
                {
                    // Setting the media player's source.
                    mediaPlayer.Open(new Uri(mediaPath));
                }
                // Exceptions for no BGM.mp3
                else
                {
                    MessageBox.Show("Media file not found: " + mediaPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading media file: " + ex.Message);
            }
        }

        private void PlayMedia()
        {
            try
            {
                // Play the media file
                mediaPlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing media: " + ex.Message);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Stop the media player when the window is closing
            mediaPlayer.Stop();
        }
    }
}
