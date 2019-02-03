using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App13.Resources
{
    class Recipes
    {
        public string title;
        public string description;
        public List<string> directions;
        public List<string> ingredients;
        public int image;
        public Recipes (string title, string description, List<string> ingredients, List<string> directions, int image )
        {
            this.title = title;
            this.description = description;
            this.directions = directions;
            this.ingredients = ingredients;
            this.image = image;
        }

    }
}