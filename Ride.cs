using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Assignment1
{
    internal class Ride
    {
        public Location start_location { set; get; }
        public Location end_location { set; get; }
        public int price { set; get; }
        public Driver driver { set; get; }
        public Passenger passenger { set; get; }

        public Ride()
        {
            start_location = new Location();
            end_location = new Location();
            driver = new Driver();
            passenger = new Passenger();
            price=0;


        }

        public void AssignPassenger()
        {
            Console.Write("Enter name :");
            string name = Console.ReadLine();
            Console.WriteLine();


            Console.Write("Enter phone_No :");
            string p_no = Console.ReadLine();
            Console.WriteLine();
            
            passenger.Name = name;
            passenger.Phone_no = p_no;
        }


        public void SetLocation()
        {
            Console.Write("Enter your Starting Location in the form of (Laatitude,Longitude) :");
            String s_loc = Console.ReadLine();
            Console.WriteLine();
            string[] start = s_loc.Split(',');

            start_location.Latitude = float.Parse(start[0]);
            start_location.Longitude = float.Parse(start[1]);





            Console.Write("Enter your Ending Location in the form of (Laatitude,Longitude) :");
            String e_loc = Console.ReadLine();

            Console.WriteLine();

            string[] end = e_loc.Split(',');

            end_location.Latitude = float.Parse(end[0]);
            end_location.Longitude = float.Parse(end[1]);

        }


        public void assignDriver()
        {
            Console.Write("Enter Ride type(Car,Bike,Rikshaw):");
            String r_type = Console.ReadLine();
            Console.WriteLine();

            FileStream fin=null;
            StreamReader sr=null;
            try
            {



                 fin = new FileStream("DriversList.txt", FileMode.Open, FileAccess.Read);
                 sr = new StreamReader(fin);







                bool val = false;
                Driver closestDriver = new Driver();
                double minDistance = double.MaxValue;



                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Driver d = JsonSerializer.Deserialize<Driver>(s);

                    if (d.Availability && d.vehicle != null && d.vehicle.Type == r_type)
                    {
                        double distance = Math.Sqrt(Math.Pow(d.Curr_location.Latitude - start_location.Latitude, 2) +
                                                    Math.Pow(d.Curr_location.Longitude - start_location.Longitude, 2));
                        if (distance < minDistance)
                        {
                            minDistance = distance;
                            closestDriver = d;
                            
                            val = true;
                        }
                    }



                }





                if (val == false)
                {
                    Console.WriteLine("Their is no driver available ");
                    Console.WriteLine();
                    return;
                }

                else
                {
                    
                    driver = closestDriver;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            finally
            {
                sr.Close();
                fin.Close();
            }

            
        }













        public void CalculatePrice()
        {
            int fuel_price = 260;

           
            double distance = Math.Sqrt(Math.Pow(end_location.Latitude - start_location.Latitude, 2) +
                                    Math.Pow(end_location.Longitude - start_location.Longitude, 2));


           

            if (driver.vehicle.Type == "car" || driver.vehicle.Type == "Car")
            {

                 price = (int)((distance * fuel_price) / 15 + 20);
                Console.WriteLine("The Price is :" + price);
                Console.WriteLine();

            }
            else if (driver.vehicle.Type == "bike" || driver.vehicle.Type == "Bike ")

            {
                price = (int)((distance * fuel_price) / 50 + 5);
                Console.WriteLine("The price is :" + price);
                Console.WriteLine();

            }

            else if (driver.vehicle.Type == "rikshaw" || driver.vehicle.Type == "Rikshaw ")

            {
                price = (int)((distance * fuel_price) / 35 + 10);
                Console.WriteLine("The Price is :" + price);
                Console.WriteLine();

            }

        }

    }
}
