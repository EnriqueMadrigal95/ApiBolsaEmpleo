using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataAccess.Entities
{
    public class OfertaLaboral
    {
        public int Id { get; set; }
        public string? ExperienciaNecesaria { get; set; }
        public string? Descripcion_puesto { get; set; }
        public string? Responsabilidades { get; set; }

        //Relacion 
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}
