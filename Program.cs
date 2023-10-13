// See https://aka.ms/new-console-template for more information
using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            
            Matematica m = new Matematica(10,20);
            m.Somar();
            
            
            // Operacao op = new Operacao(Calculadora.Somar);

            // op += Calculadora.Subtrair;


            // op.Invoke(10,10);
           



           
            // const double pi = 3.14;

            // System.Console.WriteLine(pi);

        
            // Data data = new Data();
            // // data.SetMes(2);

            // data.Mes = 20;

            // System.Console.WriteLine(data.Mes);

    
            // data.ApresentarMes();
        

            // Aluno p1 = new Aluno ("Bruna","Yamasaki");   
            // p1.Apresentar();
        }
    }
}

