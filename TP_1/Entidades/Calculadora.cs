using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entidades
{
    public static class  Calculadora
    {
        /// <summary>
        /// Realiza la operacion segun el operador recibido por parametro
        /// </summary>
        /// <param name="o1">Primer operando</param>
        /// <param name="o2">Segundo operando</param>
        /// <param name="operador">operador</param>
        /// <returns></returns>
        public static double Operar(Operando o1, Operando o2, char operador)
        {

            char operadorValidado = ValidarOperador(operador);

            switch(operadorValidado)
            {                   
                case '-':
                    return o1 - o2;                    
                case '/':
                    return o1 / o2;
                case '*':
                    return o1 * o2;
                default:
                    return o1 + o2;
            }
        }
        /// <summary>
        /// Valida que el operador sea valido
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns></returns>
        private static char ValidarOperador(char operador)
        {
            char[] operadores = { '+', '-', '/', '*' };

            if (operadores.Contains(operador))
                return operador;
            else
                return '+';
        }
    }
}
