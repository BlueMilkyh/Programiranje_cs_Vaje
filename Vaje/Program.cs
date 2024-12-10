namespace Vaje
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vpisi Nalogo");
            int test = int.Parse(Console.ReadLine());

            switch (test)
            {
                case 121:
                IfStavki.Naloga121(5, "if");
                    break;
            }
                
            
        }
    }
}
