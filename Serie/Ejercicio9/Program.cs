/*
Prueba de las clases Circulo y TrepacioCircular ademas de la investigacion de los metodos de Math.
Los metodos usados fueron Round, truncate y pow.
*/

using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c1 = new Circulo(5);
            Console.WriteLine("El area del circulo de radio {0} es: {1}",c1.radInfo,c1.area());
            TrapecioCircular tc1 = new TrapecioCircular(5,3,60);
            Console.WriteLine("El area del trapecio circula de radio mayor {0}, radio menor {1} y angulo {2} es: {3}",tc1.radMaydInfo,tc1.radmenInfo,tc1.ang,tc1.area());
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}

/* Metodos de Math
 * 
 * Abs(num)                             Regresa el valor absoluto de un numero del tipo: Decimal, Double, Int16, Int32, Int64, SByte y Single
 * Acos (num)                           Regresa el angulo cuyo coseno es el numero especificado del tipo double.
 * Asin (num)                           Regresa el angulo cuyo seno es el numero especificado del tipo double.
 * Atan (num)                           Regresa el angulo cuya tangente es el numero especificado del tipo double.
 * Atan2 (num)                          Regresa el angula cuya tangente es elcociente de los dos numeros especificados del tipo double.
 * BigMul (num, num)                    Realiza el producto completo de dos numeros del tipo 32Int.
 * Ceiling (num)                        Devuelve el valor integral más pequeño que es mayor o igual que el número especificado del tipo decimal o double.
 * Cos (num)                            Devuelve el coseno del angulo especificadon del tipo double.
 * Cosh (num)                           Devuelve el coseno hiperbolide del angulo especificado en double:
 * DivRem (num, num, num)               Calcula el cociente de dos numeros del tipo Int32 o Int64 y lo regresa el resto en un tercer parametro de salida del mismo tipo que los otros 2.
 * Exp (num)                            Regresa e elevado a la potencia especificada del tipo double.
 * Floor (num)                          Devuelve el mayor valor integral menor o igual que el número especificado del tipo decimal o double.
 * IEEERemainder(num, num)              Regresa el residuo resultante de la division de dos un numero espcifico entre otro numero especifico estos son del tipo double.
 * Log (num)                            Devuelve el logaritmo natural del numero especificado del tipo double.
 * Log (num , num)                      Regresa el logaritmo del numero especificado en la base especificada del tipo double.
 * log10 (num)                          Devuelve el logaritmo base 10 del numero especificado.
 * Max(num, num)                        Regresa el mayor de los dos numeros especificados, ambos numeros pueden ser del tipo Byte, Decimal, Double, Int16, Int32, Int64, SByte, Single, UInt16, UInt32 y UInt64.
 * Min (num, num)                       Regresa el menor de los dos numeros especificados, ambos numeros pueden ser del tipo Byte, Decimal, Double, Int16, Int32, Int64, SByte, Single, UInt16, UInt32 y UInt64.
 * Pow(Double, Double)                  Devuelve el numero especificado elevado a la potencia especificada estos son del tipo double.
 * Round(num)                           Redondea un valor decimal o double al valor integral más cercano y redondea los valores del punto medio al número par más cercano.
 * Round(num, Int32)                    Redondea un valor decimal o double a un número específico de dígitos fraccionarios y redondea los valores del punto medio al número par más cercano.
 * Round(num, Int32, MidpointRounding)  Redondea un valor decimal o double a un número específico de dígitos fraccionarios y utiliza la convención de redondeo especificada para valores de punto medio.
 * Round(num, MidpointRounding)         Redondea un valor decimal o double al entero más cercano y utiliza la convención de redondeo especificada para valores de punto medio.
 * Sign(num)                            Regresa un entero que indica el signo de un numero este numero puede ser Decimal, Double. Int16, Int32, Int64, Sbyte o single
 * Sin (num)                            Devuelve el seno del angulo especificado este es del tipo Double.
 * Sinh (num)                           Regresa el seno hiperboloide del angulo especificado este es del tipo Double..
 * sqrt(num)                            Regresa la raiz cuadrada del numero especificado este es del tipo Double..
 * Tan (num)                            Devuelve la tangente del anfulo especificado este es del tipo Double.
 * Tanh (num)                           Regresa la tangente hiperboloide del angulo especificado este es del tipo Double.
 * Truncate (num)                       Trunca un numero especificado este es del tipo decimal o Double.
 * 
 */
