using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public  interface IOfertaLaboralService
    {
        public Task<List<OfertaLaboral>> GetAll();

        public Task<OfertaLaboral> GetById(int id);
        public Task<OfertaLaboral> Create(OfertaLaboral oferta_Laboral);

        public Task Update(OfertaLaboral oferta_Laboral);

        public Task Delete(int id);
    }
}
