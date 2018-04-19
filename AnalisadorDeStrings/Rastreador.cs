using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorDeStrings
{
    class Rastreador
    {
       public string modelo { get; set; }
       public string[] report { get; set; }
       public string[] separador { get; set; }


    public Rastreador(string modelo, string[] separador,string[] report)
        {
            this.modelo = modelo;
            this.separador = separador;
            this.report = report;
        }


        //string[] report = str.Split();


        public override string ToString()
        {
            return modelo + separador;
        }






    }
}
