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
            this.components = new System.ComponentModel.Container();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.cboTipoEdicion = new System.Windows.Forms.ComboBox();
            this.pxbDiscos = new System.Windows.Forms.PictureBox();
            this.BtnAgregarImagen = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pxbDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.barraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(11, 60);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(44, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(11, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de lanzamiento";
            // 
            // lblCantCanciones
            // 
            this.lblCantCanciones.AutoSize = true;
            this.lblCantCanciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCanciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantCanciones.Location = new System.Drawing.Point(11, 150);
            this.lblCantCanciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantCanciones.Name = "lblCantCanciones";
            this.lblCantCanciones.Size = new System.Drawing.Size(161, 18);
            this.lblCantCanciones.TabIndex = 2;
            this.lblCantCanciones.Text = "Cantidad de Canciones";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(11, 79);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(153, 20);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // txtCantCanciones
            // 
            this.txtCantCanciones.Location = new System.Drawing.Point(11, 169);
            this.txtCantCanciones.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantCanciones.Name = "txtCantCanciones";
            this.txtCantCanciones.Size = new System.Drawing.Size(153, 20);
            this.txtCantCanciones.TabIndex = 2;
            this.txtCantCanciones.TextChanged += new System.EventHandler(this.txtCantCanciones_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(230, 299);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 31);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(396, 299);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 31);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtUrlImgTapa
            // 
            this.txtUrlImgTapa.Location = new System.Drawing.Point(11, 214);
            this.txtUrlImgTapa.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrlImgTapa.Name = "txtUrlImgTapa";
            this.txtUrlImgTapa.Size = new System.Drawing.Size(153, 20);
            this.txtUrlImgTapa.TabIndex = 3;
            this.txtUrlImgTapa.TextChanged += new System.EventHandler(this.txtUrlImgTapa_TextChanged);
           
            // 
            // lblUrlImgTapa
            // 
            this.lblUrlImgTapa.AutoSize = true;
            this.lblUrlImgTapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImgTapa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUrlImgTapa.Location = new System.Drawing.Point(11, 195);
            this.lblUrlImgTapa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrlImgTapa.Name = "lblUrlImgTapa";
            this.lblUrlImgTapa.Size = new System.Drawing.Size(113, 18);
            this.lblUrlImgTapa.TabIndex = 8;
            this.lblUrlImgTapa.Text = "Imagen de Tapa";
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(11, 124);
            this.dtpFechaLanzamiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(153, 20);
            this.dtpFechaLanzamiento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(11, 286);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo de Edición";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(11, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Estilo";
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(11, 259);
            this.cboEstilo.Margin = new System.Windows.Forms.Padding(2);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(153, 21);
            this.cboEstilo.TabIndex = 4;
            // 
            // cboTipoEdicion
            // 
            this.cboTipoEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEdicion.FormattingEnabled = true;
            this.cboTipoEdicion.Location = new System.Drawing.Point(11, 305);
            this.cboTipoEdicion.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoEdicion.Name = "cboTipoEdicion";
            this.cboTipoEdicion.Size = new System.Drawing.Size(153, 21);
            this.cboTipoEdicion.TabIndex = 5;
            // 
            // pxbDiscos
            // 
            this.pxbDiscos.Location = new System.Drawing.Point(230, 79);
            this.pxbDiscos.Margin = new System.Windows.Forms.Padding(2);
            this.pxbDiscos.Name = "pxbDiscos";
            this.pxbDiscos.Size = new System.Drawing.Size(258, 212);
            this.pxbDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbDiscos.TabIndex = 13;
            this.pxbDiscos.TabStop = false;
            // 
            // BtnAgregarImagen
            // 
            this.BtnAgregarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnAgregarImagen.FlatAppearance.BorderSize = 0;
            this.BtnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarImagen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgregarImagen.Location = new System.Drawing.Point(169, 211);
            this.BtnAgregarImagen.Name = "BtnAgregarImagen";
            this.BtnAgregarImagen.Size = new System.Drawing.Size(18, 23);
            this.BtnAgregarImagen.TabIndex = 14;
            this.BtnAgregarImagen.Text = "+";
            this.BtnAgregarImagen.UseVisualStyleBackColor = false;
            this.BtnAgregarImagen.Click += new System.EventHandler(this.BtnAgregarImagen_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Location = new System.Drawing.Point(0, 1);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(546, 35);
            this.barraTitulo.TabIndex = 15;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 20;
            this.btnCerrar.Location = new System.Drawing.Point(509, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmNewDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(547, 366);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.BtnAgregarImagen);
            this.Controls.Add(this.pxbDiscos);
            this.Controls.Add(this.cboTipoEdicion);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(547, 366);
            this.MinimumSize = new System.Drawing.Size(547, 366);
            this.Name = "frmNewDisk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            this.Load += new System.EventHandler(this.frmNewDisk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pxbDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.barraTitulo.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.ComboBox cboTipoEdicion;
        private System.Windows.Forms.PictureBox pxbDiscos;
        private System.Windows.Forms.Button BtnAgregarImagen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel barraTitulo;
        private FontAwesome.Sharp.IconButton btnCerrar;
    }
}