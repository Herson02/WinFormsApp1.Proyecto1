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
            lblNombre = new Label();
            textNombre = new TextBox();
            textEdad = new TextBox();
            lblEdad = new Label();
            textIdentificacion = new TextBox();
            lblIdentificacion = new Label();
            lblResidencia = new Label();
            comboBox1 = new ComboBox();
            btnAgregar = new Button();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(45, 55);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(153, 55);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(159, 27);
            textNombre.TabIndex = 1;
            // 
            // textEdad
            // 
            textEdad.Location = new Point(153, 106);
            textEdad.Name = "textEdad";
            textEdad.Size = new Size(159, 27);
            textEdad.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(45, 106);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // textIdentificacion
            // 
            textIdentificacion.Location = new Point(153, 158);
            textIdentificacion.Name = "textIdentificacion";
            textIdentificacion.Size = new Size(159, 27);
            textIdentificacion.TabIndex = 5;
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(45, 158);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(99, 20);
            lblIdentificacion.TabIndex = 4;
            lblIdentificacion.Text = "Identificacion";
            // 
            // lblResidencia
            // 
            lblResidencia.AutoSize = true;
            lblResidencia.Location = new Point(45, 220);
            lblResidencia.Name = "lblResidencia";
            lblResidencia.Size = new Size(80, 20);
            lblResidencia.TabIndex = 6;
            lblResidencia.Text = "Residencia";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Costa Rica ", "United States", "Brasil" });
            comboBox1.Location = new Point(153, 220);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 28);
            comboBox1.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(589, 158);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 27);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(589, 213);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(96, 27);
            btnMostrar.TabIndex = 9;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrar);
            Controls.Add(btnAgregar);
            Controls.Add(comboBox1);
            Controls.Add(lblResidencia);
            Controls.Add(textIdentificacion);
            Controls.Add(lblIdentificacion);
            Controls.Add(textEdad);
            Controls.Add(lblEdad);
            Controls.Add(textNombre);
            Controls.Add(lblNombre);
            Name = "FormHome";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox textNombre;
        private TextBox textEdad;
        private Label lblEdad;
        private TextBox textIdentificacion;
        private Label lblIdentificacion;
        private Label lblResidencia;
        private ComboBox comboBox1;
        private Button btnAgregar;
        private Button btnMostrar;
    }
}
