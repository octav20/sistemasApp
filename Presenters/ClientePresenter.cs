using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasApp.Views;
using sistemasApp.Models;
namespace sistemasApp.Presenters
{
    public class ClientePresenter
    {

        //fields
        private IClienteView view;
        private IClienteRepository repository;
        private BindingSource clientesBindingSource;
        private IEnumerable<ClienteModel> clientesList;

        //constructor
        public ClientePresenter(IClienteView view, IClienteRepository repository)
        {
            this.clientesBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //suscribe event handler methods to view events
            this.view.SearchEvent += SearchCliente;
            this.view.AddNewEvent += AddNewCliente;
            this.view.EditEvent += LoadSelectedClienteToEdit;
            this.view.DeleteEvent += DeleteSelectedCliente;
            this.view.SaveEvent += SaveCliente;
            this.view.CancelEvent += CancelAction;

            //Set clientes bindingSource
            this.view.SetClientesListBindingSource(clientesBindingSource);
            //load clientes list view
            LoadAllClientesList();
            //Show view
            this.view.Show();
        }

        private void LoadAllClientesList()
        {
            clientesList = repository.GetAll();
            clientesBindingSource.DataSource = clientesList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SaveCliente(object? sender, EventArgs e)
        {
            var model = new ClienteModel();
            model.Id = Convert.ToInt32(view.IdCliente);
            model.Nombre = view.NombreCLiente;
            model.Apellido = view.ApellidoCLiente;
            model.Email = view.EmailCliente;
            model.Telefono = view.TelefonoCliente;
            model.Direccion = view.DireccionCliente;
            model.Latitud = view.LatitudCliente;
            model.Longitud = view.LongitudCliente;

            try
            {
                new Common.ModelDatValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Client edited succesfuly";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Client added sucessfully";
                }
                view.IsSuccesful = true;
                LoadAllClientesList();
                CleanviewFields();
            }
            catch(Exception ex) 
            {
                view.IsSuccesful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.IdCliente = "0";
            view.NombreCLiente = "";
            view.ApellidoCLiente = "";
            view.EmailCliente = "";
            view.TelefonoCliente = "";
            view.DireccionCliente = "";
            view.LatitudCliente = "";
            view.LongitudCliente = "";
        }

        private void DeleteSelectedCliente(object? sender, EventArgs e)
        {
            try
            {
                var cliente = (ClienteModel)clientesBindingSource.Current;
                repository.Delete(cliente.Id);
                view.IsSuccesful = true;
                view.Message = "Client delete successfully";
                LoadAllClientesList();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = "An error ocurred, could not delete yet";
            }
        }

        private void LoadSelectedClienteToEdit(object? sender, EventArgs e)
        {
            var cliente = (ClienteModel)clientesBindingSource.Current;
            view.IdCliente = cliente.Id.ToString();
            view.NombreCLiente = cliente.Nombre;
            view.ApellidoCLiente = cliente.Apellido;
            view.EmailCliente = cliente.Email;
            view.TelefonoCliente = cliente.Telefono;
            view.DireccionCliente = cliente.Direccion;
            view.LatitudCliente = cliente.Latitud;
            view.LongitudCliente = cliente.Longitud;
            view.ShowMap(cliente.Latitud, cliente.Longitud);
            view.IsEdit = true;


        }

        private void AddNewCliente(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCliente(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue== false) 
            
                clientesList = repository.GetByValue(this.view.SearchValue);
            else clientesList = repository.GetAll();
            clientesBindingSource.DataSource = clientesList;
            
        }
    }
}
