using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Driver
    {
        public int id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
        public string Gender { set; get; }
        public string Address { set; get; }
        public string Phone_no { set; get; }

        public Location Curr_location { set; get; }
        public Vehicle vehicle { set; get; }
        public List<int> Rating { set; get; }

        public bool Availability { set; get; }

        public Driver()
        {
            Curr_location = new Location();
            vehicle = new Vehicle();
            Availability = true;
            Rating = new List<int>();
            Rating = null;

        }
        public void UpdateAvailability()
        {
            Console.Write("To change your Availbility ,If your are available then Press 1 else press 0:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (num > 0)
            {
                Availability = true;
            }
            else
            {
                Availability = false;
            }

        }
        public void updateLocation()
        {
            Console.Write("Enter your Langitude position:");
            float latit = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter your Longitude position:");
            float longit = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Curr_location.Latitude = latit;
            Curr_location.Longitude = longit;


        }

        public double GetRating()
        {
            double sum = 0;
            foreach (int rating in Rating)
            {
                sum += rating;
            }
            return sum / Rating.Count;
        }

    }
}
