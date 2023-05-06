using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public  class Habilidad
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }

        //Relacion 

        public List<Candidato> Candidatos { get; set; }
    }
}
