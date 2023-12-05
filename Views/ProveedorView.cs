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
    public partial class ProveedorView : Form, IProveedorView
    {
        private string message;
        private bool isSuccesful;
        private bool isEdit;

        public ProveedorView()
        {
            InitializeComponent();

            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(detalleProveedor);
            btnClose.Click += delegate { this.Close(); };


        }
        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser(string url)
        {
            await initizated();

            webView21.CoreWebView2.Navigate(url);
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Search
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            txtBuscar.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            //Add new
            btnAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(listaProveedores);
                tabControl1.TabPages.Add(detalleProveedor);
                detalleProveedor.Text = "Añadir proveedor";
                webView21.Visible = false;
            };
            //Edit
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(listaProveedores);
                tabControl1.TabPages.Add(detalleProveedor);
                detalleProveedor.Text = "Editar proveedor";

            };
            //Save changes
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccesful)
                {
                    tabControl1.TabPages.Remove(detalleProveedor);
                    tabControl1.TabPages.Add(listaProveedores);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(detalleProveedor);
                tabControl1.TabPages.Add(listaProveedores);
            };
            //Delete
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("¿Estas seguro de eliminar el proveedor seleccionado?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);

                }
            };


        }

        //Properties
        public string IdProveedor
        {
            get
            {
                return txtId.Text;
            }
            set
            {
                txtId.Text = value;
            }
        }
        public string NombreProveedor
        {
            get
            {
                return txtName.Text;
            }
            set { txtName.Text = value; }
        }

        public string ApellidoProveedor
        {
            get
            {
                return txtLastName.Text;
            }
            set { txtLastName.Text = value; }
        }

        public string EmailProveedor
        {
            get
            {
                return txtEmail.Text;
            }
            set
            {
                txtEmail.Text = value;
            }
        }

        public string TelefonoProveedor
        {
            get
            {
                return txtPhone.Text;
            }
            set
            {
                txtPhone.Text = value;
            }
        }
        public string DireccionProveedor
        {
            get
            {
                return txtAddress.Text;
            }
            set
            {
                txtAddress.Text = value;
            }
        }

        public string LatitudProveedor
        {
            get
            {
                return txtLat.Text;
            }
            set
            {
                txtLat.Text = value;
            }
        }

        public string LongitudProveedor
        {
            get
            {
                return txtLongi.Text;
            }
            set
            {
                txtLongi.Text = value;
            }
        }




        //TODO:hacer la fecha
        public string FechaNacProveedor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



        public string SearchValue
        {
            get
            {
                return txtBuscar.Text;
            }
            set
            {
                txtBuscar.Text = value;
            }
        }

        public bool IsEdit
        {
            get
            {
                return isEdit;
            }
            set
            {
                isEdit = value;
            }
        }

        public bool IsSuccesful
        {
            get { return isSuccesful; }
            set { isSuccesful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Methods
        public void SetProveedoresListBindingSource(BindingSource proveedoresList)
        {
            dataGridView1.DataSource = proveedoresList;
        }

        //Sigleton pattern (Open a single form instance
        private static ProveedorView instance;
        public static ProveedorView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProveedorView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
        private void ProveedorView_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        public void ShowMap(string latitud, string longitud)
        {
            webView21.Visible = true;
            InitBrowser($"https://www.google.com/maps?q={latitud},{longitud}");

        }
    }

}
