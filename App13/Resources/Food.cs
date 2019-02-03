using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
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
    }
}