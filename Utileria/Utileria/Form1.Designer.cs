namespace Utileria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEstatus1 = new System.Windows.Forms.Button();
            this.lstObjetos = new System.Windows.Forms.ListBox();
            this.btnEstatus2 = new System.Windows.Forms.Button();
            this.btnEstatusD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExcel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(175, 149);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 58);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Descomprimir";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(175, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "111557";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del archivo .zip";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Enabled = false;
            this.btnMostrar.Location = new System.Drawing.Point(531, 149);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(95, 58);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Ver resultado";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEstatus1
            // 
            this.btnEstatus1.Enabled = false;
            this.btnEstatus1.Location = new System.Drawing.Point(415, 389);
            this.btnEstatus1.Name = "btnEstatus1";
            this.btnEstatus1.Size = new System.Drawing.Size(138, 47);
            this.btnEstatus1.TabIndex = 7;
            this.btnEstatus1.Text = "Estatus 1";
            this.btnEstatus1.UseVisualStyleBackColor = true;
            this.btnEstatus1.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // lstObjetos
            // 
            this.lstObjetos.FormattingEnabled = true;
            this.lstObjetos.ItemHeight = 16;
            this.lstObjetos.Location = new System.Drawing.Point(12, 474);
            this.lstObjetos.Name = "lstObjetos";
            this.lstObjetos.Size = new System.Drawing.Size(1451, 324);
            this.lstObjetos.TabIndex = 8;
            // 
            // btnEstatus2
            // 
            this.btnEstatus2.Enabled = false;
            this.btnEstatus2.Location = new System.Drawing.Point(626, 389);
            this.btnEstatus2.Name = "btnEstatus2";
            this.btnEstatus2.Size = new System.Drawing.Size(126, 47);
            this.btnEstatus2.TabIndex = 9;
            this.btnEstatus2.Text = "Estatus 2";
            this.btnEstatus2.UseVisualStyleBackColor = true;
            this.btnEstatus2.Click += new System.EventHandler(this.btnEstatus2_Click);
            // 
            // btnEstatusD
            // 
            this.btnEstatusD.Enabled = false;
            this.btnEstatusD.Location = new System.Drawing.Point(813, 389);
            this.btnEstatusD.Name = "btnEstatusD";
            this.btnEstatusD.Size = new System.Drawing.Size(170, 47);
            this.btnEstatusD.TabIndex = 10;
            this.btnEstatusD.Text = "Estatus != 1";
            this.btnEstatusD.UseVisualStyleBackColor = true;
            this.btnEstatusD.Click += new System.EventHandler(this.btnEstatusD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ruta del archivo:";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(175, 42);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(597, 22);
            this.txtRuta.TabIndex = 12;
            this.txtRuta.Text = "C:\\Users\\outlet\\Desktop\\Prueba";
            // 
            // lblResultado
            // 
            this.lblResultado.FormattingEnabled = true;
            this.lblResultado.ItemHeight = 16;
            this.lblResultado.Location = new System.Drawing.Point(778, 42);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(949, 292);
            this.lblResultado.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre del archivo excel: ";
            // 
            // txtExcel
            // 
            this.txtExcel.Location = new System.Drawing.Point(563, 88);
            this.txtExcel.Name = "txtExcel";
            this.txtExcel.Size = new System.Drawing.Size(209, 22);
            this.txtExcel.TabIndex = 15;
            this.txtExcel.Text = "ResultadoCargaTitulos111557";
            this.txtExcel.TextChanged += new System.EventHandler(this.txtExcel_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1828, 981);
            this.Controls.Add(this.txtExcel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEstatusD);
            this.Controls.Add(this.btnEstatus2);
            this.Controls.Add(this.lstObjetos);
            this.Controls.Add(this.btnEstatus1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "h0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEstatus1;
        private System.Windows.Forms.ListBox lstObjetos;
        private System.Windows.Forms.Button btnEstatus2;
        private System.Windows.Forms.Button btnEstatusD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.ListBox lblResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExcel;
    }
}

