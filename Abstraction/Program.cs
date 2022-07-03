using Abstraction.Entities;
using Abstraction.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista que serão adicionados os Tax Payers.
            List<Contributors> listContributors = new List<Contributors>();
            //Armazena quantos Tax Payers serão adicionados à lista.
            int numberTaxPayers;
            //Armazena valor total das taxas
            double totalTaxes = 0;

            Console.Write("Enter the number of tax payers: ");
            numberTaxPayers = int.Parse(Console.ReadLine());

            // quebrando 1 linha.
            Console.WriteLine();

            //Adicionando os Tax Payers à lista
            for (int count = 1; count <= numberTaxPayers; count++)
            {
                //variaveis que irão armazenar os dados para atribuição do construtor.
                string name;
                double anualIncome;
                double healthExpenditures;
                int numberEmployees;
                StatusContributors statusContributors;

                Console.WriteLine($"Tax payer #{count} data:");
                Console.Write("Individual or Company (i/c) ? ");
                statusContributors = Enum.Parse<StatusContributors>(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Anual Income: ");
                anualIncome = double.Parse(Console.ReadLine());

                //status i == 0 == Individual, então terá um atributo healthExpenditures para ser adicionado.
                if ((short)statusContributors == 0)
                {
                    Console.Write("Health expenditures: ");
                    healthExpenditures = double.Parse(Console.ReadLine());

                    //Adicionando construtor da classe Individual a lista
                    listContributors.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                //status c == 1 == Company, então terá um atributo numberEmployees para ser adicionado.
                else if ((short)statusContributors == 1)
                {
                    Console.Write("Number of Employees: ");
                    numberEmployees = int.Parse(Console.ReadLine());

                    //Adicionando construtor da classe Company a lista
                    listContributors.Add(new Company(name, anualIncome, numberEmployees));
                }

                // quebrando 1 linha no final de cada loop
                Console.WriteLine();
            }

            Console.WriteLine("TAXES PAID: ");
            //Exibindo cada contribuidor com o valor de seu imposto
            foreach (Contributors contributor in listContributors)
            {
                Console.WriteLine(contributor);
                totalTaxes += contributor.Tax();
            }

            Console.WriteLine();
            //Retornando a soma de todas as taxas pagas
            Console.WriteLine($"TOTAL TAXES: {totalTaxes.ToString("F2")}");
        }
    }
}