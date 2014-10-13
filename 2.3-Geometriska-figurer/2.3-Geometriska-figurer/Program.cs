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
                do // startar upp Viewmenu sen gör en switch sats för att gå vidare.
                {
                    Console.Clear();

                    ViewMenu();
                    int ChoiceValue;
                    string choice = Console.ReadLine();
                    try
                    {
                        ChoiceValue = int.Parse(choice);

                        switch (ChoiceValue)
                        {
                            case 0: return;

                            case 1: ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                                break;
                            case 2: ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                                break;
                            default:
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("FEL! Du måste ange ett nummer emellan 0 och 2.");
                                Console.ResetColor();
                                break;
                        }
                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Du måste ange ett heltal!");
                        Console.ResetColor();
                    } 


                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Tryck valfri tangent för att börja om - ESC avslutar.");
                    Console.ResetColor();

                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            }
        private static Shape CreateShape(ShapeType shapeType) // skapar ett objekt, samt skriver ut ellips / rektangel raden. ska kalla på ReadDoubleGreaterThanZero för att läsa in värden
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("===================================================");
            switch (shapeType)
            {
                case ShapeType.Ellipse: Console.WriteLine("=                    Ellips                       =");
                                        break;

                case ShapeType.Rectangle: Console.WriteLine("=                 Rectangel                       =");
                                          break;
            }
            Console.WriteLine("===================================================");
            Console.ResetColor();
            Console.WriteLine();


            double width = ReadDoubleGreaterThanZero("Ange bredd:");
            double lenght = ReadDoubleGreaterThanZero("Ange längd:");

            if ( shapeType == ShapeType.Ellipse )
            {
                Ellipse myEllipse = new Ellipse(lenght, width);
                return myEllipse;
            }
            Rectangle myRectangle = new Rectangle(lenght, width);
            return myRectangle;

        }

        private static void ViewMenu() // Visar upp en meny
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("===================================================");
            Console.WriteLine("=                                                 =");
            Console.WriteLine("=                Geometriska figurer              =");
            Console.WriteLine("=                                                 =");
            Console.WriteLine("===================================================");
            Console.ResetColor();
            Console.WriteLine("\n 0.Avsluta.\n\n 1. Ellips\n\n 2. Rektangel.");
            Console.WriteLine("===================================================");
        }

        private static double ReadDoubleGreaterThanZero(string prompt) //läser in tal

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
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Du måste ange ett tal högre än 0.");
                        Console.ResetColor();
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
    
        private static void ViewShapeDetail(Shape shape) // ska visa upp alla detaljet om formen
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("===================================================");
            Console.WriteLine("=                    Detaljer                     =");
            Console.WriteLine("===================================================");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());
            Console.WriteLine();
            Console.WriteLine("===================================================");
        }   
    }
}
