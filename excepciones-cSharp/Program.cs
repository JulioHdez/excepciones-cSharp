using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Variables auxiliares
            //int num1, num2;

            ////Captura de variables
            //Console.Write("Ingresa un numero: ");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Ingresa otro numero: ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            ////Impresion
            //Console.WriteLine("El resultado es: {0}" , num1/num2);
            //Console.ReadLine();

            try
            {
                //Variables auxiliares
                int num1, num2;

                //Captura de variables
                Console.Write("Ingresa un numero: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa otro numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                //Impresion
                Console.WriteLine("El resultado es: {0}", num1 / num2);
                Console.ReadLine();
            }
            //Error para cuando se ingresa una letra 
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            //Error para cuando se divide entre 0
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            //Finally
            finally{

            }
        }
    }
}
