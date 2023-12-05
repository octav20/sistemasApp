using sistemasApp.Models;
using sistemasApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasApp.Presenters
{
    public class ProveedorPresenter
    {

        //fields
        private IProveedorView view;
        private IProveedorRepository repository;
        private BindingSource proveedoresBindingSource;
        private IEnumerable<ProveedorModel> proveedoresList;

        //constructor
        public ProveedorPresenter(IProveedorView view, IProveedorRepository repository)
        {
            this.proveedoresBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //suscribe event handler methods to view events
            this.view.SearchEvent += SearchProveedor;
            this.view.AddNewEvent += AddNewProveedor;
            this.view.EditEvent += LoadSelectedProveedorToEdit;
            this.view.DeleteEvent += DeleteSelectedProveedor;
            this.view.SaveEvent += SaveProveedor;
            this.view.CancelEvent += CancelAction;

            //Set Proveedors bindingSource
            this.view.SetProveedoresListBindingSource(proveedoresBindingSource);
            //load proveedores list view
            LoadAllProveedoresList();
            //Show view
            this.view.Show();
        }

        private void LoadAllProveedoresList()
        {
            proveedoresList = repository.GetAll();
            proveedoresBindingSource.DataSource = proveedoresList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SaveProveedor(object? sender, EventArgs e)
        {
            var model = new ProveedorModel();
            model.Id = Convert.ToInt32(view.IdProveedor);
            model.Nombre = view.NombreProveedor;
            model.Apellido = view.ApellidoProveedor;
            model.Email = view.EmailProveedor;
            model.Telefono = view.TelefonoProveedor;
            model.Direccion = view.DireccionProveedor;
            model.Latitud = view.LatitudProveedor;
            model.Longitud = view.LongitudProveedor;

            try
            {
                new Common.ModelDatValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Proveedor actualizado";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Proveedor añadido";
                }
                view.IsSuccesful = true;
                LoadAllProveedoresList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.IdProveedor = "0";
            view.NombreProveedor = "";
            view.ApellidoProveedor = "";
            view.EmailProveedor = "";
            view.TelefonoProveedor = "";
            view.DireccionProveedor = "";
            view.LatitudProveedor = "";
            view.LongitudProveedor = "";
        }

        private void DeleteSelectedProveedor(object? sender, EventArgs e)
        {
            try
            {
                var proveedor = (ProveedorModel)proveedoresBindingSource.Current;
                repository.Delete(proveedor.Id);
                view.IsSuccesful = true;
                view.Message = "Proveedor eliminado";
                LoadAllProveedoresList();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = "Un error ha ocurrido al eliminar";
            }
        }

        private void LoadSelectedProveedorToEdit(object? sender, EventArgs e)
        {
            var proveedor = (ProveedorModel)proveedoresBindingSource.Current;
            view.IdProveedor = proveedor.Id.ToString();
            view.NombreProveedor = proveedor.Nombre;
            view.ApellidoProveedor = proveedor.Apellido;
            view.EmailProveedor = proveedor.Email;
            view.TelefonoProveedor = proveedor.Telefono;
            view.DireccionProveedor = proveedor.Direccion;
            view.LatitudProveedor = proveedor.Latitud;
            view.LongitudProveedor = proveedor.Longitud;
            view.ShowMap(proveedor.Latitud, proveedor.Longitud);
            view.IsEdit = true;


        }

        private void AddNewProveedor(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProveedor(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)

                proveedoresList = repository.GetByValue(this.view.SearchValue);
            else proveedoresList = repository.GetAll();
            proveedoresBindingSource.DataSource = proveedoresList;

        }
    }
}
