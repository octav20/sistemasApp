using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace sistemasApp.Views
{
    public interface IClienteView
    {
        string IdCliente {  get; set; }
        string NombreCLiente {  get; set; }
        string ApellidoCLiente { get;set; }
        string EmailCliente {  get; set; }
        string FechaNacCliente {  get; set; }
        string TelefonoCliente { get; set; }
        string DireccionCliente { get; set; }
        string LongitudCliente { get; set; }
        string LatitudCliente { get; set; }

        string SearchValue { get; set; }
        bool IsEdit {  get; set; }
        bool IsSuccesful {  get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetClientesListBindingSource(BindingSource clientesList);
        void ShowMap(string latitud, string longitud);
        void Show();

    }
}
