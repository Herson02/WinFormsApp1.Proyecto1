namespace WinFormsApp1.Proyecto1
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabCliente = new TabPage();
            dtpFechaRegistro = new DateTimePicker();
            dtpFechaNacimientoCliente = new DateTimePicker();
            checkBox1 = new CheckBox();
            btnMostrarClientes = new Button();
            btnAgregarClientes = new Button();
            lblClienteActivo = new Label();
            lblFechaRegistro = new Label();
            lblFechaNacimientoCliente = new Label();
            textNombreCompletoCliente = new TextBox();
            lblNombreCompletoCliente = new Label();
            textIdentificacionCliente = new TextBox();
            lblIdentificacionCliente = new Label();
            textIdCliente = new TextBox();
            lblIdCliente = new Label();
            tabVendedor = new TabPage();
            dtpFechaIngreso = new DateTimePicker();
            dtpFechaNacimientoVendedor = new DateTimePicker();
            btnMostrarVendedor = new Button();
            btnAgregarVendedor = new Button();
            lblTelefono = new Label();
            lblFechaIngreso = new Label();
            lblFechaNacimientoVendedor = new Label();
            textNombreCompletoVendedor = new TextBox();
            lblNombreCompletoVendedor = new Label();
            textIdentificacionVendedor = new TextBox();
            lblIdentificacionVendedor = new Label();
            textIdVendedor = new TextBox();
            lblIdVendedor = new Label();
            tabVehículo = new TabPage();
            btnMostrar = new Button();
            btnAgregarVehiculo = new Button();
            lblEstado = new Label();
            lblCategoría = new Label();
            textBox15 = new TextBox();
            lblAño = new Label();
            textModelo = new TextBox();
            lblModelo = new Label();
            textMarca = new TextBox();
            lblMarca = new Label();
            textIdVehiculo = new TextBox();
            lblIdVehiculos = new Label();
            tabSucursal = new TabPage();
            this.btnMostrarSucursal = new Button();
            this.btnAgregarSucursal = new Button();
            lblSucursalActiva = new Label();
            this.textVendedorSucursal = new TextBox();
            lblVendedorEncargado = new Label();
            this.textTelefonoSucursal = new TextBox();
            lblTelefonoSucursal = new Label();
            this.textDireccionSucursal = new TextBox();
            lblDireccionSucursal = new Label();
            this.textNombreSucursal = new TextBox();
            lblNombreSucursal = new Label();
            textIdSucursal = new TextBox();
            lblIdSucursal = new Label();
            tabVxS = new TabPage();
            this.btnMostrarVxS = new Button();
            this.btnAgregarVxS = new Button();
            textBox28 = new TextBox();
            this.lblCantidad = new Label();
            textBox29 = new TextBox();
            this.lblVehiculoxS = new Label();
            textBox30 = new TextBox();
            lblSucursalxV = new Label();
            textTelefonoVendedor = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            checkBox2 = new CheckBox();
            tabControl1.SuspendLayout();
            tabCliente.SuspendLayout();
            tabVendedor.SuspendLayout();
            tabVehículo.SuspendLayout();
            tabSucursal.SuspendLayout();
            tabVxS.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCliente);
            tabControl1.Controls.Add(tabVendedor);
            tabControl1.Controls.Add(tabVehículo);
            tabControl1.Controls.Add(tabSucursal);
            tabControl1.Controls.Add(tabVxS);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(968, 569);
            tabControl1.TabIndex = 0;
            // 
            // tabCliente
            // 
            tabCliente.Controls.Add(dtpFechaRegistro);
            tabCliente.Controls.Add(dtpFechaNacimientoCliente);
            tabCliente.Controls.Add(checkBox1);
            tabCliente.Controls.Add(btnMostrarClientes);
            tabCliente.Controls.Add(btnAgregarClientes);
            tabCliente.Controls.Add(lblClienteActivo);
            tabCliente.Controls.Add(lblFechaRegistro);
            tabCliente.Controls.Add(lblFechaNacimientoCliente);
            tabCliente.Controls.Add(textNombreCompletoCliente);
            tabCliente.Controls.Add(lblNombreCompletoCliente);
            tabCliente.Controls.Add(textIdentificacionCliente);
            tabCliente.Controls.Add(lblIdentificacionCliente);
            tabCliente.Controls.Add(textIdCliente);
            tabCliente.Controls.Add(lblIdCliente);
            tabCliente.Location = new Point(4, 29);
            tabCliente.Name = "tabCliente";
            tabCliente.Padding = new Padding(3);
            tabCliente.Size = new Size(960, 536);
            tabCliente.TabIndex = 4;
            tabCliente.Text = "Cliente";
            tabCliente.UseVisualStyleBackColor = true;
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Location = new Point(215, 271);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(311, 27);
            dtpFechaRegistro.TabIndex = 16;
            // 
            // dtpFechaNacimientoCliente
            // 
            dtpFechaNacimientoCliente.Location = new Point(215, 214);
            dtpFechaNacimientoCliente.Name = "dtpFechaNacimientoCliente";
            dtpFechaNacimientoCliente.Size = new Size(311, 27);
            dtpFechaNacimientoCliente.TabIndex = 15;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(215, 331);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(156, 24);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "checkClienteActivo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnMostrarClientes
            // 
            btnMostrarClientes.Location = new Point(628, 206);
            btnMostrarClientes.Name = "btnMostrarClientes";
            btnMostrarClientes.Size = new Size(175, 46);
            btnMostrarClientes.TabIndex = 13;
            btnMostrarClientes.Text = "Mostrar";
            btnMostrarClientes.UseVisualStyleBackColor = true;
            // 
            // btnAgregarClientes
            // 
            btnAgregarClientes.Location = new Point(628, 106);
            btnAgregarClientes.Name = "btnAgregarClientes";
            btnAgregarClientes.Size = new Size(175, 46);
            btnAgregarClientes.TabIndex = 12;
            btnAgregarClientes.Text = "Agregar";
            btnAgregarClientes.UseVisualStyleBackColor = true;
            btnAgregarClientes.Click += btnAgregarClientes_Click;
            // 
            // lblClienteActivo
            // 
            lblClienteActivo.AutoSize = true;
            lblClienteActivo.Location = new Point(55, 331);
            lblClienteActivo.Name = "lblClienteActivo";
            lblClienteActivo.Size = new Size(101, 20);
            lblClienteActivo.TabIndex = 10;
            lblClienteActivo.Text = "Cliente Activo";
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Location = new Point(55, 278);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(127, 20);
            lblFechaRegistro.TabIndex = 8;
            lblFechaRegistro.Text = "Fecha de Registro";
            // 
            // lblFechaNacimientoCliente
            // 
            lblFechaNacimientoCliente.AutoSize = true;
            lblFechaNacimientoCliente.Location = new Point(55, 216);
            lblFechaNacimientoCliente.Name = "lblFechaNacimientoCliente";
            lblFechaNacimientoCliente.Size = new Size(149, 20);
            lblFechaNacimientoCliente.TabIndex = 6;
            lblFechaNacimientoCliente.Text = "Fecha de Nacimiento";
            // 
            // textNombreCompletoCliente
            // 
            textNombreCompletoCliente.Location = new Point(215, 163);
            textNombreCompletoCliente.Name = "textNombreCompletoCliente";
            textNombreCompletoCliente.Size = new Size(170, 27);
            textNombreCompletoCliente.TabIndex = 5;
            // 
            // lblNombreCompletoCliente
            // 
            lblNombreCompletoCliente.AutoSize = true;
            lblNombreCompletoCliente.Location = new Point(55, 163);
            lblNombreCompletoCliente.Name = "lblNombreCompletoCliente";
            lblNombreCompletoCliente.Size = new Size(134, 20);
            lblNombreCompletoCliente.TabIndex = 4;
            lblNombreCompletoCliente.Text = "Nombre Completo";
            // 
            // textIdentificacionCliente
            // 
            textIdentificacionCliente.Location = new Point(215, 106);
            textIdentificacionCliente.Name = "textIdentificacionCliente";
            textIdentificacionCliente.Size = new Size(170, 27);
            textIdentificacionCliente.TabIndex = 3;
            // 
            // lblIdentificacionCliente
            // 
            lblIdentificacionCliente.AutoSize = true;
            lblIdentificacionCliente.Location = new Point(55, 106);
            lblIdentificacionCliente.Name = "lblIdentificacionCliente";
            lblIdentificacionCliente.Size = new Size(99, 20);
            lblIdentificacionCliente.TabIndex = 2;
            lblIdentificacionCliente.Text = "Identificación";
            // 
            // textIdCliente
            // 
            textIdCliente.Location = new Point(215, 53);
            textIdCliente.Name = "textIdCliente";
            textIdCliente.Size = new Size(170, 27);
            textIdCliente.TabIndex = 1;
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(55, 53);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(22, 20);
            lblIdCliente.TabIndex = 0;
            lblIdCliente.Text = "Id";
            // 
            // tabVendedor
            // 
            tabVendedor.Controls.Add(textTelefonoVendedor);
            tabVendedor.Controls.Add(dtpFechaIngreso);
            tabVendedor.Controls.Add(dtpFechaNacimientoVendedor);
            tabVendedor.Controls.Add(btnMostrarVendedor);
            tabVendedor.Controls.Add(btnAgregarVendedor);
            tabVendedor.Controls.Add(lblTelefono);
            tabVendedor.Controls.Add(lblFechaIngreso);
            tabVendedor.Controls.Add(lblFechaNacimientoVendedor);
            tabVendedor.Controls.Add(textNombreCompletoVendedor);
            tabVendedor.Controls.Add(lblNombreCompletoVendedor);
            tabVendedor.Controls.Add(textIdentificacionVendedor);
            tabVendedor.Controls.Add(lblIdentificacionVendedor);
            tabVendedor.Controls.Add(textIdVendedor);
            tabVendedor.Controls.Add(lblIdVendedor);
            tabVendedor.Location = new Point(4, 29);
            tabVendedor.Name = "tabVendedor";
            tabVendedor.Padding = new Padding(3);
            tabVendedor.Size = new Size(960, 536);
            tabVendedor.TabIndex = 2;
            tabVendedor.Text = "Vendedor";
            tabVendedor.UseVisualStyleBackColor = true;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(233, 280);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(311, 27);
            dtpFechaIngreso.TabIndex = 30;
            // 
            // dtpFechaNacimientoVendedor
            // 
            dtpFechaNacimientoVendedor.Location = new Point(233, 223);
            dtpFechaNacimientoVendedor.Name = "dtpFechaNacimientoVendedor";
            dtpFechaNacimientoVendedor.Size = new Size(311, 27);
            dtpFechaNacimientoVendedor.TabIndex = 29;
            // 
            // btnMostrarVendedor
            // 
            btnMostrarVendedor.Location = new Point(646, 215);
            btnMostrarVendedor.Name = "btnMostrarVendedor";
            btnMostrarVendedor.Size = new Size(175, 46);
            btnMostrarVendedor.TabIndex = 27;
            btnMostrarVendedor.Text = "Mostrar";
            btnMostrarVendedor.UseVisualStyleBackColor = true;
            // 
            // btnAgregarVendedor
            // 
            btnAgregarVendedor.Location = new Point(646, 115);
            btnAgregarVendedor.Name = "btnAgregarVendedor";
            btnAgregarVendedor.Size = new Size(175, 46);
            btnAgregarVendedor.TabIndex = 26;
            btnAgregarVendedor.Text = "Agregar";
            btnAgregarVendedor.UseVisualStyleBackColor = true;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(73, 340);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 25;
            lblTelefono.Text = "Teléfono";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(73, 287);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(127, 20);
            lblFechaIngreso.TabIndex = 24;
            lblFechaIngreso.Text = "Fecha de Registro";
            // 
            // lblFechaNacimientoVendedor
            // 
            lblFechaNacimientoVendedor.AutoSize = true;
            lblFechaNacimientoVendedor.Location = new Point(73, 225);
            lblFechaNacimientoVendedor.Name = "lblFechaNacimientoVendedor";
            lblFechaNacimientoVendedor.Size = new Size(149, 20);
            lblFechaNacimientoVendedor.TabIndex = 23;
            lblFechaNacimientoVendedor.Text = "Fecha de Nacimiento";
            // 
            // textNombreCompletoVendedor
            // 
            textNombreCompletoVendedor.Location = new Point(233, 172);
            textNombreCompletoVendedor.Name = "textNombreCompletoVendedor";
            textNombreCompletoVendedor.Size = new Size(170, 27);
            textNombreCompletoVendedor.TabIndex = 22;
            // 
            // lblNombreCompletoVendedor
            // 
            lblNombreCompletoVendedor.AutoSize = true;
            lblNombreCompletoVendedor.Location = new Point(73, 172);
            lblNombreCompletoVendedor.Name = "lblNombreCompletoVendedor";
            lblNombreCompletoVendedor.Size = new Size(134, 20);
            lblNombreCompletoVendedor.TabIndex = 21;
            lblNombreCompletoVendedor.Text = "Nombre Completo";
            // 
            // textIdentificacionVendedor
            // 
            textIdentificacionVendedor.Location = new Point(233, 115);
            textIdentificacionVendedor.Name = "textIdentificacionVendedor";
            textIdentificacionVendedor.Size = new Size(170, 27);
            textIdentificacionVendedor.TabIndex = 20;
            // 
            // lblIdentificacionVendedor
            // 
            lblIdentificacionVendedor.AutoSize = true;
            lblIdentificacionVendedor.Location = new Point(73, 115);
            lblIdentificacionVendedor.Name = "lblIdentificacionVendedor";
            lblIdentificacionVendedor.Size = new Size(99, 20);
            lblIdentificacionVendedor.TabIndex = 19;
            lblIdentificacionVendedor.Text = "Identificación";
            // 
            // textIdVendedor
            // 
            textIdVendedor.Location = new Point(233, 62);
            textIdVendedor.Name = "textIdVendedor";
            textIdVendedor.Size = new Size(170, 27);
            textIdVendedor.TabIndex = 18;
            textIdVendedor.TextChanged += textBox3_TextChanged;
            // 
            // lblIdVendedor
            // 
            lblIdVendedor.AutoSize = true;
            lblIdVendedor.Location = new Point(73, 62);
            lblIdVendedor.Name = "lblIdVendedor";
            lblIdVendedor.Size = new Size(22, 20);
            lblIdVendedor.TabIndex = 17;
            lblIdVendedor.Text = "Id";
            // 
            // tabVehículo
            // 
            tabVehículo.Controls.Add(comboBox2);
            tabVehículo.Controls.Add(comboBox1);
            tabVehículo.Controls.Add(btnMostrar);
            tabVehículo.Controls.Add(btnAgregarVehiculo);
            tabVehículo.Controls.Add(lblEstado);
            tabVehículo.Controls.Add(lblCategoría);
            tabVehículo.Controls.Add(textBox15);
            tabVehículo.Controls.Add(lblAño);
            tabVehículo.Controls.Add(textModelo);
            tabVehículo.Controls.Add(lblModelo);
            tabVehículo.Controls.Add(textMarca);
            tabVehículo.Controls.Add(lblMarca);
            tabVehículo.Controls.Add(textIdVehiculo);
            tabVehículo.Controls.Add(lblIdVehiculos);
            tabVehículo.Location = new Point(4, 29);
            tabVehículo.Name = "tabVehículo";
            tabVehículo.Padding = new Padding(3);
            tabVehículo.Size = new Size(960, 536);
            tabVehículo.TabIndex = 1;
            tabVehículo.Text = "Vehículo";
            tabVehículo.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(679, 269);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(175, 46);
            btnMostrar.TabIndex = 27;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarVehiculo
            // 
            btnAgregarVehiculo.Location = new Point(679, 169);
            btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            btnAgregarVehiculo.Size = new Size(175, 46);
            btnAgregarVehiculo.TabIndex = 26;
            btnAgregarVehiculo.Text = "Agregar";
            btnAgregarVehiculo.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(106, 362);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(54, 20);
            lblEstado.TabIndex = 24;
            lblEstado.Text = "Estado";
            // 
            // lblCategoría
            // 
            lblCategoría.AutoSize = true;
            lblCategoría.Location = new Point(106, 309);
            lblCategoría.Name = "lblCategoría";
            lblCategoría.Size = new Size(74, 20);
            lblCategoría.TabIndex = 22;
            lblCategoría.Text = "Categoría";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(240, 247);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(170, 27);
            textBox15.TabIndex = 21;
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(106, 247);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(36, 20);
            lblAño.TabIndex = 20;
            lblAño.Text = "Año";
            // 
            // textModelo
            // 
            textModelo.Location = new Point(240, 194);
            textModelo.Name = "textModelo";
            textModelo.Size = new Size(170, 27);
            textModelo.TabIndex = 19;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(106, 194);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(61, 20);
            lblModelo.TabIndex = 18;
            lblModelo.Text = "Modelo";
            // 
            // textMarca
            // 
            textMarca.Location = new Point(240, 137);
            textMarca.Name = "textMarca";
            textMarca.Size = new Size(170, 27);
            textMarca.TabIndex = 17;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(106, 137);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(50, 20);
            lblMarca.TabIndex = 16;
            lblMarca.Text = "Marca";
            // 
            // textIdVehiculo
            // 
            textIdVehiculo.Location = new Point(240, 84);
            textIdVehiculo.Name = "textIdVehiculo";
            textIdVehiculo.Size = new Size(170, 27);
            textIdVehiculo.TabIndex = 15;
            // 
            // lblIdVehiculos
            // 
            lblIdVehiculos.AutoSize = true;
            lblIdVehiculos.Location = new Point(106, 84);
            lblIdVehiculos.Name = "lblIdVehiculos";
            lblIdVehiculos.Size = new Size(22, 20);
            lblIdVehiculos.TabIndex = 14;
            lblIdVehiculos.Text = "Id";
            // 
            // tabSucursal
            // 
            tabSucursal.Controls.Add(checkBox2);
            tabSucursal.Controls.Add(this.btnMostrarSucursal);
            tabSucursal.Controls.Add(this.btnAgregarSucursal);
            tabSucursal.Controls.Add(lblSucursalActiva);
            tabSucursal.Controls.Add(this.textVendedorSucursal);
            tabSucursal.Controls.Add(lblVendedorEncargado);
            tabSucursal.Controls.Add(this.textTelefonoSucursal);
            tabSucursal.Controls.Add(lblTelefonoSucursal);
            tabSucursal.Controls.Add(this.textDireccionSucursal);
            tabSucursal.Controls.Add(lblDireccionSucursal);
            tabSucursal.Controls.Add(this.textNombreSucursal);
            tabSucursal.Controls.Add(lblNombreSucursal);
            tabSucursal.Controls.Add(textIdSucursal);
            tabSucursal.Controls.Add(lblIdSucursal);
            tabSucursal.Location = new Point(4, 29);
            tabSucursal.Name = "tabSucursal";
            tabSucursal.Padding = new Padding(3);
            tabSucursal.Size = new Size(960, 536);
            tabSucursal.TabIndex = 3;
            tabSucursal.Text = "Sucursal";
            tabSucursal.UseVisualStyleBackColor = true;
            // 
            // btnMostrarSucursal
            // 
            this.btnMostrarSucursal.Location = new Point(679, 269);
            this.btnMostrarSucursal.Name = "btnMostrarSucursal";
            this.btnMostrarSucursal.Size = new Size(175, 46);
            this.btnMostrarSucursal.TabIndex = 27;
            this.btnMostrarSucursal.Text = "Mostrar";
            this.btnMostrarSucursal.UseVisualStyleBackColor = true;
            // 
            // btnAgregarSucursal
            // 
            this.btnAgregarSucursal.Location = new Point(679, 169);
            this.btnAgregarSucursal.Name = "btnAgregarSucursal";
            this.btnAgregarSucursal.Size = new Size(175, 46);
            this.btnAgregarSucursal.TabIndex = 26;
            this.btnAgregarSucursal.Text = "Agregar";
            this.btnAgregarSucursal.UseVisualStyleBackColor = true;
            // 
            // lblSucursalActiva
            // 
            lblSucursalActiva.AutoSize = true;
            lblSucursalActiva.Location = new Point(106, 394);
            lblSucursalActiva.Name = "lblSucursalActiva";
            lblSucursalActiva.Size = new Size(108, 20);
            lblSucursalActiva.TabIndex = 24;
            lblSucursalActiva.Text = "Sucursal Activa";
            lblSucursalActiva.Click += label19_Click;
            // 
            // textVendedorSucursal
            // 
            this.textVendedorSucursal.Location = new Point(240, 341);
            this.textVendedorSucursal.Name = "textVendedorSucursal";
            this.textVendedorSucursal.Size = new Size(170, 27);
            this.textVendedorSucursal.TabIndex = 23;
            // 
            // lblVendedorEncargado
            // 
            lblVendedorEncargado.AutoSize = true;
            lblVendedorEncargado.Location = new Point(106, 341);
            lblVendedorEncargado.Name = "lblVendedorEncargado";
            lblVendedorEncargado.Size = new Size(73, 20);
            lblVendedorEncargado.TabIndex = 22;
            lblVendedorEncargado.Text = "Vendedor";
            // 
            // textTelefonoSucursal
            // 
            this.textTelefonoSucursal.Location = new Point(240, 279);
            this.textTelefonoSucursal.Name = "textTelefonoSucursal";
            this.textTelefonoSucursal.Size = new Size(170, 27);
            this.textTelefonoSucursal.TabIndex = 21;
            // 
            // lblTelefonoSucursal
            // 
            lblTelefonoSucursal.AutoSize = true;
            lblTelefonoSucursal.Location = new Point(106, 279);
            lblTelefonoSucursal.Name = "lblTelefonoSucursal";
            lblTelefonoSucursal.Size = new Size(67, 20);
            lblTelefonoSucursal.TabIndex = 20;
            lblTelefonoSucursal.Text = "Telefono";
            // 
            // textDireccionSucursal
            // 
            this.textDireccionSucursal.Location = new Point(240, 226);
            this.textDireccionSucursal.Name = "textDireccionSucursal";
            this.textDireccionSucursal.Size = new Size(170, 27);
            this.textDireccionSucursal.TabIndex = 19;
            // 
            // lblDireccionSucursal
            // 
            lblDireccionSucursal.AutoSize = true;
            lblDireccionSucursal.Location = new Point(106, 226);
            lblDireccionSucursal.Name = "lblDireccionSucursal";
            lblDireccionSucursal.Size = new Size(72, 20);
            lblDireccionSucursal.TabIndex = 18;
            lblDireccionSucursal.Text = "Dirección";
            // 
            // textNombreSucursal
            // 
            this.textNombreSucursal.Location = new Point(240, 169);
            this.textNombreSucursal.Name = "textNombreSucursal";
            this.textNombreSucursal.Size = new Size(170, 27);
            this.textNombreSucursal.TabIndex = 17;
            // 
            // lblNombreSucursal
            // 
            lblNombreSucursal.AutoSize = true;
            lblNombreSucursal.Location = new Point(106, 169);
            lblNombreSucursal.Name = "lblNombreSucursal";
            lblNombreSucursal.Size = new Size(64, 20);
            lblNombreSucursal.TabIndex = 16;
            lblNombreSucursal.Text = "Nombre";
            // 
            // textIdSucursal
            // 
            textIdSucursal.Location = new Point(240, 116);
            textIdSucursal.Name = "textIdSucursal";
            textIdSucursal.Size = new Size(170, 27);
            textIdSucursal.TabIndex = 15;
            // 
            // lblIdSucursal
            // 
            lblIdSucursal.AutoSize = true;
            lblIdSucursal.Location = new Point(106, 116);
            lblIdSucursal.Name = "lblIdSucursal";
            lblIdSucursal.Size = new Size(22, 20);
            lblIdSucursal.TabIndex = 14;
            lblIdSucursal.Text = "Id";
            // 
            // tabVxS
            // 
            tabVxS.Controls.Add(this.btnMostrarVxS);
            tabVxS.Controls.Add(this.btnAgregarVxS);
            tabVxS.Controls.Add(textBox28);
            tabVxS.Controls.Add(this.lblCantidad);
            tabVxS.Controls.Add(textBox29);
            tabVxS.Controls.Add(this.lblVehiculoxS);
            tabVxS.Controls.Add(textBox30);
            tabVxS.Controls.Add(lblSucursalxV);
            tabVxS.Location = new Point(4, 29);
            tabVxS.Name = "tabVxS";
            tabVxS.Size = new Size(960, 536);
            tabVxS.TabIndex = 5;
            tabVxS.Text = "Vehículo por Sucursal";
            tabVxS.UseVisualStyleBackColor = true;
            // 
            // btnMostrarVxS
            // 
            this.btnMostrarVxS.Location = new Point(658, 207);
            this.btnMostrarVxS.Name = "btnMostrarVxS";
            this.btnMostrarVxS.Size = new Size(175, 46);
            this.btnMostrarVxS.TabIndex = 27;
            this.btnMostrarVxS.Text = "Mostrar";
            this.btnMostrarVxS.UseVisualStyleBackColor = true;
            // 
            // btnAgregarVxS
            // 
            this.btnAgregarVxS.Location = new Point(658, 116);
            this.btnAgregarVxS.Name = "btnAgregarVxS";
            this.btnAgregarVxS.Size = new Size(175, 46);
            this.btnAgregarVxS.TabIndex = 26;
            this.btnAgregarVxS.Text = "Agregar";
            this.btnAgregarVxS.UseVisualStyleBackColor = true;
            // 
            // textBox28
            // 
            textBox28.Location = new Point(240, 226);
            textBox28.Name = "textBox28";
            textBox28.Size = new Size(170, 27);
            textBox28.TabIndex = 19;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new Point(106, 226);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new Size(69, 20);
            this.lblCantidad.TabIndex = 18;
            this.lblCantidad.Text = "Cantidad";
            // 
            // textBox29
            // 
            textBox29.Location = new Point(240, 169);
            textBox29.Name = "textBox29";
            textBox29.Size = new Size(170, 27);
            textBox29.TabIndex = 17;
            // 
            // lblVehiculoxS
            // 
            this.lblVehiculoxS.AutoSize = true;
            this.lblVehiculoxS.Location = new Point(106, 169);
            this.lblVehiculoxS.Name = "lblVehiculoxS";
            this.lblVehiculoxS.Size = new Size(65, 20);
            this.lblVehiculoxS.TabIndex = 16;
            this.lblVehiculoxS.Text = "Vehiculo";
            // 
            // textBox30
            // 
            textBox30.Location = new Point(240, 116);
            textBox30.Name = "textBox30";
            textBox30.Size = new Size(170, 27);
            textBox30.TabIndex = 15;
            // 
            // lblSucursalxV
            // 
            lblSucursalxV.AutoSize = true;
            lblSucursalxV.Location = new Point(106, 116);
            lblSucursalxV.Name = "lblSucursalxV";
            lblSucursalxV.Size = new Size(63, 20);
            lblSucursalxV.TabIndex = 14;
            lblSucursalxV.Text = "Sucursal";
            // 
            // textTelefonoVendedor
            // 
            textTelefonoVendedor.Location = new Point(233, 333);
            textTelefonoVendedor.Name = "textTelefonoVendedor";
            textTelefonoVendedor.Size = new Size(170, 27);
            textTelefonoVendedor.TabIndex = 31;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(240, 301);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 28);
            comboBox1.TabIndex = 28;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Nuevo", "Usado" });
            comboBox2.Location = new Point(240, 354);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(170, 28);
            comboBox2.TabIndex = 29;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(240, 394);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 24);
            checkBox2.TabIndex = 28;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 593);
            Controls.Add(tabControl1);
            Name = "FormHome";
            Text = "AutoMarket S.A.";
            tabControl1.ResumeLayout(false);
            tabCliente.ResumeLayout(false);
            tabCliente.PerformLayout();
            tabVendedor.ResumeLayout(false);
            tabVendedor.PerformLayout();
            tabVehículo.ResumeLayout(false);
            tabVehículo.PerformLayout();
            tabSucursal.ResumeLayout(false);
            tabSucursal.PerformLayout();
            tabVxS.ResumeLayout(false);
            tabVxS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabVehículo;
        private TabPage tabVendedor;
        private TabPage tabSucursal;
        private TabPage tabCliente;
        private TabPage tabVxS;
        private TextBox textIdCliente;
        private Label lblIdCliente;
        private Button btnMostrarClientes;
        private Button btnAgregarClientes;
        private Label lblClienteActivo;
        private Label lblFechaRegistro;
        private Label lblFechaNacimientoCliente;
        private TextBox textNombreCompletoCliente;
        private Label lblNombreCompletoCliente;
        private TextBox textIdentificacionCliente;
        private Label lblIdentificacionCliente;
        private Button btnMostrar;
        private Button btnAgregarVehiculo;
        private Label lblEstado;
        private Label lblCategoría;
        private TextBox textBox15;
        private Label lblAño;
        private TextBox textModelo;
        private Label lblModelo;
        private TextBox textMarca;
        private Label lblMarca;
        private TextBox textIdVehiculo;
        private Label lblIdVehiculos;
        private Button button7;
        private Button button8;
        private TextBox textBox19;
        private Label lblSucursalActiva;
        private TextBox textBox20;
        private Label lblVendedorEncargado;
        private TextBox textBox21;
        private Label lblTelefonoSucursal;
        private TextBox textBox22;
        private Label lblDireccionSucursal;
        private TextBox textBox23;
        private Label lblNombreSucursal;
        private TextBox textIdSucursal;
        private Label lblIdSucursal;
        private Button button9;
        private Button button10;
        private TextBox textBox25;
        private Label label25;
        private TextBox textBox26;
        private Label label26;
        private TextBox textBox27;
        private Label label27;
        private TextBox textBox28;
        private Label label28;
        private TextBox textBox29;
        private Label label29;
        private TextBox textBox30;
        private Label lblSucursalxV;
        private CheckBox checkBox1;
        private DateTimePicker dtpFechaRegistro;
        private DateTimePicker dtpFechaNacimientoCliente;
        private DateTimePicker dtpFechaIngreso;
        private DateTimePicker dtpFechaNacimientoVendedor;
        private Button btnMostrarVendedor;
        private Button btnAgregarVendedor;
        private Label lblTelefono;
        private Label lblFechaIngreso;
        private Label lblFechaNacimientoVendedor;
        private TextBox textNombreCompletoVendedor;
        private Label lblNombreCompletoVendedor;
        private TextBox textIdentificacionVendedor;
        private Label lblIdentificacionVendedor;
        private TextBox textIdVendedor;
        private Label lblIdVendedor;
        private TextBox textTelefonoVendedor;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private CheckBox checkBox2;

        // --- Controles que se usan en InitializeComponent pero no estaban declarados ---
        private Button btnMostrarSucursal;
        private Button btnAgregarSucursal;
        private TextBox textVendedorSucursal;
        private TextBox textTelefonoSucursal;
        private TextBox textDireccionSucursal;
        private TextBox textNombreSucursal;

        private Button btnMostrarVxS;
        private Button btnAgregarVxS;
        private Label lblCantidad;
        private Label lblVehiculoxS;
    }
}
