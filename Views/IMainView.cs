using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasApp.Views
{
    public interface IMainView
    {
        event EventHandler ShowClienteView;
        event EventHandler ShowEmpleadoView;
        event EventHandler ShowProveedorView;
    }
}
