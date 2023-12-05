using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasApp.Views
{
    public interface IProveedorView
    {
        string IdProveedor { get; set; }
        string NombreProveedor { get; set; }
        string ApellidoProveedor { get; set; }
        string EmailProveedor { get; set; }
        string FechaNacProveedor { get; set; }
        string TelefonoProveedor { get; set; }
        string DireccionProveedor { get; set; }
        string LongitudProveedor { get; set; }
        string LatitudProveedor { get; set; }

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
        void SetProveedoresListBindingSource(BindingSource proveedoresList);
        void ShowMap(string latitud, string longitud);
        void Show();

    }
}
