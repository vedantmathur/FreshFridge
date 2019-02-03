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

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.main_activ);
            foodInPantry = new List<Food>();

            foodInPantry.Add(new Food("Paneer", new System.DateTime(), 5));

            ListView listView = FindViewById<ListView>(Resource.Id.listView);
            List<System.String> titles = new List<System.String>();
            titles.Add("Dawn of the Planet Apes");
            titles.Add("The Matrix Reloaded");
            titles.Add("Shawshank Redemption");
            titles.Add("The Godfather");
            ArrayAdapter<System.String> adapter = new ArrayAdapter<System.String>(this, Resource.Layout.item_row, Resource.Id.foodname, titles); 
            listView.SetAdapter(adapter);

            //textMessage = FindViewById<TextView>(Resource.Id.message);
            //card1 = FindViewById<CardView>(Resource.Id.cardView1);
            //card2 = FindViewById<CardView>(Resource.Id.cardView2);
            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
        }
        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    List<Food> ArrayToDisplay = PopulateCardView(item);
                    List<string> foodTitles = new List<string>();
                    foreach (var entry in ArrayToDisplay)
                    {
                        foodTitles.Add(entry.name);
                    }
                    ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Resource.Layout.item_row, Resource.Id.foodname, foodTitles);
                    ListView listView = FindViewById<ListView>(Resource.Id.listView);
                    listView.SetAdapter(adapter);
                    return true;
                case Resource.Id.navigation_dashboard:
                    //textMessage.SetText(Resource.String.title_dashboard);
                    return true;
                case Resource.Id.navigation_notifications:
                    //card1.Visibility = Android.Views.ViewStates.Invisible;
                    //card2.Visibility = ViewStates.Invisible;
                    //textMessage.SetText(Resource.String.title_notifications);
                    return true;
                default:
                    return true;
            }
            return false;
        }
        public List<Food> PopulateCardView(Android.Views.IMenuItem item)
        {
            List<Food> foods = new List<Food>();
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:

                    return foodInPantry;
                case Resource.Id.navigation_dashboard:

                    return foods;
                case Resource.Id.navigation_notifications:

                    return foods;
            }
            return foods;
        }

    }
}

