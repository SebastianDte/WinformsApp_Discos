namespace Discos
{
    partial class frmNewDisk
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantCanciones = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCantCanciones = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtUrlImgTapa = new System.Windows.Forms.TextBox();
            this.lblUrlImgTapa = new System.Windows.Forms.Label();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(57, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de lanzamiento";
            // 
            // lblCantCanciones
            // 
            this.lblCantCanciones.AutoSize = true;
            this.lblCantCanciones.Location = new System.Drawing.Point(56, 129);
            this.lblCantCanciones.Name = "lblCantCanciones";
            this.lblCantCanciones.Size = new System.Drawing.Size(174, 20);
            this.lblCantCanciones.TabIndex = 2;
            this.lblCantCanciones.Text = "Cantidad de Canciones";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(230, 46);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(191, 26);
            this.txtTitulo.TabIndex = 3;
            // 
            // txtCantCanciones
            // 
            this.txtCantCanciones.Location = new System.Drawing.Point(230, 126);
            this.txtCantCanciones.Name = "txtCantCanciones";
            this.txtCantCanciones.Size = new System.Drawing.Size(191, 26);
            this.txtCantCanciones.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(117, 260);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(113, 48);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(266, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 48);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtUrlImgTapa
            // 
            this.txtUrlImgTapa.Location = new System.Drawing.Point(230, 162);
            this.txtUrlImgTapa.Name = "txtUrlImgTapa";
            this.txtUrlImgTapa.Size = new System.Drawing.Size(191, 26);
            this.txtUrlImgTapa.TabIndex = 9;
            // 
            // lblUrlImgTapa
            // 
            this.lblUrlImgTapa.AutoSize = true;
            this.lblUrlImgTapa.Location = new System.Drawing.Point(56, 165);
            this.lblUrlImgTapa.Name = "lblUrlImgTapa";
            this.lblUrlImgTapa.Size = new System.Drawing.Size(125, 20);
            this.lblUrlImgTapa.TabIndex = 8;
            this.lblUrlImgTapa.Text = "Imagen de Tapa";
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(230, 88);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(191, 26);
            this.dtpFechaLanzamiento.TabIndex = 10;
            // 
            // frmNewDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 335);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.txtUrlImgTapa);
            this.Controls.Add(this.lblUrlImgTapa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantCanciones);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblCantCanciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmNewDisk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantCanciones;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCantCanciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtUrlImgTapa;
        private System.Windows.Forms.Label lblUrlImgTapa;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
    }
}