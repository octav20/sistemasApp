using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasApp.Models
{
    public interface IEmpleadoRepository
    {
        void Add(EmpleadoModel empleadoModel);
        void Edit(EmpleadoModel empleadoModel);
        void Delete(int id);
        IEnumerable<EmpleadoModel> GetAll();
        IEnumerable<EmpleadoModel> GetByValue(string value);
    }
}
