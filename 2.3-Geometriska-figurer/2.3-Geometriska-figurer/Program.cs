using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Geometriska_figurer
{
    class Program
    {            
        static void Main(string[] args)
            {

                do
                {
                    int ChoiceValue;
                    ViewMenu();
                    string choice = Console.ReadLine();

                    try
                    {
                        ChoiceValue = int.Parse(choice);
                    }
                    catch
                    {
                        throw new ArgumentException();
                    }

                    switch (ChoiceValue)
                    {
                        case 0: return;

                        case 1: // ska kalla på create shape för en ellips
                            break;
                        case 2: // ska kalla på Create shape för en rektangel
                            break;
                        default: 
                            Console.WriteLine("FEL! Du måste ange ett nummer emellan 0 och 2.");
                            break;
                    }


                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Tryck valfri tangent för att börja om - ESC avslutar.");

                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

                // ska anropa metoden ViewMenu för att visa en meny.
                // om användaren inte väljer att avsluta applikationen så ska metoden Createshape anropas som ska skapa och returnera en referens 
                // till ett Ellips eller rectangle objekt.  Referens till objektet används sedan vid anrop av ViewDetail som presenterar figurens detaljet.
                // Då en beräkning är gjord så ska menyn visas igen. 

                // de ska ange ett tal emellan 0-2 då olika valmöjligheter finns för varje, om talt inte är inom det intervallet så ska ett felmedelande visas
                // samt så ska användaren få en ny chans vid meny alternativ genom att trycka valfri tangent.
            }
        private static Shape CreateShape(ShapeType shapeType)
        {
            throw new ArgumentException();
            // Ska använda något some heter Enum?, läs om det.
            // samt ska retunera en referens 
        }

        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("===================================================");
            Console.WriteLine("=                                                 =");
            Console.WriteLine("=                Geometriska figurer              =");
            Console.WriteLine("=                                                 =");
            Console.WriteLine("===================================================");
            Console.ResetColor();
            Console.WriteLine("\n 0.Avsluta.\n1. Ellips\n 2. Rektangel.");
            Console.WriteLine("===================================================");
        }

        private static double ReadDoubleGreaterThanZero(string prompt) //promten = ange bredd eller ange längd
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                try
                {
                    value = double.Parse(input);
                    if (value > 0)
                    {
                        return value;
                    }
                    else
                    {
                        Console.WriteLine("Du måste ange ett tal högre än 0.");
                    }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL FEL FEL! {0} är inte i önskat format, du måste ange ett tal större än noll.", input);
                    Console.ResetColor();
                }
                
            } 
            
        }
    
        private static void ViewShapeDetail(/*sicka ner objektet som skapas för klassen*/)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("===================================================");
            Console.WriteLine("=                    Detaljer                     =");
            Console.WriteLine("===================================================");
            Console.ResetColor();
            Console.WriteLine(/*Här ska ToString metoden i Shape kallsen användas för att presentera alla vrden*/);
            Console.WriteLine();
            Console.WriteLine("===================================================");
        }
    
    
    
    }

}
