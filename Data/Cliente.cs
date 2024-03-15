using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    
    public class Cliente
    {
        //get = armazezar e set = modifica
        public int CodigoCliente {  get; set; }
        // get = armazenar nome e set modifica  
        public string Nome { get; set; }

        public string Profissao { get; set; }

        public string Setor { get; set;}

        public string Obs { get; set; }



    }
}
