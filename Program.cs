using System;

namespace exercicio_logica_programacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rejuste salarial:

            //Faça um algoritmo que calcule o reajuste de um salário. 
            //O usuário deverá informar o salário e o percentual de reajuste para a realização do cálculo.

            Console.WriteLine("Favor informar o salário que a ser ajustado (R$):");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Favor informar o percentual do reajuste (%):");
            double percReajuste = Convert.ToDouble(Console.ReadLine());
            if (percReajuste >0)
            {
                double salAjustado = salario * (1 + (percReajuste / 100));
                Console.WriteLine($"Valor do novo salário (R$):{salAjustado}");
            }
            else
                Console.WriteLine("Informação incorreta!");

        }
    }
}
