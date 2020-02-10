namespace cajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnimprimir = new System.Windows.Forms.Button();
            this.txtNUM = new System.Windows.Forms.TextBox();
            this.lblrfi = new System.Windows.Forms.Label();
            this.lblfibo = new System.Windows.Forms.Label();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblresp = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblvuelto = new System.Windows.Forms.Label();
            this.btncobrar = new System.Windows.Forms.Button();
            this.txtefectivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpagar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.btnretirar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnimprimir
            // 
            this.btnimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.Color.Black;
            this.btnimprimir.Location = new System.Drawing.Point(160, 258);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 23);
            this.btnimprimir.TabIndex = 44;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // txtNUM
            // 
            this.txtNUM.Location = new System.Drawing.Point(68, 259);
            this.txtNUM.Name = "txtNUM";
            this.txtNUM.Size = new System.Drawing.Size(85, 20);
            this.txtNUM.TabIndex = 43;
            // 
            // lblrfi
            // 
            this.lblrfi.AutoSize = true;
            this.lblrfi.BackColor = System.Drawing.Color.Transparent;
            this.lblrfi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrfi.ForeColor = System.Drawing.Color.Black;
            this.lblrfi.Location = new System.Drawing.Point(241, 264);
            this.lblrfi.Name = "lblrfi";
            this.lblrfi.Size = new System.Drawing.Size(82, 13);
            this.lblrfi.TabIndex = 42;
            this.lblrfi.Text = "Respuesta: ?";
            // 
            // lblfibo
            // 
            this.lblfibo.AutoSize = true;
            this.lblfibo.BackColor = System.Drawing.Color.Transparent;
            this.lblfibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfibo.ForeColor = System.Drawing.Color.Black;
            this.lblfibo.Location = new System.Drawing.Point(16, 262);
            this.lblfibo.Name = "lblfibo";
            this.lblfibo.Size = new System.Drawing.Size(50, 13);
            this.lblfibo.TabIndex = 41;
            this.lblfibo.Text = "Numero";
            // 
            // btnprocesar
            // 
            this.btnprocesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprocesar.ForeColor = System.Drawing.Color.Black;
            this.btnprocesar.Location = new System.Drawing.Point(160, 189);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(75, 23);
            this.btnprocesar.TabIndex = 40;
            this.btnprocesar.Text = "Procesar";
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(68, 190);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(85, 20);
            this.txtnumero.TabIndex = 39;
            // 
            // lblresp
            // 
            this.lblresp.AutoSize = true;
            this.lblresp.BackColor = System.Drawing.Color.Transparent;
            this.lblresp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresp.ForeColor = System.Drawing.Color.Black;
            this.lblresp.Location = new System.Drawing.Point(241, 193);
            this.lblresp.Name = "lblresp";
            this.lblresp.Size = new System.Drawing.Size(82, 13);
            this.lblresp.TabIndex = 38;
            this.lblresp.Text = "Respuesta: ?";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.BackColor = System.Drawing.Color.Transparent;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.ForeColor = System.Drawing.Color.Black;
            this.lblnumero.Location = new System.Drawing.Point(16, 193);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(50, 13);
            this.lblnumero.TabIndex = 37;
            this.lblnumero.Text = "Numero";
            // 
            // lblvuelto
            // 
            this.lblvuelto.AutoSize = true;
            this.lblvuelto.BackColor = System.Drawing.Color.Transparent;
            this.lblvuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvuelto.ForeColor = System.Drawing.Color.Black;
            this.lblvuelto.Location = new System.Drawing.Point(287, 42);
            this.lblvuelto.Name = "lblvuelto";
            this.lblvuelto.Size = new System.Drawing.Size(14, 13);
            this.lblvuelto.TabIndex = 36;
            this.lblvuelto.Text = "?";
            // 
            // btncobrar
            // 
            this.btncobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncobrar.ForeColor = System.Drawing.Color.Black;
            this.btncobrar.Location = new System.Drawing.Point(222, 37);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(57, 23);
            this.btncobrar.TabIndex = 35;
            this.btncobrar.Text = "Cobrar";
            this.btncobrar.UseVisualStyleBackColor = true;
            this.btncobrar.Click += new System.EventHandler(this.btncobrar_Click);
            // 
            // txtefectivo
            // 
            this.txtefectivo.Location = new System.Drawing.Point(136, 37);
            this.txtefectivo.Name = "txtefectivo";
            this.txtefectivo.Size = new System.Drawing.Size(80, 20);
            this.txtefectivo.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(71, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Efectivo $";
            // 
            // txtpagar
            // 
            this.txtpagar.Location = new System.Drawing.Point(136, 6);
            this.txtpagar.Name = "txtpagar";
            this.txtpagar.Size = new System.Drawing.Size(80, 20);
            this.txtpagar.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Cantidad a pagar $";
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.BackColor = System.Drawing.Color.Transparent;
            this.lblrespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuesta.ForeColor = System.Drawing.Color.Black;
            this.lblrespuesta.Location = new System.Drawing.Point(219, 111);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(82, 13);
            this.lblrespuesta.TabIndex = 30;
            this.lblrespuesta.Text = "Respuesta: ?";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(76, 108);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(84, 20);
            this.txtcantidad.TabIndex = 29;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.ForeColor = System.Drawing.Color.Black;
            this.lblcantidad.Location = new System.Drawing.Point(8, 111);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(68, 13);
            this.lblcantidad.TabIndex = 28;
            this.lblcantidad.Text = "Cantidad $";
            // 
            // btnretirar
            // 
            this.btnretirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretirar.ForeColor = System.Drawing.Color.Black;
            this.btnretirar.Location = new System.Drawing.Point(167, 106);
            this.btnretirar.Name = "btnretirar";
            this.btnretirar.Size = new System.Drawing.Size(52, 23);
            this.btnretirar.TabIndex = 27;
            this.btnretirar.Text = "Retirar";
            this.btnretirar.UseVisualStyleBackColor = true;
            this.btnretirar.Click += new System.EventHandler(this.btnretirar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(466, 530);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.txtNUM);
            this.Controls.Add(this.lblrfi);
            this.Controls.Add(this.lblfibo);
            this.Controls.Add(this.btnprocesar);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblresp);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.lblvuelto);
            this.Controls.Add(this.btncobrar);
            this.Controls.Add(this.txtefectivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.btnretirar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cajero Automatico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.TextBox txtNUM;
        private System.Windows.Forms.Label lblrfi;
        private System.Windows.Forms.Label lblfibo;
        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblresp;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblvuelto;
        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.TextBox txtefectivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Button btnretirar;
    }
}

