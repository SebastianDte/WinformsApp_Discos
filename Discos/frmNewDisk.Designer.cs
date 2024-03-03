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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.lblBarraTitutlo = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.lblArtista = new System.Windows.Forms.Label();
            this.btnImgLocal = new FontAwesome.Sharp.IconButton();
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
            this.lblTitulo.Location = new System.Drawing.Point(20, 99);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 17);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(20, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de lanzamiento";
            // 
            // lblCantCanciones
            // 
            this.lblCantCanciones.AutoSize = true;
            this.lblCantCanciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCanciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantCanciones.Location = new System.Drawing.Point(20, 189);
            this.lblCantCanciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantCanciones.Name = "lblCantCanciones";
            this.lblCantCanciones.Size = new System.Drawing.Size(154, 17);
            this.lblCantCanciones.TabIndex = 2;
            this.lblCantCanciones.Text = "Cantidad de Canciones";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(20, 118);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(153, 20);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // txtCantCanciones
            // 
            this.txtCantCanciones.Location = new System.Drawing.Point(20, 208);
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
            this.btnAceptar.Location = new System.Drawing.Point(229, 334);
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
            this.btnCancelar.Location = new System.Drawing.Point(417, 334);
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
            this.txtUrlImgTapa.Location = new System.Drawing.Point(20, 253);
            this.txtUrlImgTapa.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrlImgTapa.Name = "txtUrlImgTapa";
            this.txtUrlImgTapa.Size = new System.Drawing.Size(154, 20);
            this.txtUrlImgTapa.TabIndex = 3;
            this.txtUrlImgTapa.Leave += new System.EventHandler(this.txtUrlImgTapa_Leave);
            
            // 
            // lblUrlImgTapa
            // 
            this.lblUrlImgTapa.AutoSize = true;
            this.lblUrlImgTapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImgTapa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUrlImgTapa.Location = new System.Drawing.Point(20, 234);
            this.lblUrlImgTapa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrlImgTapa.Name = "lblUrlImgTapa";
            this.lblUrlImgTapa.Size = new System.Drawing.Size(111, 17);
            this.lblUrlImgTapa.TabIndex = 8;
            this.lblUrlImgTapa.Text = "Imagen de Tapa";
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(20, 163);
            this.dtpFechaLanzamiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(153, 20);
            this.dtpFechaLanzamiento.TabIndex = 1;
            this.dtpFechaLanzamiento.Value = new System.DateTime(2024, 2, 7, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(20, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo de Edición";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(20, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Estilo";
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(20, 298);
            this.cboEstilo.Margin = new System.Windows.Forms.Padding(2);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(153, 21);
            this.cboEstilo.TabIndex = 4;
            // 
            // cboTipoEdicion
            // 
            this.cboTipoEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEdicion.FormattingEnabled = true;
            this.cboTipoEdicion.Location = new System.Drawing.Point(20, 344);
            this.cboTipoEdicion.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoEdicion.Name = "cboTipoEdicion";
            this.cboTipoEdicion.Size = new System.Drawing.Size(153, 21);
            this.cboTipoEdicion.TabIndex = 5;
            // 
            // pxbDiscos
            // 
            this.pxbDiscos.Location = new System.Drawing.Point(229, 77);
            this.pxbDiscos.Margin = new System.Windows.Forms.Padding(2);
            this.pxbDiscos.Name = "pxbDiscos";
            this.pxbDiscos.Size = new System.Drawing.Size(280, 242);
            this.pxbDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbDiscos.TabIndex = 13;
            this.pxbDiscos.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.barraTitulo.Controls.Add(this.lblBarraTitutlo);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Location = new System.Drawing.Point(0, 1);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(551, 35);
            this.barraTitulo.TabIndex = 15;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // lblBarraTitutlo
            // 
            this.lblBarraTitutlo.AutoSize = true;
            this.lblBarraTitutlo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBarraTitutlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarraTitutlo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBarraTitutlo.Location = new System.Drawing.Point(3, 8);
            this.lblBarraTitutlo.Name = "lblBarraTitutlo";
            this.lblBarraTitutlo.Size = new System.Drawing.Size(101, 20);
            this.lblBarraTitutlo.TabIndex = 1;
            this.lblBarraTitutlo.Text = "lblBarraTitulo";
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
            this.btnCerrar.Location = new System.Drawing.Point(514, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(20, 77);
            this.txtArtista.Margin = new System.Windows.Forms.Padding(2);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(153, 20);
            this.txtArtista.TabIndex = 16;
            this.txtArtista.TextChanged += new System.EventHandler(this.txtArtista_TextChanged);
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtista.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblArtista.Location = new System.Drawing.Point(20, 58);
            this.lblArtista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(48, 17);
            this.lblArtista.TabIndex = 17;
            this.lblArtista.Text = "Artista";
            // 
            // btnImgLocal
            // 
            this.btnImgLocal.FlatAppearance.BorderSize = 0;
            this.btnImgLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImgLocal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImgLocal.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.btnImgLocal.IconColor = System.Drawing.Color.White;
            this.btnImgLocal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImgLocal.IconSize = 20;
            this.btnImgLocal.Location = new System.Drawing.Point(179, 249);
            this.btnImgLocal.Name = "btnImgLocal";
            this.btnImgLocal.Size = new System.Drawing.Size(20, 26);
            this.btnImgLocal.TabIndex = 18;
            this.btnImgLocal.UseVisualStyleBackColor = true;
            this.btnImgLocal.Click += new System.EventHandler(this.btnImgLocal_Click);
            // 
            // frmNewDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(547, 400);
            this.Controls.Add(this.btnImgLocal);
            this.Controls.Add(this.txtArtista);
            this.Controls.Add(this.lblArtista);
            this.Controls.Add(this.barraTitulo);
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
            this.MaximumSize = new System.Drawing.Size(547, 400);
            this.MinimumSize = new System.Drawing.Size(547, 400);
            this.Name = "frmNewDisk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            this.Load += new System.EventHandler(this.frmNewDisk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pxbDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel barraTitulo;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.Label lblArtista;
        private FontAwesome.Sharp.IconButton btnImgLocal;
        private System.Windows.Forms.Label lblBarraTitutlo;
    }
}