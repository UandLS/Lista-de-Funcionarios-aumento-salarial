using System;
using System.Linq;
using Aumento_Salario;
using System.Collections.Generic;
using System.Globalization;


namespace Aumento_Salario
{

    public static class Program
    {
        public static void Main()
        {

            Console.Write("Quantos fucionarios para registrar ");
            int nfunc = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Funcionarios> ids = new List<Funcionarios>();

            for (int i = 0; i < nfunc; i++)
            {

                Console.WriteLine("Digite a ID do funcionario");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine();


                Console.WriteLine("Nome do funcionario");
                string nome = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Salario do funcionario");
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine();

                ids.Add(new Funcionarios(id, nome, salario));

                foreach (Funcionarios objt in ids)
                {
                    Console.WriteLine(objt);
                }
            }

                Console.WriteLine();
                Console.WriteLine("Digite a Id do funcionario que receberá aumento");
                int Idadd = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Funcionarios Aum = ids.Find(x => x.ID == Idadd);

                if (Aum != null)
                {

                    Console.Write("entre com a porcentagem: ");
                    double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Aum.Idadd(percent);
                }
                else
                {
                    Console.WriteLine("Id Invalido");
                }

                Console.WriteLine();
                Console.WriteLine("Salario atualizado: ");
                foreach (Funcionarios objt in ids)
                {
                    Console.WriteLine(objt);
                }




            
        }
    }
}