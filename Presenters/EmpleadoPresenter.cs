using sistemasApp.Models;
using sistemasApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasApp.Presenters
{
    public class EmpleadoPresenter
    {

        //fields
        private IEmpleadoView view;
        private IEmpleadoRepository repository;
        private BindingSource empleadosBindingSource;
        private IEnumerable<EmpleadoModel> empleadosList;

        //constructor
        public EmpleadoPresenter(IEmpleadoView view, IEmpleadoRepository repository)
        {
            this.empleadosBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //suscribe event handler methods to view events
            this.view.SearchEvent += SearchEmpleado;
            this.view.AddNewEvent += AddNewEmpleado;
            this.view.EditEvent += LoadSelectedEmpleadoToEdit;
            this.view.DeleteEvent += DeleteSelectedEmpleado;
            this.view.SaveEvent += SaveEmpleado;
            this.view.CancelEvent += CancelAction;

            //Set empleados bindingSource
            this.view.SetEmpleadosListBindingSource(empleadosBindingSource);
            //load empleados list view
            LoadAllEmpleadosList();
            //Show view
            this.view.Show();
        }

        private void LoadAllEmpleadosList()
        {
            empleadosList = repository.GetAll();
            empleadosBindingSource.DataSource = empleadosList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SaveEmpleado(object? sender, EventArgs e)
        {
            var model = new EmpleadoModel();
            model.Id = Convert.ToInt32(view.IdEmpleado);
            model.Nombre = view.NombreEmpleado;
            model.Apellido = view.ApellidoEmpleado;
            model.Email = view.EmailEmpleado;
            model.Telefono = view.TelefonoEmpleado;
            model.Direccion = view.DireccionEmpleado;
            model.Latitud = view.LatitudEmpleado;
            model.Longitud = view.LongitudEmpleado;

            try
            {
                new Common.ModelDatValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Empleado actualizado";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Empleado añadido";
                }
                view.IsSuccesful = true;
                LoadAllEmpleadosList();
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
            view.IdEmpleado = "0";
            view.NombreEmpleado = "";
            view.ApellidoEmpleado = "";
            view.EmailEmpleado = "";
            view.TelefonoEmpleado = "";
            view.DireccionEmpleado = "";
            view.LatitudEmpleado = "";
            view.LongitudEmpleado = "";
        }

        private void DeleteSelectedEmpleado(object? sender, EventArgs e)
        {
            try
            {
                var empleado = (EmpleadoModel)empleadosBindingSource.Current;
                repository.Delete(empleado.Id);
                view.IsSuccesful = true;
                view.Message = "Empleado eliminado";
                LoadAllEmpleadosList();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = "Un error ha ocurrido al eliminar";
            }
        }

        private void LoadSelectedEmpleadoToEdit(object? sender, EventArgs e)
        {
            var empleado = (EmpleadoModel)empleadosBindingSource.Current;
            view.IdEmpleado = empleado.Id.ToString();
            view.NombreEmpleado = empleado.Nombre;
            view.ApellidoEmpleado = empleado.Apellido;
            view.EmailEmpleado = empleado.Email;
            view.TelefonoEmpleado = empleado.Telefono;
            view.DireccionEmpleado = empleado.Direccion;
            view.LatitudEmpleado = empleado.Latitud;
            view.LongitudEmpleado = empleado.Longitud;
            view.ShowMap(empleado.Latitud, empleado.Longitud);
            view.IsEdit = true;


        }

        private void AddNewEmpleado(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchEmpleado(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)

                empleadosList = repository.GetByValue(this.view.SearchValue);
            else empleadosList = repository.GetAll();
            empleadosBindingSource.DataSource = empleadosList;

        }
    }
}
