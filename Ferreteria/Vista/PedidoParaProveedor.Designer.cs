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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtDiaLlegadaPedido = new System.Windows.Forms.TextBox();
            this.txtDiaPedido = new System.Windows.Forms.TextBox();
            this.txtNombreDelProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(this.buttonGuardar);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtDiaLlegadaPedido);
            this.panel1.Controls.Add(this.txtDiaPedido);
            this.panel1.Controls.Add(this.txtNombreDelProveedor);
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
            this.buttonCancelar.Location = new System.Drawing.Point(469, 61);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar Pedido";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(371, 61);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar Pedido";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pedido Hecho",
            "Pedido En camino",
            "El pedido Llego"});
            this.comboBox1.Location = new System.Drawing.Point(186, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // txtDiaLlegadaPedido
            // 
            this.txtDiaLlegadaPedido.Location = new System.Drawing.Point(186, 61);
            this.txtDiaLlegadaPedido.Name = "txtDiaLlegadaPedido";
            this.txtDiaLlegadaPedido.Size = new System.Drawing.Size(131, 20);
            this.txtDiaLlegadaPedido.TabIndex = 6;
            // 
            // txtDiaPedido
            // 
            this.txtDiaPedido.Location = new System.Drawing.Point(186, 35);
            this.txtDiaPedido.Name = "txtDiaPedido";
            this.txtDiaPedido.Size = new System.Drawing.Size(131, 20);
            this.txtDiaPedido.TabIndex = 5;
            // 
            // txtNombreDelProveedor
            // 
            this.txtNombreDelProveedor.Location = new System.Drawing.Point(186, 9);
            this.txtNombreDelProveedor.Name = "txtNombreDelProveedor";
            this.txtNombreDelProveedor.Size = new System.Drawing.Size(131, 20);
            this.txtNombreDelProveedor.TabIndex = 4;
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
        private System.Windows.Forms.TextBox txtDiaLlegadaPedido;
        private System.Windows.Forms.TextBox txtDiaPedido;
        private System.Windows.Forms.TextBox txtNombreDelProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
    }
}