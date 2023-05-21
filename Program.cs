/*using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Text.Json;

namespace Assignment1
{

    class Program
    {
        static void Main(string[] args)
        {
           
            Admin x = new Admin();
            while (true)
            {


                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("                      Welocome To My Ride                          ");
                Console.WriteLine("-------------------------------------------------------------------");

                Console.WriteLine("1.  Book a Ride\n");
                Console.WriteLine("2.  Enter as Driver\n");
                Console.WriteLine("3.  Enter as Admin\n");

                Console.Write("\n \nSelect your choice from (1 to 3) :");

                
                

                int choice = int.Parse(Console.ReadLine());

                

                Console.WriteLine();

                if (choice == 1)
                {

                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                      BOOK A RIDE                           ");
                    Console.WriteLine("-------------------------------------------------------------------");

                    Console.WriteLine();
                    Ride ride = new Ride();
                    ride.AssignPassenger();
                    ride.SetLocation();
                  
                    ride.assignDriver();
                    ride.CalculatePrice();

                    Console.WriteLine("\n--------------Thank You--------------");
                    Console.WriteLine("\nPrice For this ride is : "+ride.price);
                    StreamReader sr = null;
                    StreamWriter sw = null;
                    FileStream fout = new FileStream("Bookiing_info.txt", FileMode.Append, FileAccess.Write);
                    sw = new StreamWriter(fout);
                    char s;
                    Console.Write("\nEnter Y if you want to book th ride,Enter 'N' if you want to cancel : ");
                    s=char.Parse(Console.ReadLine());
                    Console.WriteLine();
                    string json="";
                    if (s == 'Y')
                    {
                        Console.WriteLine("\nHappy Travel-----!");
                        Console.Write("\nGive Rating (out of 5) :");
                        int rat = int.Parse(Console.ReadLine());
                        *//*ride.driver.Rating.Add(rat);*//*
                        json = JsonSerializer.Serialize(ride);
                        sw.WriteLine(json);
                        

                    }
                    else if(s=='N')
                    {
                        Console.WriteLine("\nYour Ride has been cancelled Now");
                    }


                    sw.Close();
                    fout.Close();

                    
                }
                else if (choice == 2)
                {
                    x.SearchDriver();

                   



                }
                else if (choice == 3)
                {
                    Console.WriteLine("\n 1.  Add Driver");
                    Console.WriteLine("\n 2.  Remove Driver");
                    Console.WriteLine("\n 3.  Update Driver");
                    Console.WriteLine("\n 4.  search Driver");
                    Console.WriteLine("\n 5.  Exit as Admin");

                    Console.Write("Enter your choice :");
                    int ch = int.Parse(Console.ReadLine());

                    while (ch < 5)
                    {



                        if (ch == 1)
                        {
                            x.AddDriver();

                        }
                        else if (ch == 2)
                        {
                            x.RemoveDriver();

                        }
                        else if (ch == 3)
                        {
                            x.UpdateDriver();


                        }

                        else if (ch == 4)
                        {
                            x.Search();


                        }
                        else if (ch == 5)
                        {
                            break;
                        }


                        Console.WriteLine("\n 1.  Add Driver");
                        Console.WriteLine("\n 2.  Remove Driver");
                        Console.WriteLine("\n 3.  Update Driver");
                        Console.WriteLine("\n 4.  search Driver");
                        Console.WriteLine("\n 5.  Exit as Admin");


                        Console.Write("\n Enter your choice :");
                        ch = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                    }


                }
            }




        }



    }
}











*/




using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Text.Json;


using System.Net;
using System.Reflection;
using Assignment1;

namespace Assignment3
{

    class Program
    {
        static void Main(string[] args)
        {
            Admin x = new Admin();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;



                Console.ResetColor();

                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("                      Welocome To My Ride                          ");
                Console.WriteLine("-------------------------------------------------------------------");

                Console.WriteLine("1.  Book a Ride\n");
                Console.WriteLine("2.  Enter as Driver\n");
                Console.WriteLine("3.  Enter as Admin\n");

                Console.Write("\n \nSelect your choice from (1 to 3) :");
                Console.ForegroundColor = ConsoleColor.Green;
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.ResetColor();

                if (choice == 1)
                {

                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                      BOOK A RIDE                           ");
                    Console.WriteLine("-------------------------------------------------------------------");

                    Console.WriteLine();
                    Ride ride = new Ride();
                    ride.AssignPassenger();

                    ride.SetLocation();

                    ride.assignDriver();
                    ride.CalculatePrice();


                    Console.WriteLine("\n--------------Thank You--------------");
                    Console.WriteLine("\nPrice For this ride is : " + ride.price);

                    /*char s;
                    Console.Write("\nEnter Y if you want to book th ride,Enter 'N' if you want to cancel : ");
                    Console.ForegroundColor = ConsoleColor.Green;




                    s = char.Parse(Console.ReadLine());
                    Console.ResetColor();
                    Console.WriteLine();
                    string json = "";

                    string st_loc = $"{ride.start_location.Latitude},{ride.start_location.Longitude}";
                    string end_loc = $"{ride.end_location.Latitude},{ride.end_location.Longitude}";
                    if (s == 'Y')
                    {
                        Console.WriteLine("\nHappy Travel-----!");
                        Console.Write("\nGive Rating (out of 5) :");
                        Console.WriteLine();
                        Console.WriteLine();

                        



                    }*/


                    StreamReader sr = null;
                    StreamWriter sw = null;
                    FileStream fout = new FileStream("Bookiing_info.txt", FileMode.Append, FileAccess.Write);
                    sw = new StreamWriter(fout);

                    char s;
                    Console.Write("\nEnter Y if you want to book th ride,Enter 'N' if you want to cancel : ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    s = char.Parse(Console.ReadLine());
                    Console.ResetColor();
                    Console.WriteLine();

                    string json = "";
                    if (s == 'Y')
                    {
                        Console.WriteLine("\nHappy Travel-----!");
                        Console.Write("\nGive Rating (out of 5) :");
                        int rat = int.Parse(Console.ReadLine());
                      
                        json = JsonSerializer.Serialize(ride);
                        sw.WriteLine(json);


                    }
                    else if (s == 'N')
                    {
                        Console.WriteLine("\nYour Ride has been cancelled Now");
                    }





                }
                else if (choice == 2)
                {
                    x.SearchDriver();





                }
                else if (choice == 3)
                {
                    Console.WriteLine("\n 1.  Add Driver");
                    Console.WriteLine("\n 2.  Remove Driver");
                    Console.WriteLine("\n 3.  Update Driver");
                    Console.WriteLine("\n 4.  search Driver");
                    Console.WriteLine("\n 5.  Exit as Admin");

                    Console.Write("Enter your choice :");




                    Console.ForegroundColor = ConsoleColor.Green;




                    int ch = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    while (ch < 5)
                    {



                        if (ch == 1)
                        {
                            x.AddDriver();

                        }
                        else if (ch == 2)
                        {
                            x.RemoveDriver();

                        }
                        else if (ch == 3)
                        {
                            x.UpdateDriver();


                        }

                        else if (ch == 4)
                        {
                            x.Search();


                        }
                        else if (ch == 5)
                        {
                            break;
                        }


                        Console.WriteLine("\n 1.  Add Driver");
                        Console.WriteLine("\n 2.  Remove Driver");
                        Console.WriteLine("\n 3.  Update Driver");
                        Console.WriteLine("\n 4.  search Driver");
                        Console.WriteLine("\n 5.  Exit as Admin");


                        Console.Write("\n Enter your choice :");
                        Console.ForegroundColor = ConsoleColor.Green;
                        ch = int.Parse(Console.ReadLine());
                        Console.ResetColor();

                        Console.WriteLine();
                    }


                }
            }




        }



    }
}




















