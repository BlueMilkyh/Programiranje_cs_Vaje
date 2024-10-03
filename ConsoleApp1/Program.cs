using System.Collections;
using System.Runtime.InteropServices;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Vnesite mesec: ");

        int mesec = int.Parse(Console.ReadLine());
        int t = Naloga123(mesec);
        System.Console.WriteLine($"Število dni v mesecu je {t}");

    }

    public static int Naloga123(int mesec)

    {
        switch (mesec)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                return 31;
            case 2:
                return 28;
            case 4:
            case 6:
            case 9:
            case 11:
                return 30;
            default: return 0;
        }
    }

    public static void Naloga131()
    {

        while (true)
        {
            DateTime date = DateTime.Now;
            if (date.Hour * date.Minute * date.Second % 17 != 0)
            {
                Console.WriteLine(date.ToString("dd/MM/yyyy HH:mm:ss"));
                break;
            }
        }
    }

}
