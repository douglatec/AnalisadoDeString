using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnalisadorDeStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] report;

            Console.WriteLine("Digite o modelo do rastreador: ");
            string modeloRastreador = Console.ReadLine();
            if (modeloRastreador == "suntech")
            {
                string[] separador = { ";" };
                Console.WriteLine("Digita a string a ser analisada: ");
                string str = Console.ReadLine();
                report = str.Split(separador, StringSplitOptions.RemoveEmptyEntries);
                Rastreador rast = new Rastreador(modeloRastreador, separador, report);
            }

            Tela.suntech();

            Console.ReadLine();

        }
    }
}
