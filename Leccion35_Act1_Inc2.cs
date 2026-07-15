internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Kevin Morataya\n Grado: IVC \n Clave:24\n *****CALCULADORA DE CAMBIO****");
        int pago;
        string producto;
        Console.WriteLine("Digite el nombre del producto: ");
        producto = Console.ReadLine();
        Console.Write("Dame el precio del producto");
        int precio=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite el valor del billete");
        pago=Convert.ToInt32(Console.ReadLine());
        int cambio = pago - precio;
        Console.WriteLine("Su cambio es: "+cambio);

    }
}