using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasApp.Models
{
    public interface IProveedorRepository
    {
        void Add(ProveedorModel proveedorModel);
        void Edit(ProveedorModel proveedorModel);
        void Delete(int id);
        IEnumerable<ProveedorModel> GetAll();
        IEnumerable<ProveedorModel> GetByValue(string value);
    }
}
