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
            Console.WriteLine ($"Letara: { letraA}");

            float  floatF = 1F/3;
            double doubleD = 1D/3;
            decimal decimalD = 1M/3;

            Console.WriteLine ($"flotante: {floatF}");
            Console.WriteLine ($"doubleD: {doubleD}");
            Console.WriteLine ($"decimalD: {decimalD}");

            bool falso = false;
            bool verdadero = true;
            Console.WriteLine ($"Falso { falso }  Verdadero { verdadero}");
            // Tarea
            /* ESTA ES MI TAREA 
              1) área de un triángulo, circulo, cuadrado.
              2) Si mi sueldo es de $100,000, ¿cuanto es el 10%?
              3) Si de domingo me dan 15 pesos ¿cuanto dinero junte en 3 años?  
              4) Si de domingo me dan 15 pesos y cada año me aumentan 20% ¿cuanto dinero junte en 5 años?;
              5) Investigar el problema de los conejos de Fibonacci (programar la respuesta.)            
            */

            Console.WriteLine("\n"); //Salto de linea
            Console.WriteLine("**************************************");
            Console.WriteLine("TAREA - Ejercicio 01");
            Console.WriteLine("Área de un Triángulo");

            var x = 10;
            var y = 20;
            
            Console.WriteLine($"Base: { x }");
            Console.WriteLine($"Altura: { y }");
            Console.WriteLine($"área es igual: { (x*y)/2 }");
            Console.WriteLine("**************************************");
            Console.WriteLine("\n");


        }
    }
}
