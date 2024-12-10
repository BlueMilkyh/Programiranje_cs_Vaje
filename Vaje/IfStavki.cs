using System.Numerics;

namespace Vaje
{
    public class IfStavki
    {
        public enum Naloga
        {
            Naloga121 = 1,
        }

        public static void Naloga121(int dan,string verzija)
        {
            //Če poskusimo narediti z If Stavkom
            if(verzija == "if")
            {
                if (dan == 0)
                {
                    Console.WriteLine("Ponedeljek");
                }
                else if (dan == 1)
                {
                    Console.WriteLine("Torek");
                }
                else if (dan == 2)
                {
                    Console.WriteLine("Sreda");
                }
                else if (dan == 3)
                {
                    Console.WriteLine("Četrtek");
                }
                else if (dan == 4)
                {
                    Console.WriteLine("Petek");
                }
                else if (dan == 5)
                {
                    Console.WriteLine("Sobota");
                }
                else if (dan == 6)
                {
                    Console.WriteLine("Nedelja");
                }
                else
                {
                    Console.WriteLine("Napačen vnos datuma");
                }
            }
            //če poskusimo narediti z switch stavkom
            else if(verzija  == "switch")
            {
                switch (dan)
                {
                    case 0:
                        Console.WriteLine("Ponedeljek");
                        break;
                    case 1:
                        Console.WriteLine("Torek");
                        break;
                    case 2:
                        Console.WriteLine("Sreda");
                        break;
                    case 3:
                        Console.WriteLine("Četrtek");
                        break;
                    case 4:
                        Console.WriteLine("Petek");
                        break;
                    case 5:
                        Console.WriteLine("Sobota");
                        break;
                    case 6:
                        Console.WriteLine("Nedelja");
                        break;
                    default:
                        Console.WriteLine("Napačen vnos datuma");
                        break;
                }
            }
        }
    }
}
