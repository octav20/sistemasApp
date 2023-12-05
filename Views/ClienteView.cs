
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace sistemasApp.Views
{
    public partial class ClienteView : Form, IClienteView
    {
        private string message;
        private bool isSuccesful;
        private bool isEdit;

        public ClienteView()
        {
            InitializeComponent();

            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPage2);
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
            btnBuscar.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            txtBuscar.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            //Add new
            btnAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Add new Client";
                webView21.Visible = false;
            };
            //Edit
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Edit Client";

            };
            //Save changes
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccesful)
                {
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Add(tabPage1);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Add(tabPage1);
            };
            //Delete
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected client?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);

                }
            };


        }

        //Properties
        public string IdCliente
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
        public string NombreCLiente
        {
            get
            {
                return txtName.Text;
            }
            set { txtName.Text = value; }
        }

        public string ApellidoCLiente
        {
            get
            {
                return txtLastName.Text;
            }
            set { txtLastName.Text = value; }
        }

        public string EmailCliente
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

        public string TelefonoCliente
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
        public string DireccionCliente
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

        public string LatitudCliente
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

        public string LongitudCliente
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
        public string FechaNacCliente { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



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
        public void SetClientesListBindingSource(BindingSource clientesList)
        {
            dataGridView1.DataSource = clientesList;
        }

        //Sigleton pattern (Open a single form instance
        private static ClienteView instance;
        public static ClienteView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ClienteView();
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
        private void ClienteView_Load(object sender, EventArgs e)
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
