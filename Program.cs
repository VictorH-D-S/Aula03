using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            float coxinha = 4.99f;
            float acrescimo_capitury = 0.50f;
            float coxinha_catupiry = coxinha + acrescimo_capitury;
                
            Console.WriteLine($"A coxinha custa R$ {coxinha}");
            Console.WriteLine($"Acréscimo de CAPUTURY: R$ {acrescimo_capitury}");
            Console.WriteLine($"A COXINHA COM CAPITURY EXTRA CUSTA: {coxinha_catupiry}\n \n \n \n \n");

            //CALCULADORA DE IMC
            float peso = 71.0f;
            float altura = 1.85f;
            float imc = peso / (altura * altura);

            Console.WriteLine($"SEU ÍNDICE DE MASSA CORPORAL = {imc}");



            Console.ReadKey();
        }
    }
}
