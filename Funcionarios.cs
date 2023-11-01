using System;
using System.Linq;
using System.Collections.Generic;

namespace Aumento_Salario
{

public class Funcionarios
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public double Salario { get; private set; }
    public double Aumento { get; set; }


    public Funcionarios(int id, string nome, double salario)
    {
        ID = id;
        Nome = nome;
        Salario = salario;

    }



    public void Idadd(double percent)
    {

        Salario += Salario * (percent / 100);

    }

    public override string ToString()
    {

        return "Funcionario: ID " + ID + " Nome: " + Nome + " R$: " + Salario;
    }

}
}