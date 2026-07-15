using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Kevin Morataya\n Grado: IVC \n Clave:24\n *****CONVERSIONES****");
        double metros;
        double resultado;
        Console.WriteLine("Dame una medida de metros");
        metros= double.Parse(Console.ReadLine());

        Console.WriteLine("Menu Principal");
        Console.WriteLine("1--Milimetros\n" + "2--Centimetros\n" + "3--Decimetros\n" + "4--Hectometros\n" + "5--Kilometros\n"
            + "6--SALIR\n" + "Seleccione una opcion[]:");
        int opc=Convert.ToInt32(Console.ReadLine());

        switch (opc)
        { 
            case 1:
                Console.Clear();
                Console.WriteLine("CONVERSION A MILIMETROS");
                resultado = metros * 1000;
                Console.WriteLine("Los metros "+metros+" en milimetros es: "+resultado);
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("CONVERSION A CENTIMETROS");
                resultado= metros * 100;   
                Console.WriteLine("Los metros " + metros + " en centimetros es: " + resultado);
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("CONVERSION A DECIMETROS");
                resultado = metros * 10;
                Console.WriteLine("Los metros " + metros + " en decimetros es: " + resultado);
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("CONVERSION A HECTOMETROS");
                resultado = metros / 100;
                Console.WriteLine("Los metros " + metros + " en hectometros es: " + resultado);
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("CONVERSION A KILOMETROS");
                resultado = metros / 1000;
                Console.WriteLine("Los metros " + metros + " en Kilometros es: " + resultado);
                break;
            case 6:
                Console.Clear();
                Console.WriteLine("PARA SALIR ´RESIONE UNA TECLA");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Digite un numero valido");
                break ;
        }       

    }
}