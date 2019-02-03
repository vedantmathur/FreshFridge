
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
            base.Recreate();
            SetContentView(Resource.Layout.newItemDialog);
            // Create your application here

            EditText name = FindViewById<EditText>(Resource.Id.itemName);
            Button submit = FindViewById<Button>(Resource.Id.submit);
            DatePicker dateBought = FindViewById<DatePicker>(Resource.Id.buyDate);
            NumberPicker quantity = FindViewById<NumberPicker>(Resource.Id.quantity);

            submit.Click += (o,e) =>
            {
                if(quantity.Value != 0 && name.Text != "")
                {
                    return;                           
                }
            };

        }


    }
}
