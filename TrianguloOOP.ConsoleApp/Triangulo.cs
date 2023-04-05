using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloOOP.ConsoleApp
{
    internal class Triangulo
    {
        public double x;
        public double y;
        public double z;
        public string tipoTriangulo =" ";

        public string VerificarTipoTriangulo()
        {
            if (x < y + z && y < x + z && z < x + y)
            {
                if (x == y && x == z && y == x && y == z && z == x && z == y)
                {
                     bool equilatero = true;
                     return tipoTriangulo = "equilatero";
                }
                else if (x == y && x != z || x == z && x != y || y == x && y != z || y == z && y != x
                         || z == x && z != y || z == y && z != x)
                {
                     bool isosceles = true;
                     return tipoTriangulo = "isosceles";
                } 
                bool escaleno = true;
               return tipoTriangulo = "escaleno";
                
            }
           
            bool triangulo = false;
            return tipoTriangulo = "Não é um triangulo";
        }


    }
}
