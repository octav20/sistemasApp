using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemasApp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnClientes.Click += delegate { ShowClienteView.Invoke(this, EventArgs.Empty); };
            btnEmpleados.Click += delegate { ShowEmpleadoView.Invoke(this, EventArgs.Empty); };
            btnProveedores.Click += delegate { ShowProveedorView.Invoke(this, EventArgs.Empty); };

        }

        public event EventHandler ShowClienteView;
        public event EventHandler ShowEmpleadoView;
        public event EventHandler ShowProveedorView;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
