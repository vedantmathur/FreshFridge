
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

namespace App13
{
    [Activity(Label = "DatePickActivity")]
    public class DatePickActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.newItemDialog);
            // Create your application here

            EditText name = FindViewById<EditText>(Resource.Id.itemName);
            Button submit = FindViewById<Button>(Resource.Id.submit);
            EditText dateBought = FindViewById<EditText>(Resource.Id.buyDate);

            submit.Click += (o,e) =>
            {

            };

        }


    }
}
