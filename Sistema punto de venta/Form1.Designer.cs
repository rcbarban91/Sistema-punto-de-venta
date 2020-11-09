namespace Sistema_punto_de_venta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBoxCliente_Credito = new System.Windows.Forms.CheckBox();
            this.buttonCliente_Cancelar = new System.Windows.Forms.Button();
            this.buttonCliente_Agregar = new System.Windows.Forms.Button();
            this.textBoxCliente_Direccion = new System.Windows.Forms.TextBox();
            this.labelCliente_Direccion = new System.Windows.Forms.Label();
            this.textBoxCliente_Telefono = new System.Windows.Forms.TextBox();
            this.labelCliente_Telefono = new System.Windows.Forms.Label();
            this.textBoxCliente_Email = new System.Windows.Forms.TextBox();
            this.labelCliente_Email = new System.Windows.Forms.Label();
            this.textBoxCliente_Apellido = new System.Windows.Forms.TextBox();
            this.labelCliente_Apellido = new System.Windows.Forms.Label();
            this.textBoxCliente_Nombre = new System.Windows.Forms.TextBox();
            this.labelCliente_Nombre = new System.Windows.Forms.Label();
            this.textBoxCliente_NID = new System.Windows.Forms.TextBox();
            this.labelCliente_NID = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBoxCliente = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCliente_Buscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.dataGridView_Clientes = new System.Windows.Forms.DataGridView();
            this.tabControlPrincipal.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlPrincipal.Controls.Add(this.tabPage1);
            this.tabControlPrincipal.Controls.Add(this.tabPage2);
            this.tabControlPrincipal.Location = new System.Drawing.Point(1, 132);
            this.tabControlPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(1685, 609);
            this.tabControlPrincipal.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1677, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ventas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1677, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.dataGridView_Clientes);
            this.groupBox5.Location = new System.Drawing.Point(425, 81);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1242, 490);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.tabControl2);
            this.groupBox3.Location = new System.Drawing.Point(1, 74);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(417, 499);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(0, 7);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(410, 471);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBoxCliente_Credito);
            this.tabPage3.Controls.Add(this.buttonCliente_Cancelar);
            this.tabPage3.Controls.Add(this.buttonCliente_Agregar);
            this.tabPage3.Controls.Add(this.textBoxCliente_Direccion);
            this.tabPage3.Controls.Add(this.labelCliente_Direccion);
            this.tabPage3.Controls.Add(this.textBoxCliente_Telefono);
            this.tabPage3.Controls.Add(this.labelCliente_Telefono);
            this.tabPage3.Controls.Add(this.textBoxCliente_Email);
            this.tabPage3.Controls.Add(this.labelCliente_Email);
            this.tabPage3.Controls.Add(this.textBoxCliente_Apellido);
            this.tabPage3.Controls.Add(this.labelCliente_Apellido);
            this.tabPage3.Controls.Add(this.textBoxCliente_Nombre);
            this.tabPage3.Controls.Add(this.labelCliente_Nombre);
            this.tabPage3.Controls.Add(this.textBoxCliente_NID);
            this.tabPage3.Controls.Add(this.labelCliente_NID);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(402, 442);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Regristro de cliente";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBoxCliente_Credito
            // 
            this.checkBoxCliente_Credito.AutoSize = true;
            this.checkBoxCliente_Credito.Location = new System.Drawing.Point(11, 352);
            this.checkBoxCliente_Credito.Name = "checkBoxCliente_Credito";
            this.checkBoxCliente_Credito.Size = new System.Drawing.Size(75, 21);
            this.checkBoxCliente_Credito.TabIndex = 15;
            this.checkBoxCliente_Credito.Text = "Credito";
            this.checkBoxCliente_Credito.UseVisualStyleBackColor = true;
            // 
            // buttonCliente_Cancelar
            // 
            this.buttonCliente_Cancelar.BackColor = System.Drawing.Color.Gray;
            this.buttonCliente_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCliente_Cancelar.FlatAppearance.BorderSize = 0;
            this.buttonCliente_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCliente_Cancelar.Image = global::Sistema_punto_de_venta.Properties.Resources.cancelar;
            this.buttonCliente_Cancelar.Location = new System.Drawing.Point(211, 389);
            this.buttonCliente_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCliente_Cancelar.Name = "buttonCliente_Cancelar";
            this.buttonCliente_Cancelar.Size = new System.Drawing.Size(100, 39);
            this.buttonCliente_Cancelar.TabIndex = 14;
            this.buttonCliente_Cancelar.UseVisualStyleBackColor = false;
            this.buttonCliente_Cancelar.Click += new System.EventHandler(this.buttonCliente_Cancelar_Click);
            // 
            // buttonCliente_Agregar
            // 
            this.buttonCliente_Agregar.BackColor = System.Drawing.Color.Gray;
            this.buttonCliente_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCliente_Agregar.FlatAppearance.BorderSize = 0;
            this.buttonCliente_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCliente_Agregar.Image = global::Sistema_punto_de_venta.Properties.Resources.adicionar1;
            this.buttonCliente_Agregar.Location = new System.Drawing.Point(89, 389);
            this.buttonCliente_Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCliente_Agregar.Name = "buttonCliente_Agregar";
            this.buttonCliente_Agregar.Size = new System.Drawing.Size(100, 39);
            this.buttonCliente_Agregar.TabIndex = 4;
            this.buttonCliente_Agregar.UseVisualStyleBackColor = false;
            this.buttonCliente_Agregar.Click += new System.EventHandler(this.buttonCliente_Agregar_Click);
            // 
            // textBoxCliente_Direccion
            // 
            this.textBoxCliente_Direccion.Location = new System.Drawing.Point(211, 321);
            this.textBoxCliente_Direccion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCliente_Direccion.Multiline = true;
            this.textBoxCliente_Direccion.Name = "textBoxCliente_Direccion";
            this.textBoxCliente_Direccion.Size = new System.Drawing.Size(179, 24);
            this.textBoxCliente_Direccion.TabIndex = 13;
            this.textBoxCliente_Direccion.TextChanged += new System.EventHandler(this.textBoxCliente_Direccion_TextChanged);
            // 
            // labelCliente_Direccion
            // 
            this.labelCliente_Direccion.AutoSize = true;
            this.labelCliente_Direccion.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelCliente_Direccion.Location = new System.Drawing.Point(208, 300);
            this.labelCliente_Direccion.Name = "labelCliente_Direccion";
            this.labelCliente_Direccion.Size = new System.Drawing.Size(67, 17);
            this.labelCliente_Direccion.TabIndex = 12;
            this.labelCliente_Direccion.Text = "Direccion";
            // 
            // textBoxCliente_Telefono
            // 
            this.textBoxCliente_Telefono.Location = new System.Drawing.Point(10, 321);
            this.textBoxCliente_Telefono.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCliente_Telefono.Multiline = true;
            this.textBoxCliente_Telefono.Name = "textBoxCliente_Telefono";
            this.textBoxCliente_Telefono.Size = new System.Drawing.Size(179, 24);
            this.textBoxCliente_Telefono.TabIndex = 11;
            this.textBoxCliente_Telefono.TextChanged += new System.EventHandler(this.textBoxCliente_Telefono_TextChanged);
            this.textBoxCliente_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCliente_Telefono_KeyPress);
            // 
            // labelCliente_Telefono
            // 
            this.labelCliente_Telefono.AutoSize = true;
            this.labelCliente_Telefono.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelCliente_Telefono.Location = new System.Drawing.Point(7, 300);
            this.labelCliente_Telefono.Name = "labelCliente_Telefono";
            this.labelCliente_Telefono.Size = new System.Drawing.Size(64, 17);
            this.labelCliente_Telefono.TabIndex = 10;
            this.labelCliente_Telefono.Text = "Telefono";
            // 
            // textBoxCliente_Email
            // 
            this.textBoxCliente_Email.Location = new System.Drawing.Point(211, 274);
            this.textBoxCliente_Email.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCliente_Email.Multiline = true;
            this.textBoxCliente_Email.Name = "textBoxCliente_Email";
            this.textBoxCliente_Email.Size = new System.Drawing.Size(179, 24);
            this.textBoxCliente_Email.TabIndex = 9;
            this.textBoxCliente_Email.TextChanged += new System.EventHandler(this.textBoxCliente_Email_TextChanged);
            // 
            // labelCliente_Email
            // 
            this.labelCliente_Email.AutoSize = true;
            this.labelCliente_Email.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelCliente_Email.Location = new System.Drawing.Point(208, 253);
            this.labelCliente_Email.Name = "labelCliente_Email";
            this.labelCliente_Email.Size = new System.Drawing.Size(42, 17);
            this.labelCliente_Email.TabIndex = 8;
            this.labelCliente_Email.Text = "Email";
            // 
            // textBoxCliente_Apellido
            // 
            this.textBoxCliente_Apellido.Location = new System.Drawing.Point(10, 274);
            this.textBoxCliente_Apellido.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCliente_Apellido.Multiline = true;
            this.textBoxCliente_Apellido.Name = "textBoxCliente_Apellido";
            this.textBoxCliente_Apellido.Size = new System.Drawing.Size(179, 24);
            this.textBoxCliente_Apellido.TabIndex = 7;
            this.textBoxCliente_Apellido.TextChanged += new System.EventHandler(this.textBoxCliente_Apellido_TextChanged);
            this.textBoxCliente_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCliente_Apellido_KeyPress);
            // 
            // labelCliente_Apellido
            // 
            this.labelCliente_Apellido.AutoSize = true;
            this.labelCliente_Apellido.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelCliente_Apellido.Location = new System.Drawing.Point(7, 253);
            this.labelCliente_Apellido.Name = "labelCliente_Apellido";
            this.labelCliente_Apellido.Size = new System.Drawing.Size(58, 17);
            this.labelCliente_Apellido.TabIndex = 6;
            this.labelCliente_Apellido.Text = "Apellido";
            // 
            // textBoxCliente_Nombre
            // 
            this.textBoxCliente_Nombre.Location = new System.Drawing.Point(211, 224);
            this.textBoxCliente_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCliente_Nombre.Multiline = true;
            this.textBoxCliente_Nombre.Name = "textBoxCliente_Nombre";
            this.textBoxCliente_Nombre.Size = new System.Drawing.Size(179, 24);
            this.textBoxCliente_Nombre.TabIndex = 5;
            this.textBoxCliente_Nombre.TextChanged += new System.EventHandler(this.textBoxCliente_Nombre_TextChanged);
            this.textBoxCliente_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCliente_Nombre_KeyPress);
            // 
            // labelCliente_Nombre
            // 
            this.labelCliente_Nombre.AutoSize = true;
            this.labelCliente_Nombre.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelCliente_Nombre.Location = new System.Drawing.Point(208, 203);
            this.labelCliente_Nombre.Name = "labelCliente_Nombre";
            this.labelCliente_Nombre.Size = new System.Drawing.Size(58, 17);
            this.labelCliente_Nombre.TabIndex = 4;
            this.labelCliente_Nombre.Text = "Nombre";
            // 
            // textBoxCliente_NID
            // 
            this.textBoxCliente_NID.Location = new System.Drawing.Point(10, 224);
            this.textBoxCliente_NID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCliente_NID.Multiline = true;
            this.textBoxCliente_NID.Name = "textBoxCliente_NID";
            this.textBoxCliente_NID.Size = new System.Drawing.Size(179, 24);
            this.textBoxCliente_NID.TabIndex = 3;
            this.textBoxCliente_NID.TextChanged += new System.EventHandler(this.textBoxCliente_NID_TextChanged);
            this.textBoxCliente_NID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCliente_NID_KeyPress);
            // 
            // labelCliente_NID
            // 
            this.labelCliente_NID.AutoSize = true;
            this.labelCliente_NID.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelCliente_NID.Location = new System.Drawing.Point(7, 203);
            this.labelCliente_NID.Name = "labelCliente_NID";
            this.labelCliente_NID.Size = new System.Drawing.Size(31, 17);
            this.labelCliente_NID.TabIndex = 2;
            this.labelCliente_NID.Text = "NID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBoxCliente);
            this.groupBox4.Location = new System.Drawing.Point(109, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 160);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // pictureBoxCliente
            // 
            this.pictureBoxCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCliente.Image = global::Sistema_punto_de_venta.Properties.Resources.foto_de_perfil;
            this.pictureBoxCliente.Location = new System.Drawing.Point(19, 13);
            this.pictureBoxCliente.Name = "pictureBoxCliente";
            this.pictureBoxCliente.Size = new System.Drawing.Size(161, 141);
            this.pictureBoxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCliente.TabIndex = 0;
            this.pictureBoxCliente.TabStop = false;
            this.pictureBoxCliente.Click += new System.EventHandler(this.pictureBoxCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label4.Location = new System.Drawing.Point(121, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Informacion del cliente";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(402, 442);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Pago";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxCliente_Buscar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(1, -1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1668, 71);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // textBoxCliente_Buscar
            // 
            this.textBoxCliente_Buscar.Location = new System.Drawing.Point(445, 27);
            this.textBoxCliente_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCliente_Buscar.Multiline = true;
            this.textBoxCliente_Buscar.Name = "textBoxCliente_Buscar";
            this.textBoxCliente_Buscar.Size = new System.Drawing.Size(260, 24);
            this.textBoxCliente_Buscar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(360, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Clientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-11, -16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1708, 94);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(652, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema punto de venta";
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackColor = System.Drawing.Color.Gray;
            this.buttonCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCliente.FlatAppearance.BorderSize = 0;
            this.buttonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCliente.Image = global::Sistema_punto_de_venta.Properties.Resources.cliente;
            this.buttonCliente.Location = new System.Drawing.Point(104, 85);
            this.buttonCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(100, 39);
            this.buttonCliente.TabIndex = 2;
            this.buttonCliente.UseVisualStyleBackColor = false;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // dataGridView_Clientes
            // 
            this.dataGridView_Clientes.AllowUserToAddRows = false;
            this.dataGridView_Clientes.AllowUserToDeleteRows = false;
            this.dataGridView_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Clientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Clientes.Location = new System.Drawing.Point(0, 10);
            this.dataGridView_Clientes.Name = "dataGridView_Clientes";
            this.dataGridView_Clientes.ReadOnly = true;
            this.dataGridView_Clientes.RowHeadersWidth = 51;
            this.dataGridView_Clientes.RowTemplate.Height = 24;
            this.dataGridView_Clientes.Size = new System.Drawing.Size(1242, 360);
            this.dataGridView_Clientes.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1685, 748);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.tabControlPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCliente_Buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCliente_Direccion;
        private System.Windows.Forms.Label labelCliente_Direccion;
        private System.Windows.Forms.TextBox textBoxCliente_Telefono;
        private System.Windows.Forms.Label labelCliente_Telefono;
        private System.Windows.Forms.TextBox textBoxCliente_Email;
        private System.Windows.Forms.Label labelCliente_Email;
        private System.Windows.Forms.TextBox textBoxCliente_Apellido;
        private System.Windows.Forms.Label labelCliente_Apellido;
        private System.Windows.Forms.TextBox textBoxCliente_Nombre;
        private System.Windows.Forms.Label labelCliente_Nombre;
        private System.Windows.Forms.TextBox textBoxCliente_NID;
        private System.Windows.Forms.Label labelCliente_NID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBoxCliente;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonCliente_Cancelar;
        private System.Windows.Forms.Button buttonCliente_Agregar;
        private System.Windows.Forms.CheckBox checkBoxCliente_Credito;
        private System.Windows.Forms.DataGridView dataGridView_Clientes;
    }
}

