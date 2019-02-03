using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using App13.Resources;

namespace App13
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        List<Food> foodInPantry;
        List<Recipes> recipeInPantry;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.main_activ);
            foodInPantry = new List<Food>();
            recipeInPantry = new List<Recipes>();

            foodInPantry.Add(new Food("Paneer", new System.DateTime(), 5));
            foodInPantry.Add(new Food("Apples", new System.DateTime(), 5));
            foodInPantry.Add(new Food("Avocado", new System.DateTime(), 5));
            foodInPantry.Add(new Food("Cheese", new System.DateTime(), 5));
            foodInPantry.Add(new Food("Spinach", new System.DateTime(), 5));
            foodInPantry.Add(new Food("Orange juice", new System.DateTime(), 5));

            recipeInPantry.Add(new Recipes("Apple Pie",
                "An apple pie is a pie filled with candied apples and occansionally topped off with whipped cream and or icecream",
                new List<string> { "1 recipe pastry for a 9 inch double crust pie", "1/2 cup unsalted butter", "3 tablespoons all-purpose flour",
                "1/4 cup water", "1/2 cup white sugar", "1/2 cup packed brown sugar", "8 Granny Smith apples - peeled, cored and sliced" },
                new List<string> { "Preheat oven to 425 degrees F (220 degrees C). Melt the butter in a saucepan. Stir in flour to form a paste." +
                " Add water, white sugar and brown sugar, and bring to a boil. Reduce temperature and let simmer.", "Place the bottom crust in your " +
                "pan. Fill with apples, mounded slightly. Cover with a lattice work crust. Gently pour the sugar and butter liquid over the crust." +
                " Pour slowly so that it does not run off.", "Bake 15 minutes in the preheated oven. Reduce the temperature to 350 degrees F " +
                "(175 degrees C). Continue baking for 35 to 45 minutes, until apples are soft"}, 5));

            recipeInPantry.Add(new Recipes("Chicken Noodle Soup", 
                "Chicken Noodle Soup is a comforting soup filled with chicken breast, noodles, and an assortment of vegatables",
                new List<string> { "1 tablespoon butter", "1/2 cup chopped onion", "1/2 cup chopped celery", "4 (14.5 ounce) cans chicken broth", "1 (14.5 ounce) can vegetable broth",
                "1/2 pound chopped cooked chicken breast", "1 1/2 cups egg noodles", "1 cup sliced carrots", "1/2 teaspoon dried basil", "1/2 teaspoon dried oregano",
                "salt and pepper to taste"}, 
                new List<string> { "In a large pot over medium heat, melt butter. Cook onion and celery in butter until just tender, 5 minutes. Pour in " +
                "chicken and vegetable broths and stir in chicken, noodles, carrots, basil, oregano, salt and pepper. Bring to a boil, then reduce heat and simmer 20 minutes " +
                "before serving." }, 3));

            recipeInPantry.Add(new Recipes("Roasted Brussel Sprouts", 
                "Perfect side of vegatables full of flavor, and a wonderful side for any meal", 
                new List<string> { "1 1/2 pounds Brussels sprouts",
                "3 tablespoons good olive oil","3/4 teaspoon kosher salt", "1/2 teaspoon freshly ground black pepper"}, 
                new List<string> { "Preheat oven to 400 degrees F.", "Cut off the brown ends of the " +
                "Brussels sprouts and pull off any yellow outer leaves. Mix them in a bowl with the olive oil, salt and pepper. Pour them on a sheet pan and roast for 35 to 40 minutes, until crisp on the" +
                " outside and tender on the inside. Shake the pan from time to time to brown the sprouts evenly. Sprinkle with more kosher salt ( I like these salty like French fries), and serve immediately." }, 7));


            //textMessage = FindViewById<TextView>(Resource.Id.message);
            //card1 = FindViewById<CardView>(Resource.Id.cardView1);
            //card2 = FindViewById<CardView>(Resource.Id.cardView2);
            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
        }


        public bool OnNavigationItemSelected(IMenuItem item)
        {
            ArrayAdapter<string> adapter;
            ListView listView = FindViewById<ListView>(Resource.Id.listView);

            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    List<string> foodTitles = new List<string>();
                    foreach (var entry in foodInPantry)
                    {
                        foodTitles.Add(entry.name);
                    }
                    adapter = new ArrayAdapter<string>(this, Resource.Layout.item_row, Resource.Id.CardTitle, foodTitles);
                    listView.SetAdapter(adapter);
                    //listView.Adapter = adapter;
                    return true;

                case Resource.Id.navigation_dashboard:
                    List<string> recipeTitles = new List<string>();
                    foreach (var entry in recipeInPantry)
                    {
                        recipeTitles.Add(entry.title);
                    }

                    adapter = new ArrayAdapter<string>(this, Resource.Layout.item_row, Resource.Id.CardTitle, recipeTitles);
                    listView.SetAdapter(adapter);
                    return true;
                case Resource.Id.navigation_notifications:
                    return true;
            }
            return false;
        }

        public void additem(string name, System.DateTime dateBought)
        {
            foodInPantry.Add(new Food(name, dateBought, 0));
        }

    }
}