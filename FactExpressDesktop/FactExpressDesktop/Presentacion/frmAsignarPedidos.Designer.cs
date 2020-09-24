namespace FactExpressDesktop.Presentacion
{
    partial class frmAsignarPedidos
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvPedidosPendientes = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.btnAsignarPedido = new System.Windows.Forms.Button();
            this.txtLugarEntrega = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpFechaOrden = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigoPedido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalDescuento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarNuevo = new System.Windows.Forms.Button();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbbBuscarPor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvOperadores = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNombreOperador = new System.Windows.Forms.TextBox();
            this.labeldni = new System.Windows.Forms.Label();
            this.txtCodigoOperador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnQuitarDeLista = new System.Windows.Forms.Button();
            this.dgvPedidosAsignados = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRefrescarLista = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosPendientes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperadores)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosAsignados)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRefrescarLista);
            this.groupBox5.Controls.Add(this.dgvPedidosPendientes);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox5.Location = new System.Drawing.Point(14, 474);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(832, 361);
            this.groupBox5.TabIndex = 133;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Lista de Pedidos Pendientes";
            // 
            // dgvPedidosPendientes
            // 
            this.dgvPedidosPendientes.AllowUserToAddRows = false;
            this.dgvPedidosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosPendientes.Location = new System.Drawing.Point(9, 67);
            this.dgvPedidosPendientes.MultiSelect = false;
            this.dgvPedidosPendientes.Name = "dgvPedidosPendientes";
            this.dgvPedidosPendientes.ReadOnly = true;
            this.dgvPedidosPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidosPendientes.Size = new System.Drawing.Size(809, 279);
            this.dgvPedidosPendientes.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnVerDetalles);
            this.groupBox3.Controls.Add(this.btnAsignarPedido);
            this.groupBox3.Controls.Add(this.txtLugarEntrega);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtNombreCliente);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbbEstado);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.dtpFechaOrden);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtCodigoPedido);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSubTotal);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtComentario);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dtpFechaEntrega);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTotalDescuento);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(12, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(867, 333);
            this.groupBox3.TabIndex = 132;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asignacion De Pedidos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(370, 26);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 51);
            this.btnCancelar.TabIndex = 138;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerDetalles.Enabled = false;
            this.btnVerDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerDetalles.Location = new System.Drawing.Point(190, 25);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(141, 51);
            this.btnVerDetalles.TabIndex = 137;
            this.btnVerDetalles.Text = "Ver Detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = false;
            // 
            // btnAsignarPedido
            // 
            this.btnAsignarPedido.BackColor = System.Drawing.SystemColors.Control;
            this.btnAsignarPedido.Enabled = false;
            this.btnAsignarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAsignarPedido.Location = new System.Drawing.Point(13, 25);
            this.btnAsignarPedido.Name = "btnAsignarPedido";
            this.btnAsignarPedido.Size = new System.Drawing.Size(141, 51);
            this.btnAsignarPedido.TabIndex = 106;
            this.btnAsignarPedido.Text = "Asignar Pedido";
            this.btnAsignarPedido.UseVisualStyleBackColor = false;
            // 
            // txtLugarEntrega
            // 
            this.txtLugarEntrega.Enabled = false;
            this.txtLugarEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugarEntrega.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLugarEntrega.Location = new System.Drawing.Point(141, 230);
            this.txtLugarEntrega.Name = "txtLugarEntrega";
            this.txtLugarEntrega.Size = new System.Drawing.Size(333, 22);
            this.txtLugarEntrega.TabIndex = 136;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(8, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 135;
            this.label7.Text = "Lugar de Entrega";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombreCliente.Location = new System.Drawing.Point(141, 199);
            this.txtNombreCliente.MaxLength = 50;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(278, 21);
            this.txtNombreCliente.TabIndex = 134;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(4, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 133;
            this.label3.Text = "Nombre del Cliente";
            // 
            // cbbEstado
            // 
            this.cbbEstado.Enabled = false;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(697, 26);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(156, 23);
            this.cbbEstado.TabIndex = 132;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(633, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 15);
            this.label17.TabIndex = 131;
            this.label17.Text = "Estado:";
            // 
            // dtpFechaOrden
            // 
            this.dtpFechaOrden.Enabled = false;
            this.dtpFechaOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaOrden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaOrden.Location = new System.Drawing.Point(141, 160);
            this.dtpFechaOrden.Name = "dtpFechaOrden";
            this.dtpFechaOrden.Size = new System.Drawing.Size(133, 21);
            this.dtpFechaOrden.TabIndex = 128;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(26, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 15);
            this.label10.TabIndex = 127;
            this.label10.Text = "Fecha de Orden";
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.Enabled = false;
            this.txtCodigoPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodigoPedido.Location = new System.Drawing.Point(141, 124);
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.Size = new System.Drawing.Size(122, 21);
            this.txtCodigoPedido.TabIndex = 126;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(49, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 125;
            this.label6.Text = "Cod-Pedido:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSubTotal.Location = new System.Drawing.Point(661, 214);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(183, 22);
            this.txtSubTotal.TabIndex = 116;
            this.txtSubTotal.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(585, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 115;
            this.label5.Text = "SubTotal";
            // 
            // txtComentario
            // 
            this.txtComentario.Enabled = false;
            this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtComentario.Location = new System.Drawing.Point(141, 269);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(327, 44);
            this.txtComentario.TabIndex = 113;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(41, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 112;
            this.label11.Text = "Comentario:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotal.Location = new System.Drawing.Point(661, 285);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(183, 22);
            this.txtTotal.TabIndex = 109;
            this.txtTotal.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(603, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 108;
            this.label8.Text = "Total";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Enabled = false;
            this.dtpFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(419, 155);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(133, 21);
            this.dtpFechaEntrega.TabIndex = 124;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(298, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 116;
            this.label4.Text = "Fecha de Entega";
            // 
            // txtTotalDescuento
            // 
            this.txtTotalDescuento.Enabled = false;
            this.txtTotalDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDescuento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalDescuento.Location = new System.Drawing.Point(661, 247);
            this.txtTotalDescuento.Name = "txtTotalDescuento";
            this.txtTotalDescuento.Size = new System.Drawing.Size(183, 22);
            this.txtTotalDescuento.TabIndex = 95;
            this.txtTotalDescuento.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(537, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 94;
            this.label2.Text = "Total Descuento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarNuevo);
            this.groupBox1.Controls.Add(this.btnVerTodos);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.cbbBuscarPor);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dgvOperadores);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(21, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 351);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Operadores";
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarNuevo.Enabled = false;
            this.btnAgregarNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarNuevo.Location = new System.Drawing.Point(432, 131);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(99, 49);
            this.btnAgregarNuevo.TabIndex = 95;
            this.btnAgregarNuevo.Text = "Agregar Nuevo";
            this.btnAgregarNuevo.UseVisualStyleBackColor = false;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerTodos.Enabled = false;
            this.btnVerTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerTodos.Location = new System.Drawing.Point(432, 61);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(99, 49);
            this.btnVerTodos.TabIndex = 94;
            this.btnVerTodos.Text = "Ver Totos";
            this.btnVerTodos.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscar.Location = new System.Drawing.Point(262, 23);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(222, 21);
            this.txtBuscar.TabIndex = 92;
            // 
            // cbbBuscarPor
            // 
            this.cbbBuscarPor.FormattingEnabled = true;
            this.cbbBuscarPor.Items.AddRange(new object[] {
            "Todos",
            "Nombre",
            "Codigo"});
            this.cbbBuscarPor.Location = new System.Drawing.Point(79, 23);
            this.cbbBuscarPor.Name = "cbbBuscarPor";
            this.cbbBuscarPor.Size = new System.Drawing.Size(160, 23);
            this.cbbBuscarPor.TabIndex = 91;
            this.cbbBuscarPor.Text = "Todos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(14, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 90;
            this.label9.Text = "Buscar: ";
            // 
            // dgvOperadores
            // 
            this.dgvOperadores.AllowUserToAddRows = false;
            this.dgvOperadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperadores.Location = new System.Drawing.Point(17, 61);
            this.dgvOperadores.MultiSelect = false;
            this.dgvOperadores.Name = "dgvOperadores";
            this.dgvOperadores.ReadOnly = true;
            this.dgvOperadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperadores.Size = new System.Drawing.Size(409, 272);
            this.dgvOperadores.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNombreOperador);
            this.groupBox2.Controls.Add(this.labeldni);
            this.groupBox2.Controls.Add(this.txtCodigoOperador);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(281, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 96);
            this.groupBox2.TabIndex = 134;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Del Operador";
            // 
            // txtNombreOperador
            // 
            this.txtNombreOperador.Enabled = false;
            this.txtNombreOperador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombreOperador.Location = new System.Drawing.Point(341, 42);
            this.txtNombreOperador.MaxLength = 50;
            this.txtNombreOperador.Name = "txtNombreOperador";
            this.txtNombreOperador.Size = new System.Drawing.Size(239, 21);
            this.txtNombreOperador.TabIndex = 4;
            // 
            // labeldni
            // 
            this.labeldni.AutoSize = true;
            this.labeldni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labeldni.Location = new System.Drawing.Point(264, 45);
            this.labeldni.Name = "labeldni";
            this.labeldni.Size = new System.Drawing.Size(58, 15);
            this.labeldni.TabIndex = 2;
            this.labeldni.Text = "Nombre";
            // 
            // txtCodigoOperador
            // 
            this.txtCodigoOperador.Enabled = false;
            this.txtCodigoOperador.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigoOperador.Location = new System.Drawing.Point(111, 39);
            this.txtCodigoOperador.Name = "txtCodigoOperador";
            this.txtCodigoOperador.Size = new System.Drawing.Size(90, 21);
            this.txtCodigoOperador.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cod-Operador";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnQuitarDeLista);
            this.groupBox4.Controls.Add(this.dgvPedidosAsignados);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(21, 390);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(547, 365);
            this.groupBox4.TabIndex = 135;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pedidos Asignados";
            // 
            // btnQuitarDeLista
            // 
            this.btnQuitarDeLista.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuitarDeLista.Enabled = false;
            this.btnQuitarDeLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarDeLista.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuitarDeLista.Location = new System.Drawing.Point(17, 28);
            this.btnQuitarDeLista.Name = "btnQuitarDeLista";
            this.btnQuitarDeLista.Size = new System.Drawing.Size(141, 34);
            this.btnQuitarDeLista.TabIndex = 95;
            this.btnQuitarDeLista.Text = "Quitar de Lista";
            this.btnQuitarDeLista.UseVisualStyleBackColor = false;
            // 
            // dgvPedidosAsignados
            // 
            this.dgvPedidosAsignados.AllowUserToAddRows = false;
            this.dgvPedidosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosAsignados.Location = new System.Drawing.Point(17, 71);
            this.dgvPedidosAsignados.MultiSelect = false;
            this.dgvPedidosAsignados.Name = "dgvPedidosAsignados";
            this.dgvPedidosAsignados.ReadOnly = true;
            this.dgvPedidosAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidosAsignados.Size = new System.Drawing.Size(512, 279);
            this.dgvPedidosAsignados.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox6.Location = new System.Drawing.Point(898, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(594, 786);
            this.groupBox6.TabIndex = 136;
            this.groupBox6.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevo.Location = new System.Drawing.Point(25, 13);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(141, 51);
            this.btnNuevo.TabIndex = 139;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnRefrescarLista
            // 
            this.btnRefrescarLista.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefrescarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescarLista.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefrescarLista.Location = new System.Drawing.Point(9, 28);
            this.btnRefrescarLista.Name = "btnRefrescarLista";
            this.btnRefrescarLista.Size = new System.Drawing.Size(141, 33);
            this.btnRefrescarLista.TabIndex = 136;
            this.btnRefrescarLista.Text = "Refrescar Lista";
            this.btnRefrescarLista.UseVisualStyleBackColor = false;
            // 
            // frmAsignarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 847);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmAsignarPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAsignarPedidos_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosPendientes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperadores)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosAsignados)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvPedidosPendientes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpFechaOrden;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigoPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalDescuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOperadores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNombreOperador;
        private System.Windows.Forms.Label labeldni;
        private System.Windows.Forms.TextBox txtCodigoOperador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvPedidosAsignados;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLugarEntrega;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbBuscarPor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAgregarNuevo;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnAsignarPedido;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.Button btnQuitarDeLista;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRefrescarLista;
    }
}