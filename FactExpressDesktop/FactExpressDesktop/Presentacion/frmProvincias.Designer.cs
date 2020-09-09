namespace FactExpressDesktop.Presentacion
{
    partial class frmProvincias
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvProvincias = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBoxcargando = new System.Windows.Forms.GroupBox();
            this.p1 = new System.Windows.Forms.ProgressBar();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btbcancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNombreProvincia = new System.Windows.Forms.TextBox();
            this.labeldni = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincias)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxcargando.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "REGISTRO DE PROVINCIAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.dgvProvincias);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(454, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 473);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Provincias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(20, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Digite Nombre:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(362, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 30);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(13, 413);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 39);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscar.Location = new System.Drawing.Point(139, 40);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(188, 21);
            this.txtBuscar.TabIndex = 24;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvProvincias
            // 
            this.dgvProvincias.AllowUserToAddRows = false;
            this.dgvProvincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvincias.Location = new System.Drawing.Point(13, 88);
            this.dgvProvincias.Name = "dgvProvincias";
            this.dgvProvincias.ReadOnly = true;
            this.dgvProvincias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvincias.Size = new System.Drawing.Size(461, 298);
            this.dgvProvincias.TabIndex = 0;
            this.dgvProvincias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProvincias_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.groupBoxcargando);
            this.groupBox2.Controls.Add(this.btnnuevo);
            this.groupBox2.Controls.Add(this.btbcancelar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.txtNombreProvincia);
            this.groupBox2.Controls.Add(this.labeldni);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 317);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Provincia";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Location = new System.Drawing.Point(27, 220);
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
            this.groupBoxcargando.Location = new System.Drawing.Point(369, 175);
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
            this.btnnuevo.Location = new System.Drawing.Point(27, 220);
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
            this.btbcancelar.Location = new System.Drawing.Point(262, 220);
            this.btbcancelar.Name = "btbcancelar";
            this.btbcancelar.Size = new System.Drawing.Size(99, 39);
            this.btbcancelar.TabIndex = 6;
            this.btbcancelar.Text = "Cancelar";
            this.btbcancelar.UseVisualStyleBackColor = false;
            this.btbcancelar.Click += new System.EventHandler(this.btbcancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditar.Location = new System.Drawing.Point(145, 220);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 39);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNombreProvincia
            // 
            this.txtNombreProvincia.Enabled = false;
            this.txtNombreProvincia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombreProvincia.Location = new System.Drawing.Point(148, 97);
            this.txtNombreProvincia.MaxLength = 50;
            this.txtNombreProvincia.Name = "txtNombreProvincia";
            this.txtNombreProvincia.Size = new System.Drawing.Size(240, 21);
            this.txtNombreProvincia.TabIndex = 1;
            // 
            // labeldni
            // 
            this.labeldni.AutoSize = true;
            this.labeldni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labeldni.Location = new System.Drawing.Point(1, 100);
            this.labeldni.Name = "labeldni";
            this.labeldni.Size = new System.Drawing.Size(141, 15);
            this.labeldni.TabIndex = 0;
            this.labeldni.Text = "Nombre de Provincia";
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
            // frmProvincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 585);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmProvincias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provincias";
            this.Load += new System.EventHandler(this.frmProvincias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincias)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxcargando.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvProvincias;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBoxcargando;
        private System.Windows.Forms.ProgressBar p1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btbcancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtNombreProvincia;
        private System.Windows.Forms.Label labeldni;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
    }
}