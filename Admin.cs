using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Assignment1
{
    internal class Admin
    {
      
        public FileStream ListsDrivers;


        private int counter;

        public Admin()
        {
            
            ListsDrivers = null;
            counter = 0;


        }


        public void AddDriver()
        {
            int i = File.ReadAllLines("DriversList.txt").Length;
            if (i == 0)
            {
                counter = 1;
            }
            else
            {
                counter = i + 1;
            }


            /*Console.WriteLine();

            Console.Write("Enter name :");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter Age :");
            int age = int.Parse(Console.ReadLine());
            while (age < 0)
            {
                Console.WriteLine("Age could not be negative ");
                Console.Write("Enter Age :");
                age = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.Write("Enter Address :");
            string address = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter Gender :");
            string gender = Console.ReadLine();
            while (gender != "Male" && gender != "Female")
            {
                Console.WriteLine("You have Entered the Wrong Gender");
                Console.Write("Enter Gender (Male or Female):");
                gender = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("Enter Phone_No :");
            string p_No = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter Vehicle Type:");
            string v_type = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter Vehicle Model :");
            string v_model = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter Vehicle License Plate :");
            string v_l_plate = Console.ReadLine();
            Console.WriteLine();*/

            Console.WriteLine();
            Console.Write("Enter name :");
            Console.ForegroundColor = ConsoleColor.Green;

            string name = Console.ReadLine();
            Console.ResetColor();

            Console.WriteLine();



            Console.Write("Enter Age :");

            Console.ForegroundColor = ConsoleColor.Green;





            int age = int.Parse(Console.ReadLine());
            Console.ResetColor();
            while (age < 0)
            {
                Console.WriteLine("Age could not be negative ");
                Console.Write("Enter Age :");
                Console.ForegroundColor = ConsoleColor.Green;

                age = int.Parse(Console.ReadLine());
                Console.ResetColor();
            }
            Console.WriteLine();

            Console.Write("Enter Address :");
            Console.ForegroundColor = ConsoleColor.Green;
            string address = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Enter Gender :");
            Console.ForegroundColor = ConsoleColor.Green;
            string gender = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine();
            while (gender != "Male" && gender != "Female")
            {
                Console.WriteLine("You have Entered the Wrong Gender");
                Console.Write("Enter Gender (Male or Female):");
                gender = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("Enter Phone_No :");
            Console.ForegroundColor = ConsoleColor.Green;
            string p_No = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Enter Vehicle Type:");
            Console.ForegroundColor = ConsoleColor.Green;
            string v_type = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Enter Vehicle Model :");
            Console.ForegroundColor = ConsoleColor.Green;
            string v_model = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Enter Vehicle License Plate :");
            Console.ForegroundColor = ConsoleColor.Green;
            string v_l_plate = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine();


            Vehicle v = new Vehicle()
            {
                License_plate = v_l_plate,
                Type = v_type,
                Model = v_model
            };

            Driver x = new Driver()
            {
                id = counter,
                Name = name,
                Age = age,
                Gender = gender,
                Address = address,
                Phone_no = p_No,
                vehicle = v


            };

            StreamWriter sw = null;
            try
            {
                ListsDrivers = new FileStream("DriversList.txt", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(ListsDrivers);

                String s = JsonSerializer.Serialize(x);

                sw.WriteLine(s);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            finally
            {
                sw.Close();
                ListsDrivers.Close();

            }


        

        }


       


        public void Search()
        {
            bool val = false;

            Console.Write("Enter name :");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter Age :");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter Address :");
            string address = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter Gender :");
            string gender = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter Phone_No :");
            string p_No = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter Vehicle Type:");
            string v_type = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter Vehicle Model :");
            string v_model = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter Vehicle License Plate :");
            string v_l_plate = Console.ReadLine();
            Console.WriteLine();






            FileStream fout = null;
            StreamReader sr = null;
            try
            {

                fout = new FileStream("DriversList.txt", FileMode.Open, FileAccess.Read);

                sr = new StreamReader(fout);
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Driver x = JsonSerializer.Deserialize<Driver>(s);

                    if ((string.IsNullOrEmpty(name) || x.Name == name) &&
                   (age!=0 || x.Age == age) &&
                   (string.IsNullOrEmpty(gender) || x.Gender == gender) &&
                   (string.IsNullOrEmpty(address) || x.Address == address) &&
                   (string.IsNullOrEmpty(p_No) || x.Phone_no == p_No) &&
                   (string.IsNullOrEmpty(v_type) || x.vehicle.Type == v_type) &&
                   (string.IsNullOrEmpty(v_model) || x.vehicle.Model == v_model) &&
                   (string.IsNullOrEmpty(v_l_plate) || x.vehicle.License_plate == v_l_plate))
                    {
                        val = true;
                        Console.WriteLine("................................................................");
                        Console.WriteLine("Name     Age     Gender    V.Type    V.Model    V.Licence     id");
                        Console.WriteLine(x.Name + "   " + x.Age + "   " + x.Gender + "   " + x.vehicle.Type + "   " + x.vehicle.Model + "   " + x.vehicle.License_plate + "  " + x.id);



                    }




                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sr.Close();
                fout.Close();
            }

            if (val = false)
            {
                Console.WriteLine("Driver not found ");
            }

















        }








        public void SearchDriver()
        {

            /*Console.Write("enter your id :");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("enter your name :");
            string name = (Console.ReadLine());
            Console.WriteLine();*/


            Console.Write("enter your id :");
            Console.ForegroundColor = ConsoleColor.Green;
            int id = int.Parse(Console.ReadLine());
            Console.ResetColor();

            Console.WriteLine();

            Console.Write("enter your name :");
            Console.ForegroundColor = ConsoleColor.Green;
            string name = (Console.ReadLine());
            Console.ResetColor();

            Console.WriteLine();

            bool val = false;




            StreamReader sr = null;
            StreamWriter sw = null;
            try
            {
                ListsDrivers = new FileStream("DriversList.txt", FileMode.Open, FileAccess.ReadWrite);
                sr = new StreamReader(ListsDrivers);

                FileStream tempFile = new FileStream("temp.txt", FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(tempFile);

                Driver searchDriver = new Driver();
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Driver p = JsonSerializer.Deserialize<Driver>(s);
                    if (p.id == id && p.Name == name)
                    {
                        val = true;

                        Console.WriteLine("Hello " + p.Name + "!");
                        Console.Write("Enter your Current Location in the Form of (Langitude,Longitude):");
                        Console.ForegroundColor = ConsoleColor.Green;
                        String newloc = Console.ReadLine();
                        Console.ResetColor();
                        Console.WriteLine();
                        string[] loc = newloc.Split(',');
                        p.Curr_location.Latitude = float.Parse(loc[0]);
                        p.Curr_location.Longitude = float.Parse(loc[1]);




                        Console.WriteLine("1.  Change Availability");
                        Console.WriteLine("2.  Change Location");
                        Console.WriteLine("3.  Exit as Driver");

                        Console.Write("Select  your Choice from (1 to 3) :");
                        Console.ForegroundColor = ConsoleColor.Green;
                        int choice = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        Console.WriteLine();

                        if (choice == 1)
                        {
                            searchDriver.UpdateAvailability();
                            s = JsonSerializer.Serialize(p);

                        }
                        else if (choice == 2)
                        {
                            searchDriver.updateLocation();
                            s = JsonSerializer.Serialize(p);


                        }
                        else if (choice == 3)
                        {
                            sw.Close();
                            File.Delete("temp.txt");
                            return;
                        }
                    }
                    sw.WriteLine(s);
                }



                if (val == false)
                {
                    Console.WriteLine("Driver is not Registrered");
                    Console.WriteLine();
                    return;
                }
            }



            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine();
            }
            finally
            {
                sr?.Dispose();
                sw?.Dispose();
                ListsDrivers?.Close();

               
            }

            File.Delete("DriversList.txt");
            File.Move("temp.txt", "DriversList.txt");

        }











        public void UpdateDriver()
        {

            Console.Write("Enter id :");
            Console.ForegroundColor = ConsoleColor.Green;
            int id = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();

            bool val = false;


            StreamReader sr = null;
            StreamWriter sw = null;
            try
            {
                ListsDrivers = new FileStream("DriversList.txt", FileMode.Open, FileAccess.ReadWrite);
                sr = new StreamReader(ListsDrivers);

                FileStream tempFile = new FileStream("temp.txt", FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(tempFile);

                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Driver p = JsonSerializer.Deserialize<Driver>(s);
                    if (p.id == id)
                    {
                        val = true;

                        /*Console.Write("Enter name :");
                        string name = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("Enter Age :");
                        int age = int.Parse(Console.ReadLine());
                        while(age<0)
                        {
                            Console.WriteLine("Age could not be negative ");
                            Console.Write("Enter Age :");
                            age = int.Parse(Console.ReadLine());                     
                        }
                        Console.WriteLine();

                        Console.Write("Enter Address :");
                        string address = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("Enter Gender (Male or Female):");
                        string gender = Console.ReadLine();
                        Console.WriteLine();

                        while(gender!="Male" || gender!="Female")
                        {
                            Console.WriteLine("You have Entered the Wrong Gender");
                            Console.Write("Enter Gender (Male or Female):");
                            gender = Console.ReadLine();
                            Console.WriteLine();
                        }

                        Console.Write("Enter Phone_No :");
                        string p_No = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("Enter Vehicle Type(Car,rikshaw,Bike):");
                        string v_type = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("Enter Vehicle Model :");
                        string v_model = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("Enter Vehicle License Plate :");
                        string v_l_plate = Console.ReadLine();
                        Console.WriteLine();
*/


                        Console.Write("Enter name :");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string name = Console.ReadLine();
                        Console.ResetColor();

                        Console.WriteLine();



                        Console.Write("Enter Age :");
                        Console.ForegroundColor = ConsoleColor.Green;
                        int age = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        
                        while (age < 0)
                        {
                            Console.WriteLine("Age could not be negative ");
                            Console.Write("Enter Age :");
                            Console.ForegroundColor = ConsoleColor.Green;

                            age = int.Parse(Console.ReadLine());
                            Console.ResetColor();
                        }
                        Console.WriteLine();

                        Console.Write("Enter Address :");
                        string address = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("Enter Gender :");
                        string gender = Console.ReadLine();
                        while (gender != "Male" && gender != "Female")
                        {
                            Console.WriteLine("You have Entered the Wrong Gender");
                            Console.Write("Enter Gender (Male or Female):");
                            gender = Console.ReadLine();
                            Console.WriteLine();
                        }
                        Console.WriteLine();

                        Console.Write("Enter Phone_No :");
                        Console.ForegroundColor = ConsoleColor.Green;




                        string p_No = Console.ReadLine();
                        Console.ResetColor();
                        Console.WriteLine();

                        Console.Write("Enter Vehicle Type:");
                        Console.ForegroundColor = ConsoleColor.Green;



                        string v_type = Console.ReadLine();

                        Console.ResetColor();
                        Console.WriteLine();

                        Console.Write("Enter Vehicle Model :");
                        Console.ForegroundColor = ConsoleColor.Green;



                        string v_model = Console.ReadLine();

                        Console.ResetColor();
                        Console.WriteLine();

                        Console.Write("Enter Vehicle License Plate :");
                        Console.ForegroundColor = ConsoleColor.Green;



                        string v_l_plate = Console.ReadLine();

                        Console.ResetColor();
                        Console.WriteLine();


                        if (!string.IsNullOrEmpty(name))
                        {
                            p.Name = name;
                        }
                        if (age!=0)
                        {
                            p.Age = age;
                        }

                        if (!string.IsNullOrEmpty(address))
                        {
                            p.Address = address;
                        }
                        if (!string.IsNullOrEmpty(gender))
                        {
                            p.Gender = gender;
                        }
                        if (!string.IsNullOrEmpty(name))
                        {
                            p.Name = name;
                        }
                        if (!string.IsNullOrEmpty(p_No))
                        {
                            p.Phone_no = p_No;
                        }
                        if (!string.IsNullOrEmpty(v_type))
                        {
                            p.vehicle.Type = v_type;
                        }
                        if (!string.IsNullOrEmpty(v_model))
                        {
                            p.vehicle.Model = v_model;
                        }
                        if (!string.IsNullOrEmpty(v_l_plate))
                        {
                            p.vehicle.License_plate = v_l_plate;
                        }


                      



                    }

                    string serialize = JsonSerializer.Serialize(p);
                    sw.WriteLine(serialize);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sr.Close();
                sw.Close();
                ListsDrivers.Close();
            }


            File.Delete("DriversList.txt");
            File.Move("temp.txt", "DriversList.txt");
            
            
            if (val == false)
            {
                Console.WriteLine("This driver is not Found ");
                Console.WriteLine();
            }
        }

        public void RemoveDriver()
        {
            Console.WriteLine("Enter the id :");
            Console.ForegroundColor = ConsoleColor.Green;
            int id = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();

            StreamReader sr = null;
            StreamWriter sw = null;
            try
            {
                ListsDrivers = new FileStream("DriversList.txt", FileMode.Open, FileAccess.ReadWrite);
                sr = new StreamReader(ListsDrivers);

                FileStream tempFile = new FileStream("temp.txt", FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(tempFile);

                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Driver p = JsonSerializer.Deserialize<Driver>(s);
                    if (p.id == id)
                    {
                        
                        continue;
                    }

                
                    sw.WriteLine(s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sr.Close();
                sw.Close();
                ListsDrivers.Close();
            }

            
            File.Delete("DriversList.txt");
            File.Move("temp.txt", "DriversList.txt");
        }








    }
}
