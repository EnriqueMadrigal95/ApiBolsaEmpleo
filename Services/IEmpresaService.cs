using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public  interface IEmpresaService
    {
        public Task<List<Experiencia>> GetAll();
        public Task<Experiencia> GetById(int id);
        public Task<Experiencia> Create(Experiencia experiencia);
        public Task Update(Experiencia experiencia);    
        public Task Delete(int id);
    }
}
