using System.Linq;
using System;
using System.Text;

namespace TP1.Entidades
{
    public class Operando
    {
        #region Campos

        private double numero;

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Constructor parametrizado 
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero) : this ()
        {
            this.numero = numero;
        }
        /// <summary>
        /// Constructor parametrisado recibe string
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero) 
        {
            this.Numero = strNumero;
        }


        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad set valida que sea un numero valido
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Valida que el operando sea un numero
        /// </summary>
        /// <param name="strNumero">String a validar</param>
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {
            double numero;

            if (double.TryParse(strNumero, out numero))
                return numero;
            else
                return 0;
        }
        /// <summary>
        /// Valida que sea un numero binario
        /// </summary>
        /// <param name="binario">String a validar</param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            foreach (char item in binario)
            {
                if (item != '0' & item != '1')
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Transforma un numero binario a decimal
        /// </summary>
        /// <param name="binario">Numero binario a transformar</param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            int aux = 0;
            int i;
            int banderaNegativo = 0;

            if (binario.StartsWith("-"))
            {
                binario = binario.Substring(1);
                banderaNegativo = 1;
            }
            
            i = binario.Length - 1;
            


            if (this.EsBinario(binario))
            {
                foreach (char item in binario)
                {
                    if (item == '1')
                        aux += (int)Math.Pow(2, i);
                    i--;
                }
                if (banderaNegativo == 1)
                    aux *= -1;
                return aux.ToString();
            }
            else
                return "Valor no valido";

        }
        /// <summary>
        /// Transforma un numero decimal a binario
        /// </summary>
        /// <param name="numero">Numero decimal a transformar</param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            if (numero != 0)
            {
                if (numero > int.MaxValue || numero < int.MinValue)
                    return "Valor Invalido";
                StringBuilder binario = new StringBuilder();
                {
                    int numeroDivisible = (int)numero;
                    do
                    {
                        if (numeroDivisible % 2 == 0)
                            binario.Append("0");
                        else
                            binario.Append("1");

                        numeroDivisible /= 2;
                    } while (numeroDivisible != 1 && numeroDivisible != -1);

                    binario.Append("1");
                    if (numero < 0)
                        binario.Append("-");



                    char[] binarioCharArray = binario.ToString().ToCharArray();
                    Array.Reverse(binarioCharArray);


                    return new string(binarioCharArray);
                }
            }
            else
                return "0";
        }
        /// <summary>
        /// Transforma un numero decimal a binario
        /// </summary>
        /// <param name="numero">Numero decimal a transformar</param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {

            double numeroDouble;

            if (double.TryParse(numero, out numeroDouble))
                return this.DecimalBinario(numeroDouble);
            else
                return "Valor Invalido";
        }


        #endregion

        #region Operators
        /// <summary>
        /// Sobrecarga operador + suma dos numeros de tipo operando
        /// </summary>
        /// <param name="o1"></param>
        /// <param name="o2"></param>
        /// <returns></returns>
        public static double operator +(Operando o1, Operando o2)
        {
            return o1.numero + o2.numero;
        }
        /// <summary>
        /// Sobrecarga operador - resta dos numeros de tipo operando
        /// </summary>
        /// <param name="o1"></param>
        /// <param name="o2"></param>
        /// <returns></returns>
        public static double operator -(Operando o1, Operando o2)
        {
            return o1.numero - o2.numero;
        }
        /// <summary>
        /// Sobrecarga del operador * multiplicacion dos numeros del tipo operando
        /// </summary>
        /// <param name="o1"></param>
        /// <param name="o2"></param>
        /// <returns></returns>
        public static double operator *(Operando o1, Operando o2)
        {
            return o1.numero * o2.numero;
        }
        /// <summary>
        /// Sobrecarga del operador / divide dos numeros del tipo operando
        /// </summary>
        /// <param name="o1"></param>
        /// <param name="o2"></param>
        /// <returns></returns>
        public static double operator /(Operando o1, Operando o2)
        {
            if (o2.numero == 0)
                return double.MinValue;
            else
                return o1.numero / o2.numero;
        }
        #endregion

    }
}
