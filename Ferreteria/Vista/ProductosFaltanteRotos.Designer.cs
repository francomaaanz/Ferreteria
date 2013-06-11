namespace Ferreteria.Vista
{
    partial class ProductosFaltanteRotos
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
            this.listViewProductoFaltantesRotos = new System.Windows.Forms.ListView();
            this.CodigoProductoProductoFaltante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Detalle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetalleProdRoto = new System.Windows.Forms.TextBox();
            this.comboBoxProvRoto = new System.Windows.Forms.ComboBox();
            this.txtNomProdRoto = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProductoFaltantesRotos
            // 
            this.listViewProductoFaltantesRotos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodigoProductoProductoFaltante,
            this.NombreProducto,
            this.NombreProveedor,
            this.Detalle});
            this.listViewProductoFaltantesRotos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewProductoFaltantesRotos.FullRowSelect = true;
            this.listViewProductoFaltantesRotos.GridLines = true;
            this.listViewProductoFaltantesRotos.HideSelection = false;
            this.listViewProductoFaltantesRotos.Location = new System.Drawing.Point(0, 125);
            this.listViewProductoFaltantesRotos.Name = "listViewProductoFaltantesRotos";
            this.listViewProductoFaltantesRotos.Size = new System.Drawing.Size(673, 487);
            this.listViewProductoFaltantesRotos.TabIndex = 23;
            this.listViewProductoFaltantesRotos.UseCompatibleStateImageBehavior = false;
            this.listViewProductoFaltantesRotos.View = System.Windows.Forms.View.Details;
            this.listViewProductoFaltantesRotos.SelectedIndexChanged += new System.EventHandler(this.listViewProductoFaltantesRotos_SelectedIndexChanged);
            // 
            // CodigoProductoProductoFaltante
            // 
            this.CodigoProductoProductoFaltante.Text = "Nuevo Codigo del Producto Faltante o Roto";
            this.CodigoProductoProductoFaltante.Width = 143;
            // 
            // NombreProducto
            // 
            this.NombreProducto.Text = "Nombre del Producto";
            this.NombreProducto.Width = 213;
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.Text = "Nombre del Proveedor";
            this.NombreProveedor.Width = 148;
            // 
            // Detalle
            // 
            this.Detalle.Text = "Detalle";
            this.Detalle.Width = 187;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAgregar);
            this.panel1.Controls.Add(this.buttonBuscar);
            this.panel1.Controls.Add(this.txtNomProdRoto);
            this.panel1.Controls.Add(this.comboBoxProvRoto);
            this.panel1.Controls.Add(this.txtDetalleProdRoto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 125);
            this.panel1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Producto";
            // 
            // txtDetalleProdRoto
            // 
            this.txtDetalleProdRoto.Location = new System.Drawing.Point(80, 69);
            this.txtDetalleProdRoto.Name = "txtDetalleProdRoto";
            this.txtDetalleProdRoto.Size = new System.Drawing.Size(557, 20);
            this.txtDetalleProdRoto.TabIndex = 3;
            // 
            // comboBoxProvRoto
            // 
            this.comboBoxProvRoto.FormattingEnabled = true;
            this.comboBoxProvRoto.Location = new System.Drawing.Point(153, 41);
            this.comboBoxProvRoto.Name = "comboBoxProvRoto";
            this.comboBoxProvRoto.Size = new System.Drawing.Size(484, 21);
            this.comboBoxProvRoto.TabIndex = 4;
            this.comboBoxProvRoto.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvRoto_SelectedIndexChanged);
            // 
            // txtNomProdRoto
            // 
            this.txtNomProdRoto.Location = new System.Drawing.Point(153, 10);
            this.txtNomProdRoto.Name = "txtNomProdRoto";
            this.txtNomProdRoto.Size = new System.Drawing.Size(100, 20);
            this.txtNomProdRoto.TabIndex = 5;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(259, 10);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(80, 95);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 7;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // ProductosFaltanteRotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewProductoFaltantesRotos);
            this.Name = "ProductosFaltanteRotos";
            this.Text = "Productos Faltantes o Rotos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewProductoFaltantesRotos;
        private System.Windows.Forms.ColumnHeader CodigoProductoProductoFaltante;
        private System.Windows.Forms.ColumnHeader NombreProducto;
        private System.Windows.Forms.ColumnHeader NombreProveedor;
        private System.Windows.Forms.ColumnHeader Detalle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetalleProdRoto;
        private System.Windows.Forms.TextBox txtNomProdRoto;
        private System.Windows.Forms.ComboBox comboBoxProvRoto;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAgregar;
    }
}