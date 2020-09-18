namespace FactExpressDesktop.Presentacion
{
    partial class frmEmpresa
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefrescarLista = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBoxcargando = new System.Windows.Forms.GroupBox();
            this.p1 = new System.Windows.Forms.ProgressBar();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btbcancelar = new System.Windows.Forms.Button();
            this.txtRNC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.labeldni = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscformSector = new System.Windows.Forms.Button();
            this.cbbSector = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbProvincia = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscformProvincias = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxcargando.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(521, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "EMPRESA LOCAL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefrescarLista);
            this.groupBox1.Controls.Add(this.dgvEmpresa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(597, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 535);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empresa";
            // 
            // btnRefrescarLista
            // 
            this.btnRefrescarLista.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefrescarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescarLista.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefrescarLista.Location = new System.Drawing.Point(13, 38);
            this.btnRefrescarLista.Name = "btnRefrescarLista";
            this.btnRefrescarLista.Size = new System.Drawing.Size(143, 30);
            this.btnRefrescarLista.TabIndex = 90;
            this.btnRefrescarLista.Text = "Refrescar Lista";
            this.btnRefrescarLista.UseVisualStyleBackColor = false;
            this.btnRefrescarLista.Click += new System.EventHandler(this.btnRefrescarLista_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(376, 520);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 39);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.AllowUserToAddRows = false;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Location = new System.Drawing.Point(13, 84);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.ReadOnly = true;
            this.dgvEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpresa.Size = new System.Drawing.Size(610, 433);
            this.dgvEmpresa.TabIndex = 0;
            this.dgvEmpresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresa_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbProvincia);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnBuscformProvincias);
            this.groupBox2.Controls.Add(this.btnBuscformSector);
            this.groupBox2.Controls.Add(this.cbbSector);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCorreo);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnnuevo);
            this.groupBox2.Controls.Add(this.btbcancelar);
            this.groupBox2.Controls.Add(this.txtRNC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.txtNombreEmpresa);
            this.groupBox2.Controls.Add(this.labeldni);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(24, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 576);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Empresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(16, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 86;
            this.label6.Text = "Correo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Location = new System.Drawing.Point(16, 520);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 39);
            this.btnGuardar.TabIndex = 85;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBoxcargando
            // 
            this.groupBoxcargando.Controls.Add(this.p1);
            this.groupBoxcargando.Location = new System.Drawing.Point(1135, 17);
            this.groupBoxcargando.Name = "groupBoxcargando";
            this.groupBoxcargando.Size = new System.Drawing.Size(123, 32);
            this.groupBoxcargando.TabIndex = 84;
            this.groupBoxcargando.TabStop = false;
            this.groupBoxcargando.Visible = false;
            // 
            // p1
            // 
            this.p1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.p1.Location = new System.Drawing.Point(6, 10);
            this.p1.Maximum = 150;
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(106, 12);
            this.p1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.p1.TabIndex = 9;
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnnuevo.Location = new System.Drawing.Point(17, 520);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(95, 39);
            this.btnnuevo.TabIndex = 8;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btbcancelar
            // 
            this.btbcancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btbcancelar.Enabled = false;
            this.btbcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbcancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btbcancelar.Location = new System.Drawing.Point(252, 520);
            this.btbcancelar.Name = "btbcancelar";
            this.btbcancelar.Size = new System.Drawing.Size(99, 39);
            this.btbcancelar.TabIndex = 6;
            this.btbcancelar.Text = "Cancelar";
            this.btbcancelar.UseVisualStyleBackColor = false;
            this.btbcancelar.Click += new System.EventHandler(this.btbcancelar_Click);
            // 
            // txtRNC
            // 
            this.txtRNC.Enabled = false;
            this.txtRNC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRNC.Location = new System.Drawing.Point(70, 153);
            this.txtRNC.MaxLength = 50;
            this.txtRNC.Name = "txtRNC";
            this.txtRNC.Size = new System.Drawing.Size(242, 21);
            this.txtRNC.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(16, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "RNC";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditar.Location = new System.Drawing.Point(135, 520);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 39);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Enabled = false;
            this.txtNombreEmpresa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombreEmpresa.Location = new System.Drawing.Point(169, 97);
            this.txtNombreEmpresa.MaxLength = 50;
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(382, 21);
            this.txtNombreEmpresa.TabIndex = 1;
            // 
            // labeldni
            // 
            this.labeldni.AutoSize = true;
            this.labeldni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labeldni.Location = new System.Drawing.Point(1, 100);
            this.labeldni.Name = "labeldni";
            this.labeldni.Size = new System.Drawing.Size(155, 15);
            this.labeldni.TabIndex = 0;
            this.labeldni.Text = "Nombre de la Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(16, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefono";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigo.Location = new System.Drawing.Point(78, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(90, 21);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefono.Location = new System.Drawing.Point(90, 219);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(188, 21);
            this.txtTelefono.TabIndex = 88;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCorreo.Location = new System.Drawing.Point(72, 273);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(344, 21);
            this.txtCorreo.TabIndex = 89;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDireccion.Location = new System.Drawing.Point(90, 329);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(326, 21);
            this.txtDireccion.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(16, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 90;
            this.label8.Text = "Direccion";
            // 
            // btnBuscformSector
            // 
            this.btnBuscformSector.Location = new System.Drawing.Point(291, 389);
            this.btnBuscformSector.Name = "btnBuscformSector";
            this.btnBuscformSector.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscformSector.Size = new System.Drawing.Size(43, 23);
            this.btnBuscformSector.TabIndex = 101;
            this.btnBuscformSector.Text = "...";
            this.btnBuscformSector.UseVisualStyleBackColor = true;
            this.btnBuscformSector.Click += new System.EventHandler(this.btnBuscformSector_Click);
            // 
            // cbbSector
            // 
            this.cbbSector.Enabled = false;
            this.cbbSector.FormattingEnabled = true;
            this.cbbSector.Location = new System.Drawing.Point(72, 389);
            this.cbbSector.Name = "cbbSector";
            this.cbbSector.Size = new System.Drawing.Size(201, 23);
            this.cbbSector.TabIndex = 100;
            this.cbbSector.Click += new System.EventHandler(this.cbbSector_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(18, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 99;
            this.label9.Text = "Sector";
            // 
            // cbbProvincia
            // 
            this.cbbProvincia.Enabled = false;
            this.cbbProvincia.FormattingEnabled = true;
            this.cbbProvincia.Location = new System.Drawing.Point(94, 447);
            this.cbbProvincia.Name = "cbbProvincia";
            this.cbbProvincia.Size = new System.Drawing.Size(201, 23);
            this.cbbProvincia.TabIndex = 104;
            this.cbbProvincia.Click += new System.EventHandler(this.cbbProvincia_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(13, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 103;
            this.label10.Text = "Provincia";
            // 
            // btnBuscformProvincias
            // 
            this.btnBuscformProvincias.Location = new System.Drawing.Point(317, 447);
            this.btnBuscformProvincias.Name = "btnBuscformProvincias";
            this.btnBuscformProvincias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscformProvincias.Size = new System.Drawing.Size(43, 23);
            this.btnBuscformProvincias.TabIndex = 102;
            this.btnBuscformProvincias.Text = "...";
            this.btnBuscformProvincias.UseVisualStyleBackColor = true;
            this.btnBuscformProvincias.Click += new System.EventHandler(this.btnBuscformProvincias_Click);
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 689);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxcargando);
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxcargando.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefrescarLista;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btbcancelar;
        private System.Windows.Forms.TextBox txtRNC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label labeldni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxcargando;
        private System.Windows.Forms.ProgressBar p1;
        private System.Windows.Forms.Button btnBuscformSector;
        private System.Windows.Forms.ComboBox cbbSector;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbProvincia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscformProvincias;
    }
}