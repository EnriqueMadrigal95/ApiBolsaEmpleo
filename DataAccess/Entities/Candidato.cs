using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Candidato : Persona
    {
        public int IdCandidato { get; set; }
        public int Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string  Direccion { get; set; }
        public string Descripcion { get; set; }

        //Relación
        public List<FormacionAcademica> Formaciones { get; set; }

        public List<Experiencia> Experiencias { get; set; }

        public List<Habilidad> Habilidades { get; set; }


    }
}
