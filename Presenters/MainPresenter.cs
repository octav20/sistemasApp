using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasApp.Models;
using sistemasApp.Views;
using sistemasApp.Repositories;

namespace sistemasApp.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString ) 
        {
           this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowClienteView += ShowClienteView;
            this.mainView.ShowEmpleadoView += ShowEmpleadoView;
            this.mainView.ShowProveedorView += ShowProveedorView;
           

        }

        private void ShowProveedorView(object? sender, EventArgs e)
        {
          IProveedorView view = ProveedorView.GetInstance((MainView)mainView);
            IProveedorRepository repository = new ProveedorRepository(sqlConnectionString);
            new ProveedorPresenter(view, repository);
        }

        private void ShowEmpleadoView(object? sender, EventArgs e)
        {
            IEmpleadoView view = EmpleadoView.GetInstance((MainView)mainView);
            IEmpleadoRepository repository = new EmpleadoRepository(sqlConnectionString);
            new EmpleadoPresenter(view, repository);
        }

        private void ShowClienteView(object? sender, EventArgs e)
        {
            IClienteView view = ClienteView.GetInstance((MainView)mainView);
            IClienteRepository repository = new ClienteRepository(sqlConnectionString);
            new ClientePresenter(view, repository);

        }
    }
}
