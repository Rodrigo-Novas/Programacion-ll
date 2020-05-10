using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        //constructores

        private Numero()
        {
            numero = 0;

        }

        public Numero(double numero) : this() //sobrecarga de constructores
        {
            this.numero = numero;
        }


        public Numero(string strNumero) : this()
        {
            double.TryParse(strNumero, out this.numero);

        }


        //Sobrecarga de operadores
        public static Double operator +(Numero a, Numero b)
        {
            return a.numero + b.numero;
        }

        public static Double operator *(Numero a, Numero b)
        {
            return a.numero * b.numero;
        }

        public static Double operator /(Numero a, Numero b)
        {

            if (b.numero != 0)
            {
                return a.numero / b.numero;
            }

            return double.MinValue;
        }

        public static Double operator -(Numero a, Numero b)
        {
            return a.numero - b.numero;
        }

        //Propiedades. 
        public string setNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        //
        //Metodos
        //


        /// <summary>
        /// Valida numero en cadena de texto
        /// </summary>
        /// <param name="strNumero"></param>String a validar
        /// <returns></returns>Numero binario convertido en Double

        private double ValidarNumero(string strNumero)
        {

            if (Regex.IsMatch(strNumero, @"^\d+$")) //regular expression si es numero
            {
                double.TryParse(strNumero, out this.numero);

                return this.numero;
            }

            return 0;



        }
        /// <summary>
        /// Convierte un numero binario en decimal
        /// </summary>
        /// <param name="binario"></param>String a ser convertido
        /// <returns></returns>Numero binario convertido en Double
        public static string BinarioDecimal(string binario)
        {
            double numero = 0;
            string retorno;
            int j = binario.Length - 1;
            if (binario == "Valor incorrecto")
            {
                retorno = "Valor incorrecto";
            }
            else { 
            for (int i = 0; i < binario.Length; i++)
            {
                numero += double.Parse(binario[j].ToString()) * Math.Pow(2, i);
                j--;
            }
            retorno = "" + numero;
            }
            

            return retorno;
        }

        /// <summary>
        /// Convierte un numero decimal en binario
        /// </summary>
        /// <param name="numero"></param>Numero a ser convertido
        /// <returns></returns>Numero convertido en binario en formato String
        public static string DecimalBinario(long numero)
        {
            string binario = Convert.ToString(numero, 2);

            if (binario == "0")
            {
                binario = "Valor incorrecto";
            }

            return binario;
        }


        /// <summary>
        /// Convierte un numero decimal en binario
        /// </summary>
        /// <param name="numero"></param>Numero a ser convertido en formato String
        /// <returns></returns>Numero convertido en binario en formato String
        public static string DecimalBinario(string numero)
        {
            string binario;
            long num;

           

            if (numero.Contains("-"))
             {
                numero = "0";
            }
           
            long.TryParse(numero, out num);

            binario = DecimalBinario(num);
            

            return binario;
        }






    }
}