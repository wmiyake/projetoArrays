using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome;
            nome = new string[4];
            nome[0] = "João";
            nome[1] = "Carlos";
            nome[2] = "Eduardo";
            nome[3] = "Vinicius";

            for (int i = 0; i < 4; i++) {

                Console.Write(nome[i]);
                Console.Write(" ");

            }

            Console.ReadKey();
        }
    }
}
