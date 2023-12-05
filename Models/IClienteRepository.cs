using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasApp.Models
{
    public interface IClienteRepository
    {
        void Add(ClienteModel clienteModel);
        void Edit(ClienteModel clienteModel);
        void Delete(int id);
        IEnumerable<ClienteModel> GetAll();
        IEnumerable<ClienteModel> GetByValue(string value);

    }
}
