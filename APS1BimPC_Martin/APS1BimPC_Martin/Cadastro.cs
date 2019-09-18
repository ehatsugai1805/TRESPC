using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace APS1BimPC_Martin
{
    class Cadastro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }


        public override string ToString()
        {
            return "ID: " + Id + " |  Nome: " + Nome + " | Cidade: " + Cidade;

        }
    }
}
