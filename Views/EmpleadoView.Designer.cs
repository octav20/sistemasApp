namespace sistemasApp.Views
{
    partial class EmpleadoView
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
            Clientes = new Label();
            tabControl1 = new TabControl();
            listaEmpleados = new TabPage();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label1 = new Label();
            detalleEmpleado = new TabPage();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            btnCancel = new Button();
            btnSave = new Button();
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
            button1 = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            listaEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            detalleEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(Clientes);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 54);
            panel1.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(821, 22);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 23);
            btnClose.TabIndex = 7;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            Clientes.AutoSize = true;
            Clientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Clientes.Location = new Point(12, 22);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(108, 25);
            Clientes.TabIndex = 0;
            Clientes.Text = "Empleados";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(listaEmpleados);
            tabControl1.Controls.Add(detalleEmpleado);
            tabControl1.Location = new Point(0, 60);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(569, 476);
            tabControl1.TabIndex = 3;
            // 
            // listaEmpleados
            // 
            listaEmpleados.Controls.Add(dataGridView1);
            listaEmpleados.Controls.Add(btnDelete);
            listaEmpleados.Controls.Add(btnEdit);
            listaEmpleados.Controls.Add(btnAdd);
            listaEmpleados.Controls.Add(btnBuscar);
            listaEmpleados.Controls.Add(txtBuscar);
            listaEmpleados.Controls.Add(label1);
            listaEmpleados.Location = new Point(4, 24);
            listaEmpleados.Name = "listaEmpleados";
            listaEmpleados.Padding = new Padding(3);
            listaEmpleados.Size = new Size(561, 448);
            listaEmpleados.TabIndex = 0;
            listaEmpleados.Text = "Lista de Empleados";
            listaEmpleados.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(351, 385);
            dataGridView1.TabIndex = 13;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(385, 157);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(385, 117);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(385, 74);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Añadir";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.Location = new Point(365, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(8, 26);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(351, 23);
            txtBuscar.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 6);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 7;
            label1.Text = "Buscar Empleado";
            // 
            // detalleEmpleado
            // 
            detalleEmpleado.Controls.Add(webView21);
            detalleEmpleado.Controls.Add(btnCancel);
            detalleEmpleado.Controls.Add(btnSave);
            detalleEmpleado.Controls.Add(txtLat);
            detalleEmpleado.Controls.Add(txtLongi);
            detalleEmpleado.Controls.Add(txtAddress);
            detalleEmpleado.Controls.Add(txtPhone);
            detalleEmpleado.Controls.Add(txtEmail);
            detalleEmpleado.Controls.Add(txtLastName);
            detalleEmpleado.Controls.Add(txtName);
            detalleEmpleado.Controls.Add(txtId);
            detalleEmpleado.Controls.Add(label9);
            detalleEmpleado.Controls.Add(label8);
            detalleEmpleado.Controls.Add(label7);
            detalleEmpleado.Controls.Add(label6);
            detalleEmpleado.Controls.Add(label5);
            detalleEmpleado.Controls.Add(label4);
            detalleEmpleado.Controls.Add(label3);
            detalleEmpleado.Controls.Add(label2);
            detalleEmpleado.Location = new Point(4, 24);
            detalleEmpleado.Name = "detalleEmpleado";
            detalleEmpleado.Padding = new Padding(3);
            detalleEmpleado.Size = new Size(561, 448);
            detalleEmpleado.TabIndex = 1;
            detalleEmpleado.Text = "Detalle Empleado";
            detalleEmpleado.UseVisualStyleBackColor = true;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(62, 191);
            webView21.Name = "webView21";
            webView21.Size = new Size(400, 248);
            webView21.TabIndex = 37;
            webView21.ZoomFactor = 1D;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(400, 148);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 36;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Location = new Point(310, 147);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 35;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtLat
            // 
            txtLat.Location = new Point(152, 147);
            txtLat.Name = "txtLat";
            txtLat.Size = new Size(100, 23);
            txtLat.TabIndex = 34;
            // 
            // txtLongi
            // 
            txtLongi.Location = new Point(18, 148);
            txtLongi.Name = "txtLongi";
            txtLongi.Size = new Size(100, 23);
            txtLongi.TabIndex = 33;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(285, 85);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 32;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(152, 85);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 31;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(18, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 30;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Location = new Point(285, 31);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 29;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(152, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 28;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtId.Location = new Point(18, 31);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 27;
            txtId.Text = "0";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(18, 130);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 26;
            label9.Text = "Longitud:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(152, 67);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 25;
            label8.Text = "Telefono:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(285, 67);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 24;
            label7.Text = "Domicilio:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(152, 130);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 23;
            label6.Text = "Latitud:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(18, 67);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 22;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(285, 13);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 21;
            label4.Text = "Apellido:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(152, 13);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 20;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(18, 13);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 19;
            label2.Text = "Id:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(525, 22);
            button1.Name = "button1";
            button1.Size = new Size(32, 23);
            button1.TabIndex = 8;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            // 
            // EmpleadoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 535);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "EmpleadoView";
            Text = "EmpleadoView";
            Load += EmpleadoView_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            listaEmpleados.ResumeLayout(false);
            listaEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            detalleEmpleado.ResumeLayout(false);
            detalleEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private Label Clientes;
        private TabControl tabControl1;
        private TabPage listaEmpleados;
        private TabPage detalleEmpleado;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button btnCancel;
        private Button btnSave;
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
        private Button button1;
    }
}