

/*--------------------------------------------------------------
 *      HTBLA-Leonding / Class 3ACIFT
 *--------------------------------------------------------------
 *      Mathias Anderl
 *--------------------------------------------------------------
 * Description:
 * This program calculates your arrival time at your favorite
 * aunt's house based on the distance and constant speed input, 
 * rounding a double value to the nearest smaller integer, with 
 * optional use of basic conditional statements.
 *--------------------------------------------------------------
 */

using System;

namespace BesuchDerTante
{
    class Program
    {
        public static void Main(string[] args)
        {
            int startHour = 10;

            Console.WriteLine("Besuch bei der Lieblingstante-Rechner");
            Console.WriteLine("=====================================");
            Console.WriteLine();
            Console.WriteLine("Sie fahren um Punkt 10:00 Uhr los\n");
            
            // Input: Enter distance and speed
            Console.Write("Entfernung bis zur Tante in km: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            if (distance <= 0)
            {
                Console.WriteLine("Die eingegebene Entfernung ist ungültig. Bitte korrigieren Sie sie.");
            }
            else
            {
                Console.Write("Geben Sie bitte Ihre durchschnittliche Geschwindigkeit in km/h ein: ");
                double speed = Convert.ToDouble(Console.ReadLine());

                if (speed <= 0)
                {
                    Console.WriteLine("Die eingegebene Geschwindigkeit ist ungültig. Bitte korrigieren Sie sie.");
                }
                else
                {
            
			// Data Processing: Calculate travelTime and arrivingTime
                    double travelTime = distance / speed;
                    int travelHours = (int)travelTime;
                    int travelMinutes = (int)((travelTime - travelHours) * 60);

                    DateTime startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, startHour, 0, 0);
                    DateTime arrivalTime = startTime.AddHours(travelHours).AddMinutes(travelMinutes);

                    if (arrivalTime.Hour >= 24)
                    {
                        arrivalTime = arrivalTime.AddDays(1);
                        arrivalTime = arrivalTime.Subtract(new TimeSpan(24, 0, 0));
                    }

            // Output: Display travelTime and arrivalTime
                    Console.WriteLine("\nReisedauer: {0} Stunden {1} Minuten", travelHours, travelMinutes);
                    Console.WriteLine("Ankunftszeit: {0:HH:mm}", arrivalTime);

                    Console.WriteLine("\n=====================================\n");

                    int hours = arrivalTime.Hour;

            // Output: ArrivalTime evaluation
                    if (hours < 12)
                    {
                        Console.WriteLine("Ihr Eintreffen erfolgt vor der Mittagszeit. Sie bekommen ein Mittagessen.");
                    }
                    else if (hours == 12)
                    {
                        Console.WriteLine("Ihr Eintreffen erfolgt pünktlich zur Mittagszeit. Sie bekommen ein Mittagessen.");
                    }
                    else if (hours > 12 && hours <= 19)
                    {
                        Console.WriteLine("Das Mittagessen wird versäumt, aber Sie kommen rechtzeitig an Ihrem Ziel an, um Kaffee und Kuchen zu genießen.");
                    }
                    else if (hours > 20)
                    {
                        Console.WriteLine("Sie sind zu spät. Ihre Tante schläft bereits.");
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingaben. Ergebnis konnte nicht berechnet werden.");
                    }
                }
            }

            Console.WriteLine("\n\nZum Beenden eine beliebige Eingabetaste drücken....");
            Console.ReadLine();
        }
    }
}


