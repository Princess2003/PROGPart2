using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppPart2
{
    class Recipe
    {
        public string Name { get; private set; }
        private List<Ingredient> ingredients;
        private List<string> steps;

        public Recipe(string name)
        {
            Name = name;
            ingredients = new List<Ingredient>();
            steps = new List<string>();
        }

        public Recipe()
        {
        }

        public void EnterDetails()
        {
            Console.WriteLine("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("Ingredient {0}:", i + 1);
                Console.Write("Name: ");
                string ingredientName = Console.ReadLine();
                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());
                Console.Write("Unit of Measurement: ");
                string unit = Console.ReadLine();
                Console.Write("Calories: ");
                int calories = int.Parse(Console.ReadLine());
                Console.Write("Food Group: ");
                string foodGroup = Console.ReadLine();

                Ingredient ingredient = new Ingredient(ingredientName, quantity, unit, calories, foodGroup);
                ingredients.Add(ingredient);
            }

            Console.WriteLine("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine("Step {0}:", i + 1);
                Console.Write("Description: ");
                string step = Console.ReadLine();
                steps.Add(step);
            }

            Console.WriteLine("Recipe details entered successfully!");
        }

        public void Display()
        {
            Console.WriteLine("\nRecipe: {0}", Name);

            if (ingredients.Count > 0 && steps.Count > 0)
            {
                Console.WriteLine("Ingredients:");
                foreach (Ingredient ingredient in ingredients)
                {
                    Console.WriteLine("{0} {1} - {2} calories - {3}", ingredient.Quantity, ingredient.Unit, ingredient.Calories, ingredient.FoodGroup);
                }

                Console.WriteLine("\nSteps:");
                for (int i = 0; i < steps.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, steps[i]);
                }

                int totalCalories = CalculateTotalCalories();
                Console.WriteLine("\nTotal Calories: {0}", totalCalories);

                if (totalCalories > 300)
                {
                    Console.WriteLine("This recipe exceeds 300 calories!");
                }
            }
            else
            {
                Console.WriteLine("No recipe details available.");
            }

            Console.WriteLine();
        }

        private int CalculateTotalCalories()
        {
            int totalCalories = 0;

            foreach (Ingredient ingredient in ingredients)
            {
                totalCalories += ingredient.Calories;
            }

            return totalCalories;
        }

        public void Scale(double factor)
        {
            foreach (Ingredient ingredient in ingredients)
            {
                ingredient.Scale(factor);
            }
        }

        public void ResetQuantities()
        {
            foreach (Ingredient ingredient in ingredients)
            {
                ingredient.ResetQuantity();
            }
        }

        public int CompareTo(Recipe other)
        {
            return string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }

        internal void Scale()
        {
            throw new NotImplementedException();
        }

        internal void ClearData()
        {
            throw new NotImplementedException();
        }
    }
}