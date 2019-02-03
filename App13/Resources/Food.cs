using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace App13.Resources
{
    public class Food
    {
        public string name;
        public int daysleft;
        public DateTime dateBought;

        public Food(string name, DateTime dateBought, int picture) 
        {
            this.name = name;
            this.daysleft = 4;
            this.dateBought = dateBought;
            //using (var reader = new StreamReader($"/Assets/fridgedata.csv"))
            //{
            //    if (name == reader.ReadLine())
            //    {
            //        daysleft = int.Parse(reader.ReadLine()) - (dateBought.Hour / 24);
            //    }
            //    else
            //    {
            //        Console.WriteLine("How long does this item last?");
            //        int shelflife = int.Parse(Console.ReadLine());
            //        daysleft = shelflife - (dateBought.Hour / 24);

            //    }
            //}
        }

        public static void getimage()
        {
            var webClient = new WebClient();
            webClient.DownloadDataCompleted += (s, e) => {
                var bytes = e.Result; // get the downloaded data
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                string localFilename = "downloaded.png";
                string localPath = Path.Combine(documentsPath, localFilename);
                File.WriteAllBytes(localPath, bytes); // writes to local storage
            };
            var url = new Uri("https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png");
            webClient.DownloadDataAsync(url);
            InvokeOnMainThread(() => {
                textView.Text = text;
                new UIAlertView("Done", "Image downloaded and saved", null, "OK", null).Show();
            });
        }


    }
}