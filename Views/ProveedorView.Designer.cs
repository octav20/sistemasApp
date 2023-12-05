namespace sistemasApp.Views
{
    partial class ProveedorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnClose = new Button();
            Proveedores = new Label();
            tabControl1 = new TabControl();
            listaProveedores = new TabPage();
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            detalleProveedor = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            txtLat = new TextBox();
            txtLongi = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtBuscar = new TextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            listaProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            detalleProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(Proveedores);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 54);
            panel1.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(520, 22);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 23);
            btnClose.TabIndex = 8;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // Proveedores
            // 
            Proveedores.AutoSize = true;
            Proveedores.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Proveedores.Location = new Point(12, 22);
            Proveedores.Name = "Proveedores";
            Proveedores.Size = new Size(124, 25);
            Proveedores.TabIndex = 0;
            Proveedores.Text = "Proveedores";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(listaProveedores);
            tabControl1.Controls.Add(detalleProveedor);
            tabControl1.Location = new Point(-2, 59);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(568, 482);
            tabControl1.TabIndex = 4;
            // 
            // listaProveedores
            // 
            listaProveedores.Controls.Add(txtSearch);
            listaProveedores.Controls.Add(btnDelete);
            listaProveedores.Controls.Add(btnEdit);
            listaProveedores.Controls.Add(btnAdd);
            listaProveedores.Controls.Add(btnSearch);
            listaProveedores.Controls.Add(dataGridView1);
            listaProveedores.Controls.Add(label1);
            listaProveedores.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            listaProveedores.Location = new Point(4, 24);
            listaProveedores.Name = "listaProveedores";
            listaProveedores.Padding = new Padding(3);
            listaProveedores.Size = new Size(560, 454);
            listaProveedores.TabIndex = 0;
            listaProveedores.Text = "Lista de Proveedores";
            listaProveedores.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(10, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(417, 25);
            txtSearch.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(475, 157);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(475, 117);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(475, 74);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Añadir";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(455, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(416, 389);
            dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 6);
            label1.Name = "label1";
            label1.Size = new Size(115, 17);
            label1.TabIndex = 0;
            label1.Text = "Buscar Proveedor\r\n";
            // 
            // detalleProveedor
            // 
            detalleProveedor.Controls.Add(btnCancel);
            detalleProveedor.Controls.Add(btnSave);
            detalleProveedor.Controls.Add(webView21);
            detalleProveedor.Controls.Add(txtLat);
            detalleProveedor.Controls.Add(txtLongi);
            detalleProveedor.Controls.Add(txtAddress);
            detalleProveedor.Controls.Add(txtPhone);
            detalleProveedor.Controls.Add(txtEmail);
            detalleProveedor.Controls.Add(txtLastName);
            detalleProveedor.Controls.Add(txtName);
            detalleProveedor.Controls.Add(txtId);
            detalleProveedor.Controls.Add(label9);
            detalleProveedor.Controls.Add(label8);
            detalleProveedor.Controls.Add(label7);
            detalleProveedor.Controls.Add(label6);
            detalleProveedor.Controls.Add(label5);
            detalleProveedor.Controls.Add(label4);
            detalleProveedor.Controls.Add(label3);
            detalleProveedor.Controls.Add(label2);
            detalleProveedor.Location = new Point(4, 24);
            detalleProveedor.Name = "detalleProveedor";
            detalleProveedor.Padding = new Padding(3);
            detalleProveedor.Size = new Size(560, 454);
            detalleProveedor.TabIndex = 1;
            detalleProveedor.Text = "Detalle Proveedor";
            detalleProveedor.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(410, 157);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Location = new Point(320, 156);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 19;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(30, 226);
            webView21.Name = "webView21";
            webView21.Size = new Size(478, 210);
            webView21.TabIndex = 18;
            webView21.ZoomFactor = 1D;
            // 
            // txtLat
            // 
            txtLat.Location = new Point(27, 157);
            txtLat.Name = "txtLat";
            txtLat.Size = new Size(100, 23);
            txtLat.TabIndex = 15;
            // 
            // txtLongi
            // 
            txtLongi.Location = new Point(161, 157);
            txtLongi.Name = "txtLongi";
            txtLongi.Size = new Size(100, 23);
            txtLongi.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(297, 97);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(98, 23);
            txtAddress.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(164, 97);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(97, 23);
            txtPhone.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(30, 97);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(97, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Location = new Point(297, 43);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(98, 23);
            txtLastName.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(164, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(97, 23);
            txtName.TabIndex = 9;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtId.Location = new Point(30, 43);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(97, 23);
            txtId.TabIndex = 8;
            txtId.Text = "0";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(30, 142);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 7;
            label9.Text = "Longitud:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(164, 79);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 6;
            label8.Text = "Telefono:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(297, 79);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 5;
            label7.Text = "Domicilio:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(164, 142);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 4;
            label6.Text = "Latitud:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(30, 79);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 3;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 25);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 2;
            label4.Text = "Apellido:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(164, 25);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 1;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(30, 25);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 0;
            label2.Text = "Id:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(11, 26);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(416, 23);
            txtBuscar.TabIndex = 1;
            // 
            // ProveedorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 541);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Name = "ProveedorView";
            Text = "ProveedorView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            listaProveedores.ResumeLayout(false);
            listaProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            detalleProveedor.ResumeLayout(false);
            detalleProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Proveedores;
        private TabControl tabControl1;
        private TabPage listaProveedores;
        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private Label label1;
        private TabPage detalleProveedor;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;

        private TextBox txtLat;
        private TextBox txtLongi;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtName;
        private TextBox txtId;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnClose;
        private TextBox txtSearch;
        private Button btnCancel;
        private Button btnSave;
    }
}