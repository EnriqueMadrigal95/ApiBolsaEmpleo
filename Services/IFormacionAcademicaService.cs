using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IFormacionAcademicaService
    {
        public Task<List<FormacionAcademica>> GetAll();

        public Task<FormacionAcademica> GetById(int id);
        public Task<FormacionAcademica> Create(FormacionAcademica formacion);

        public Task Update(FormacionAcademica formacion);

        public Task Delete(int id);
    }
}
