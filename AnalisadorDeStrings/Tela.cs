using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorDeStrings
{
    class Tela
    {

        public static void menu() 
        {
            Console.Write("Digite o modelo do rastreador: ");
            string modeloRastreador = Console.ReadLine();
            if (modeloRastreador == "suntech")
            {
                string[] separador = { ";" };
                //Console.WriteLine("Digita a string a ser analisada: ");
                //string str = Console.ReadLine();
                string str ="ST300STT;100850000;01;010;20081017;07:41:56;00100;+37.478519;+126.886819;000.012;000.00;9;1;0;15.3 0;001100;1;0072;0;4.5;1";
                Program.report = str.Split(separador, StringSplitOptions.RemoveEmptyEntries);                
                Rastreador rast = new Rastreador(modeloRastreador, separador, Program.report);
                Console.WriteLine();
            }
        
        }







        public static void suntech()
        { 
            Console.WriteLine("Cabeçalho: " + Program.report[0]);
            Console.WriteLine("ID: " + Program.report[1]);
            Console.WriteLine("Modelo: " + Program.report[2]);
            Console.WriteLine("Versão: " + Program.report[3]);
            Console.WriteLine("Data: " + Program.report[4]);
            Console.WriteLine("Horario: " + Program.report[5]);
            Console.WriteLine("Cell: " + Program.report[6]);
            Console.WriteLine("Latituide: " + Program.report[7]);
            Console.WriteLine("Logitude: " + Program.report[8]);
            Console.WriteLine("Velocidade: " + Program.report[9]);
            Console.WriteLine("Curso: " + Program.report[10]);
            Console.WriteLine("Numero de satelites: " + Program.report[11]);
            Console.WriteLine("FIX: " + Program.report[12]);
            Console.WriteLine("Odometro: " + Program.report[13]);
            Console.WriteLine("Tensão Bateria principal: " + Program.report[14]);
            Console.WriteLine("I/O: " + Program.report[15]);
            Console.WriteLine("Mode: " + Program.report[16]);
            Console.WriteLine("Numero da mensagem: " + Program.report[17]);
            Console.WriteLine("Horimetro: " + Program.report[18]);
            Console.WriteLine("Bateria Backup: " + Program.report[19]);
            Console.WriteLine("Memoria: " + Program.report[20]);
        }





    }
}
