using System;

namespace Assignment_9_Crimes_and_Criminals
{
    class Program
    {
        static void Main(string[] args)
        {

            Criminal[] Criminals = new Criminal[3];
            Criminals[0] = new Criminal("Joel", 31);
            Criminals[1] = new Criminal("Jesus", 51);
            Criminals[2] = new Criminal("John", 26);

            Criminals[0].AddCrime(new Crime(DateTime.Parse("31/01/2020"), "Ascot", "Stealing"));
            Criminals[0].AddCrime(new Crime(DateTime.Parse("30/01/2020"), "Airport", "Stole dog"));

            Criminals[1].AddCrime(new Crime(DateTime.Parse("01/02/2021"), "Ascot", "Talking to Inn"));

            Criminals[2].AddCrime(new Crime(DateTime.Parse("01/02/2021"), "Ascot", "Being Friends with Inn"));


            for (int i = 0; i < Criminals.Length; i += 1)
            {
                int TotalCrime = Criminals[i].CountCrime();
                if (TotalCrime > 1)
                {
                    Console.WriteLine("CRIMINAL: " + (i + 1));
                    Console.WriteLine("EXECUTE");
                }
                else
                {
                    Console.WriteLine("CRIMINAL: " + (i + 1));
                    for (int y = 0; y < TotalCrime; y += 1)
                    {
                        Console.WriteLine("ACT: " + Criminals[i].GetCrime(y).GetAct() + " " + "LOCATION: " + Criminals[i].GetCrime(y).GetLocation());
                    }
                }
            }
            // HW
            // Add Crimes to all 3 Criminals
            // Write a for loop below which loop through all 3 criminals
            // loops through each crime for each criminal and prints all of the information.
            // Extension, if they have more than 10 crimes then show message EXECUTE 


            Criminal Joel = new Criminal("Joel", 31);
            Criminal Jesus = new Criminal("Jesus", 51);
            Criminal John = new Criminal("John", 26);

            Console.WriteLine(Joel.GetName());

            DateTime Date;
            Date = DateTime.Parse("31/01/2021");

            Crime Crime1 = new Crime(Date, "Ascot", "Armed Robbery");
            Crime Crime2 = new Crime(Date, "Airport", "Murder");
            Crime Crime3 = new Crime(Date, "Mall", "Kidnapping");

            Console.WriteLine(Joel.AddCrime(Crime1));
            Console.WriteLine(Joel.AddCrime(Crime2));
            Console.WriteLine(Joel.AddCrime(Crime3));
            

            Console.WriteLine(Joel.GetCrime(0).GetAct());
            Console.WriteLine(Joel.GetCrime(0).GetLocation());


            for (int i = 0; i < Joel.CountCrime(); i += 1)
            {
               Console.WriteLine(Joel.GetCrime(i).GetAct() + " " +  Joel.GetCrime(i).GetLocation());
            }
        }
    }
}