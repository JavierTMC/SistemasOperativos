namespace Actividad2_MateriaPrima
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpEntradas = new System.Windows.Forms.TabPage();
            this.panelEntradas = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textbPrecioUnitario = new System.Windows.Forms.TextBox();
            this.textbCantidad = new System.Windows.Forms.TextBox();
            this.textbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabpSalidas = new System.Windows.Forms.TabPage();
            this.lblMensajeSalida = new System.Windows.Forms.Label();
            this.textbTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textbProyectoDestino = new System.Windows.Forms.TextBox();
            this.textbCantidadSalidas = new System.Windows.Forms.TextBox();
            this.textbPrecioUnitarioSalida = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textbDisponiblesInventario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerarSalida = new System.Windows.Forms.Button();
            this.cbNombreProducto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabpReportes = new System.Windows.Forms.TabPage();
            this.cbProyectoDestino = new System.Windows.Forms.ComboBox();
            this.lblRutaReporte = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabpEntradas.SuspendLayout();
            this.panelEntradas.SuspendLayout();
            this.tabpSalidas.SuspendLayout();
            this.tabpReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpEntradas);
            this.tabControl1.Controls.Add(this.tabpSalidas);
            this.tabControl1.Controls.Add(this.tabpReportes);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 228);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabpEntradas
            // 
            this.tabpEntradas.Controls.Add(this.panelEntradas);
            this.tabpEntradas.Location = new System.Drawing.Point(4, 22);
            this.tabpEntradas.Name = "tabpEntradas";
            this.tabpEntradas.Padding = new System.Windows.Forms.Padding(3);
            this.tabpEntradas.Size = new System.Drawing.Size(418, 188);
            this.tabpEntradas.TabIndex = 0;
            this.tabpEntradas.Text = "Entradas";
            this.tabpEntradas.UseVisualStyleBackColor = true;
            // 
            // panelEntradas
            // 
            this.panelEntradas.Controls.Add(this.lblMensaje);
            this.panelEntradas.Controls.Add(this.btnGuardar);
            this.panelEntradas.Controls.Add(this.textbPrecioUnitario);
            this.panelEntradas.Controls.Add(this.textbCantidad);
            this.panelEntradas.Controls.Add(this.textbNombre);
            this.panelEntradas.Controls.Add(this.label3);
            this.panelEntradas.Controls.Add(this.label2);
            this.panelEntradas.Controls.Add(this.label1);
            this.panelEntradas.Location = new System.Drawing.Point(15, 6);
            this.panelEntradas.Name = "panelEntradas";
            this.panelEntradas.Size = new System.Drawing.Size(387, 176);
            this.panelEntradas.TabIndex = 0;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(34, 150);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(50, 13);
            this.lblMensaje.TabIndex = 9;
            this.lblMensaje.Text = "Mensaje:";
            this.lblMensaje.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(238, 101);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 33);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textbPrecioUnitario
            // 
            this.textbPrecioUnitario.Location = new System.Drawing.Point(28, 108);
            this.textbPrecioUnitario.Name = "textbPrecioUnitario";
            this.textbPrecioUnitario.Size = new System.Drawing.Size(111, 20);
            this.textbPrecioUnitario.TabIndex = 6;
            // 
            // textbCantidad
            // 
            this.textbCantidad.Location = new System.Drawing.Point(206, 45);
            this.textbCantidad.Name = "textbCantidad";
            this.textbCantidad.Size = new System.Drawing.Size(121, 20);
            this.textbCantidad.TabIndex = 5;
            // 
            // textbNombre
            // 
            this.textbNombre.Location = new System.Drawing.Point(28, 45);
            this.textbNombre.Name = "textbNombre";
            this.textbNombre.Size = new System.Drawing.Size(160, 20);
            this.textbNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio Unitario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tabpSalidas
            // 
            this.tabpSalidas.Controls.Add(this.lblMensajeSalida);
            this.tabpSalidas.Controls.Add(this.textbTotal);
            this.tabpSalidas.Controls.Add(this.label10);
            this.tabpSalidas.Controls.Add(this.textbProyectoDestino);
            this.tabpSalidas.Controls.Add(this.textbCantidadSalidas);
            this.tabpSalidas.Controls.Add(this.textbPrecioUnitarioSalida);
            this.tabpSalidas.Controls.Add(this.label9);
            this.tabpSalidas.Controls.Add(this.label8);
            this.tabpSalidas.Controls.Add(this.label7);
            this.tabpSalidas.Controls.Add(this.textbDisponiblesInventario);
            this.tabpSalidas.Controls.Add(this.label4);
            this.tabpSalidas.Controls.Add(this.btnGenerarSalida);
            this.tabpSalidas.Controls.Add(this.cbNombreProducto);
            this.tabpSalidas.Controls.Add(this.label6);
            this.tabpSalidas.Location = new System.Drawing.Point(4, 22);
            this.tabpSalidas.Name = "tabpSalidas";
            this.tabpSalidas.Padding = new System.Windows.Forms.Padding(3);
            this.tabpSalidas.Size = new System.Drawing.Size(418, 202);
            this.tabpSalidas.TabIndex = 2;
            this.tabpSalidas.Text = "Salidas";
            this.tabpSalidas.UseVisualStyleBackColor = true;
            // 
            // lblMensajeSalida
            // 
            this.lblMensajeSalida.AutoSize = true;
            this.lblMensajeSalida.Location = new System.Drawing.Point(22, 178);
            this.lblMensajeSalida.Name = "lblMensajeSalida";
            this.lblMensajeSalida.Size = new System.Drawing.Size(47, 13);
            this.lblMensajeSalida.TabIndex = 15;
            this.lblMensajeSalida.Text = "Mensaje";
            this.lblMensajeSalida.Visible = false;
            // 
            // textbTotal
            // 
            this.textbTotal.Location = new System.Drawing.Point(23, 150);
            this.textbTotal.Name = "textbTotal";
            this.textbTotal.ReadOnly = true;
            this.textbTotal.Size = new System.Drawing.Size(144, 20);
            this.textbTotal.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Total";
            // 
            // textbProyectoDestino
            // 
            this.textbProyectoDestino.Location = new System.Drawing.Point(182, 100);
            this.textbProyectoDestino.Name = "textbProyectoDestino";
            this.textbProyectoDestino.Size = new System.Drawing.Size(144, 20);
            this.textbProyectoDestino.TabIndex = 12;
            // 
            // textbCantidadSalidas
            // 
            this.textbCantidadSalidas.Location = new System.Drawing.Point(23, 100);
            this.textbCantidadSalidas.Name = "textbCantidadSalidas";
            this.textbCantidadSalidas.Size = new System.Drawing.Size(144, 20);
            this.textbCantidadSalidas.TabIndex = 11;
            this.textbCantidadSalidas.Leave += new System.EventHandler(this.textbCantidadSalidas_Leave);
            // 
            // textbPrecioUnitarioSalida
            // 
            this.textbPrecioUnitarioSalida.Location = new System.Drawing.Point(328, 37);
            this.textbPrecioUnitarioSalida.Name = "textbPrecioUnitarioSalida";
            this.textbPrecioUnitarioSalida.ReadOnly = true;
            this.textbPrecioUnitarioSalida.Size = new System.Drawing.Size(80, 20);
            this.textbPrecioUnitarioSalida.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Precio Unitario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Proyecto Destino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cantidad";
            // 
            // textbDisponiblesInventario
            // 
            this.textbDisponiblesInventario.Location = new System.Drawing.Point(182, 37);
            this.textbDisponiblesInventario.Name = "textbDisponiblesInventario";
            this.textbDisponiblesInventario.ReadOnly = true;
            this.textbDisponiblesInventario.Size = new System.Drawing.Size(122, 20);
            this.textbDisponiblesInventario.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Disponibles en inventario";
            // 
            // btnGenerarSalida
            // 
            this.btnGenerarSalida.Location = new System.Drawing.Point(182, 144);
            this.btnGenerarSalida.Name = "btnGenerarSalida";
            this.btnGenerarSalida.Size = new System.Drawing.Size(144, 23);
            this.btnGenerarSalida.TabIndex = 2;
            this.btnGenerarSalida.Text = "Generar Salida";
            this.btnGenerarSalida.UseVisualStyleBackColor = true;
            this.btnGenerarSalida.Click += new System.EventHandler(this.btnGenerarSalida_Click);
            // 
            // cbNombreProducto
            // 
            this.cbNombreProducto.BackColor = System.Drawing.Color.White;
            this.cbNombreProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombreProducto.FormattingEnabled = true;
            this.cbNombreProducto.Location = new System.Drawing.Point(23, 36);
            this.cbNombreProducto.Name = "cbNombreProducto";
            this.cbNombreProducto.Size = new System.Drawing.Size(144, 21);
            this.cbNombreProducto.TabIndex = 1;
            this.cbNombreProducto.SelectedIndexChanged += new System.EventHandler(this.cbNombreProducto_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre:";
            // 
            // tabpReportes
            // 
            this.tabpReportes.Controls.Add(this.cbProyectoDestino);
            this.tabpReportes.Controls.Add(this.lblRutaReporte);
            this.tabpReportes.Controls.Add(this.btnReporte);
            this.tabpReportes.Controls.Add(this.label5);
            this.tabpReportes.Location = new System.Drawing.Point(4, 22);
            this.tabpReportes.Name = "tabpReportes";
            this.tabpReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabpReportes.Size = new System.Drawing.Size(418, 202);
            this.tabpReportes.TabIndex = 1;
            this.tabpReportes.Text = "Reporte por Proyecto";
            this.tabpReportes.UseVisualStyleBackColor = true;
            // 
            // cbProyectoDestino
            // 
            this.cbProyectoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProyectoDestino.FormattingEnabled = true;
            this.cbProyectoDestino.Location = new System.Drawing.Point(157, 27);
            this.cbProyectoDestino.Name = "cbProyectoDestino";
            this.cbProyectoDestino.Size = new System.Drawing.Size(209, 21);
            this.cbProyectoDestino.TabIndex = 4;
            // 
            // lblRutaReporte
            // 
            this.lblRutaReporte.AutoSize = true;
            this.lblRutaReporte.Location = new System.Drawing.Point(32, 124);
            this.lblRutaReporte.Name = "lblRutaReporte";
            this.lblRutaReporte.Size = new System.Drawing.Size(166, 13);
            this.lblRutaReporte.TabIndex = 3;
            this.lblRutaReporte.Text = "Aqui aparecera la ruta del archivo";
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(35, 63);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(99, 23);
            this.btnReporte.TabIndex = 1;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Proyecto Destino";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 252);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Maquinaria - Reportes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabpEntradas.ResumeLayout(false);
            this.panelEntradas.ResumeLayout(false);
            this.panelEntradas.PerformLayout();
            this.tabpSalidas.ResumeLayout(false);
            this.tabpSalidas.PerformLayout();
            this.tabpReportes.ResumeLayout(false);
            this.tabpReportes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpEntradas;
        private System.Windows.Forms.Panel panelEntradas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textbPrecioUnitario;
        private System.Windows.Forms.TextBox textbCantidad;
        private System.Windows.Forms.TextBox textbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabpReportes;
        private System.Windows.Forms.Label lblRutaReporte;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabpSalidas;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.ComboBox cbNombreProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerarSalida;
        private System.Windows.Forms.TextBox textbProyectoDestino;
        private System.Windows.Forms.TextBox textbCantidadSalidas;
        private System.Windows.Forms.TextBox textbPrecioUnitarioSalida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbDisponiblesInventario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMensajeSalida;
        private System.Windows.Forms.TextBox textbTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbProyectoDestino;

    }
}

