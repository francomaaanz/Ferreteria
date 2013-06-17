namespace Ferreteria.Vista
{
    partial class PedidoParaProveedor
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
            this.listViewPedidoProveedor = new System.Windows.Forms.ListView();
            this.CodigoPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaLlegada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiasDemorados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaHechoPedido = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaLlegadaPedido = new System.Windows.Forms.DateTimePicker();
            this.comboBoxProvRoto = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPedidoProveedor
            // 
            this.listViewPedidoProveedor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodigoPedido,
            this.NombreProveedor,
            this.DiaPedido,
            this.DiaLlegada,
            this.DiasDemorados,
            this.Estado});
            this.listViewPedidoProveedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewPedidoProveedor.FullRowSelect = true;
            this.listViewPedidoProveedor.GridLines = true;
            this.listViewPedidoProveedor.HideSelection = false;
            this.listViewPedidoProveedor.Location = new System.Drawing.Point(0, 147);
            this.listViewPedidoProveedor.Name = "listViewPedidoProveedor";
            this.listViewPedidoProveedor.Size = new System.Drawing.Size(976, 485);
            this.listViewPedidoProveedor.TabIndex = 23;
            this.listViewPedidoProveedor.UseCompatibleStateImageBehavior = false;
            this.listViewPedidoProveedor.View = System.Windows.Forms.View.Details;
            // 
            // CodigoPedido
            // 
            this.CodigoPedido.Text = "Codigo del Pedido";
            this.CodigoPedido.Width = 143;
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.Text = "Nombre del Proveedor";
            this.NombreProveedor.Width = 212;
            // 
            // DiaPedido
            // 
            this.DiaPedido.Text = "Dia del Pedido";
            this.DiaPedido.Width = 116;
            // 
            // DiaLlegada
            // 
            this.DiaLlegada.Text = "Dia de Llegada del Pedido";
            this.DiaLlegada.Width = 137;
            // 
            // DiasDemorados
            // 
            this.DiasDemorados.Text = "Dias Demorados en llegar el Pedido";
            this.DiasDemorados.Width = 193;
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            this.Estado.Width = 149;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxProvRoto);
            this.panel1.Controls.Add(this.dateTimePickerFechaLlegadaPedido);
            this.panel1.Controls.Add(this.dateTimePickerFechaHechoPedido);
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(this.buttonGuardar);
            this.panel1.Controls.Add(this.comboBoxEstado);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 147);
            this.panel1.TabIndex = 24;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(311, 114);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar Pedido";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(186, 114);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar Pedido";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Pedido Hecho",
            "Pedido En camino",
            "El pedido Llego"});
            this.comboBoxEstado.Location = new System.Drawing.Point(186, 87);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(200, 21);
            this.comboBoxEstado.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado Del Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dia de Llegada del Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dia del Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Del Proveedor";
            // 
            // dateTimePickerFechaHechoPedido
            // 
            this.dateTimePickerFechaHechoPedido.Location = new System.Drawing.Point(186, 32);
            this.dateTimePickerFechaHechoPedido.Name = "dateTimePickerFechaHechoPedido";
            this.dateTimePickerFechaHechoPedido.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaHechoPedido.TabIndex = 10;
            // 
            // dateTimePickerFechaLlegadaPedido
            // 
            this.dateTimePickerFechaLlegadaPedido.Location = new System.Drawing.Point(186, 58);
            this.dateTimePickerFechaLlegadaPedido.Name = "dateTimePickerFechaLlegadaPedido";
            this.dateTimePickerFechaLlegadaPedido.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaLlegadaPedido.TabIndex = 11;
            // 
            // comboBoxProvRoto
            // 
            this.comboBoxProvRoto.FormattingEnabled = true;
            this.comboBoxProvRoto.Location = new System.Drawing.Point(186, 5);
            this.comboBoxProvRoto.Name = "comboBoxProvRoto";
            this.comboBoxProvRoto.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProvRoto.TabIndex = 12;
            this.comboBoxProvRoto.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvRoto_SelectedIndexChanged);
            // 
            // PedidoParaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewPedidoProveedor);
            this.Name = "PedidoParaProveedor";
            this.Text = "Pedido a Proveedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPedidoProveedor;
        private System.Windows.Forms.ColumnHeader CodigoPedido;
        private System.Windows.Forms.ColumnHeader NombreProveedor;
        private System.Windows.Forms.ColumnHeader DiaPedido;
        private System.Windows.Forms.ColumnHeader DiaLlegada;
        private System.Windows.Forms.ColumnHeader DiasDemorados;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaLlegadaPedido;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaHechoPedido;
        private System.Windows.Forms.ComboBox comboBoxProvRoto;
    }
}