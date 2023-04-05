namespace TrianguloOOP.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.x = 5; triangulo.y = 5; triangulo.z = 5;
            Console.WriteLine(triangulo.VerificarTipoTriangulo());
        }
    }
}