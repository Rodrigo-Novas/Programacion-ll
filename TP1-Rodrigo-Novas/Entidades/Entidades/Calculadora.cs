
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Clase estática Calculadora:
 El método ValidarOperador será privado y estático.Deberá validar que el operador
recibido sea +, -, / o*. Caso contrario retornará +.
 El método Operar será de clase: validará y realizará la operación pedida entre
ambos números.*/




namespace Entidades
{
    public static class Calculadora
    {

        /// <summary>
        /// Valida operando
        /// </summary>
        /// <param name="operando"></param> operando en formato string
        /// <returns></returns> retorna operando en caso de que no se encuentra retorna +
        private static string ValidarOperando(string operando)
        {
            if (operando != "+" && operando != "-" && operando != "/" && operando != "*")
            {

                operando = "+";

            }

            return operando;
        }

        /// <summary>
        /// Realiza la operacion pedida
        /// </summary>
        /// <param name="num1"></param> Primer numero
        /// <param name="num2"></param> Segundo numero
        /// <param name="Operador"></param> Operando
        /// <returns></returns> Retorna valor de la operacion pedida
        public static double Operar(Numero num1, Numero num2, string Operador)
        {
            

            Operador = ValidarOperando(Operador);

            if (Operador == "+")
            {
                return num1 + num2;
            }
            else if (Operador == "-")
            {
                return num1 - num2;
            }
            else if (Operador == "*")
            {
                return num1 * num2;
            }
            else if (Operador == "/")
            {
                return num1 / num2;
            }

            return 0;

        }

    }
}
