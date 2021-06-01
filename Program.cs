using System;

namespace dev_homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! - My name is: Francisco");

            //Constantes
            const string nombre = "Francisco";
            //Variables
            int edad = 32;
        
            Console.WriteLine($"Mi nombre es: {nombre} y mi edad es { edad } años.");

            float miDomingo = 150.5F;

            Console.WriteLine($"Mi domingo es de {miDomingo}");
        
            var resultado = miDomingo * 46;

            Console.WriteLine($"Resultado: { resultado }");


            var areaTriangulo = 0F;

            float basee = 315.0723F;
            float altura = 11238.0234F;
            const float dos = 2.0F;
            areaTriangulo = basee * altura / dos;
        
            Console.WriteLine ($"Area de un triangulo es igual a la base: ({basee}) por la altura ({altura}) entre dos");
            Console.WriteLine ($"Resutlado Area: {areaTriangulo} ");

            char letraA = 'a';
            float  floatF = 1F/3;
            double doubleD = 1D/3;
            decimal decimalD = 1M/3;

            Console.WriteLine ($"flotante: {floatF}");
            Console.WriteLine ($"doubleD: {doubleD}");
            Console.WriteLine ($"decimalD: {decimalD}");

            bool falso = false;
            bool verdadero = true;
            


        }
    }
}
