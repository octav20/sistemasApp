using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasApp.Views
{
    public interface IEmpleadoView
    {
        string IdEmpleado { get; set; }
        string NombreEmpleado { get; set; }
        string ApellidoEmpleado { get; set; }
        string EmailEmpleado { get; set; }
        string FechaNacEmpleado { get; set; }
        string TelefonoEmpleado { get; set; }
        string DireccionEmpleado { get; set; }
        string LongitudEmpleado { get; set; }
        string LatitudEmpleado { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccesful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetEmpleadosListBindingSource(BindingSource EmpleadosList);
        void ShowMap(string latitud, string longitud);
        void Show();
    }
}
