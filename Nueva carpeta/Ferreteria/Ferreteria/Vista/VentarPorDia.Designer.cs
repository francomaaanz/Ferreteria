namespace Ferreteria.Vista
{
    partial class VentarPorDia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewVentasPorDia = new System.Windows.Forms.ListView();
            this.IDVentaPorDia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Monto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaMontoDelDia = new System.Windows.Forms.DateTimePicker();
            this.txtMontoDelDia = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(this.buttonGuardar);
            this.panel1.Controls.Add(this.txtMontoDelDia);
            this.panel1.Controls.Add(this.dateTimePickerFechaMontoDelDia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 96);
            this.panel1.TabIndex = 0;
            // 
            // listViewVentasPorDia
            // 
            this.listViewVentasPorDia.BackColor = System.Drawing.SystemColors.Window;
            this.listViewVentasPorDia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDVentaPorDia,
            this.Monto,
            this.Fecha});
            this.listViewVentasPorDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewVentasPorDia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewVentasPorDia.GridLines = true;
            this.listViewVentasPorDia.Location = new System.Drawing.Point(0, 96);
            this.listViewVentasPorDia.Name = "listViewVentasPorDia";
            this.listViewVentasPorDia.Size = new System.Drawing.Size(437, 263);
            this.listViewVentasPorDia.TabIndex = 1;
            this.listViewVentasPorDia.UseCompatibleStateImageBehavior = false;
            this.listViewVentasPorDia.View = System.Windows.Forms.View.Details;
            this.listViewVentasPorDia.SelectedIndexChanged += new System.EventHandler(this.listViewVentasPorDia_SelectedIndexChanged);
            // 
            // IDVentaPorDia
            // 
            this.IDVentaPorDia.Text = "ID Venta por Dia";
            this.IDVentaPorDia.Width = 104;
            // 
            // Monto
            // 
            this.Monto.Text = "Monto";
            this.Monto.Width = 128;
            // 
            // Fecha
            // 
            this.Fecha.Text = "Fecha";
            this.Fecha.Width = 198;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto del Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // dateTimePickerFechaMontoDelDia
            // 
            this.dateTimePickerFechaMontoDelDia.Location = new System.Drawing.Point(55, 32);
            this.dateTimePickerFechaMontoDelDia.Name = "dateTimePickerFechaMontoDelDia";
            this.dateTimePickerFechaMontoDelDia.Size = new System.Drawing.Size(249, 20);
            this.dateTimePickerFechaMontoDelDia.TabIndex = 2;
            // 
            // txtMontoDelDia
            // 
            this.txtMontoDelDia.Location = new System.Drawing.Point(104, 6);
            this.txtMontoDelDia.Name = "txtMontoDelDia";
            this.txtMontoDelDia.Size = new System.Drawing.Size(200, 20);
            this.txtMontoDelDia.TabIndex = 3;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(104, 67);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(229, 67);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // VentarPorDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 359);
            this.Controls.Add(this.listViewVentasPorDia);
            this.Controls.Add(this.panel1);
            this.Name = "VentarPorDia";
            this.Text = "VentarPorDia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewVentasPorDia;
        private System.Windows.Forms.ColumnHeader IDVentaPorDia;
        private System.Windows.Forms.ColumnHeader Monto;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox txtMontoDelDia;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaMontoDelDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}