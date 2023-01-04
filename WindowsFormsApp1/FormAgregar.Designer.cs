
namespace WindowsFormsApp1
{
    partial class FormAgregar
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
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblDescripcionNuevo = new System.Windows.Forms.Label();
            this.lblCodigoNuevo = new System.Windows.Forms.Label();
            this.lblMarcaNuevo = new System.Windows.Forms.Label();
            this.lblCategoriaNuevo = new System.Windows.Forms.Label();
            this.lblImagenNuevo = new System.Windows.Forms.Label();
            this.lblPrecioNuevo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbMarcasAgregar = new System.Windows.Forms.ComboBox();
            this.cmbCategoriasAgregar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNombreNuevo
            // 
            this.lblNombreNuevo.AutoSize = true;
            this.lblNombreNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreNuevo.Location = new System.Drawing.Point(38, 103);
            this.lblNombreNuevo.Name = "lblNombreNuevo";
            this.lblNombreNuevo.Size = new System.Drawing.Size(80, 20);
            this.lblNombreNuevo.TabIndex = 0;
            this.lblNombreNuevo.Text = "Nombre:";
            // 
            // lblDescripcionNuevo
            // 
            this.lblDescripcionNuevo.AutoSize = true;
            this.lblDescripcionNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescripcionNuevo.Location = new System.Drawing.Point(38, 165);
            this.lblDescripcionNuevo.Name = "lblDescripcionNuevo";
            this.lblDescripcionNuevo.Size = new System.Drawing.Size(116, 20);
            this.lblDescripcionNuevo.TabIndex = 1;
            this.lblDescripcionNuevo.Text = "Descripción:";
            // 
            // lblCodigoNuevo
            // 
            this.lblCodigoNuevo.AutoSize = true;
            this.lblCodigoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigoNuevo.Location = new System.Drawing.Point(38, 43);
            this.lblCodigoNuevo.Name = "lblCodigoNuevo";
            this.lblCodigoNuevo.Size = new System.Drawing.Size(73, 20);
            this.lblCodigoNuevo.TabIndex = 2;
            this.lblCodigoNuevo.Text = "Código:";
            // 
            // lblMarcaNuevo
            // 
            this.lblMarcaNuevo.AutoSize = true;
            this.lblMarcaNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarcaNuevo.Location = new System.Drawing.Point(38, 225);
            this.lblMarcaNuevo.Name = "lblMarcaNuevo";
            this.lblMarcaNuevo.Size = new System.Drawing.Size(67, 20);
            this.lblMarcaNuevo.TabIndex = 3;
            this.lblMarcaNuevo.Text = "Marca:";
            // 
            // lblCategoriaNuevo
            // 
            this.lblCategoriaNuevo.AutoSize = true;
            this.lblCategoriaNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCategoriaNuevo.Location = new System.Drawing.Point(38, 285);
            this.lblCategoriaNuevo.Name = "lblCategoriaNuevo";
            this.lblCategoriaNuevo.Size = new System.Drawing.Size(96, 20);
            this.lblCategoriaNuevo.TabIndex = 4;
            this.lblCategoriaNuevo.Text = "Categoría:";
            // 
            // lblImagenNuevo
            // 
            this.lblImagenNuevo.AutoSize = true;
            this.lblImagenNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblImagenNuevo.Location = new System.Drawing.Point(38, 348);
            this.lblImagenNuevo.Name = "lblImagenNuevo";
            this.lblImagenNuevo.Size = new System.Drawing.Size(75, 20);
            this.lblImagenNuevo.TabIndex = 5;
            this.lblImagenNuevo.Text = "Imágen:";
            // 
            // lblPrecioNuevo
            // 
            this.lblPrecioNuevo.AutoSize = true;
            this.lblPrecioNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrecioNuevo.Location = new System.Drawing.Point(38, 408);
            this.lblPrecioNuevo.Name = "lblPrecioNuevo";
            this.lblPrecioNuevo.Size = new System.Drawing.Size(69, 20);
            this.lblPrecioNuevo.TabIndex = 6;
            this.lblPrecioNuevo.Text = "Precio:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(199, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(126, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(199, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(126, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(199, 162);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(171, 22);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(199, 348);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(126, 22);
            this.txtImagen.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(199, 405);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(126, 22);
            this.txtPrecio.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(61, 459);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 33);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(247, 459);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 33);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbMarcasAgregar
            // 
            this.cmbMarcasAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMarcasAgregar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcasAgregar.FormattingEnabled = true;
            this.cmbMarcasAgregar.Location = new System.Drawing.Point(199, 219);
            this.cmbMarcasAgregar.Name = "cmbMarcasAgregar";
            this.cmbMarcasAgregar.Size = new System.Drawing.Size(121, 24);
            this.cmbMarcasAgregar.TabIndex = 10;
            // 
            // cmbCategoriasAgregar
            // 
            this.cmbCategoriasAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCategoriasAgregar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriasAgregar.FormattingEnabled = true;
            this.cmbCategoriasAgregar.Location = new System.Drawing.Point(199, 279);
            this.cmbCategoriasAgregar.Name = "cmbCategoriasAgregar";
            this.cmbCategoriasAgregar.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoriasAgregar.TabIndex = 11;
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(415, 525);
            this.Controls.Add(this.cmbCategoriasAgregar);
            this.Controls.Add(this.cmbMarcasAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblPrecioNuevo);
            this.Controls.Add(this.lblImagenNuevo);
            this.Controls.Add(this.lblCategoriaNuevo);
            this.Controls.Add(this.lblMarcaNuevo);
            this.Controls.Add(this.lblCodigoNuevo);
            this.Controls.Add(this.lblDescripcionNuevo);
            this.Controls.Add(this.lblNombreNuevo);
            this.MaximizeBox = false;
            this.Name = "FormAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Artículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreNuevo;
        private System.Windows.Forms.Label lblDescripcionNuevo;
        private System.Windows.Forms.Label lblCodigoNuevo;
        private System.Windows.Forms.Label lblMarcaNuevo;
        private System.Windows.Forms.Label lblCategoriaNuevo;
        private System.Windows.Forms.Label lblImagenNuevo;
        private System.Windows.Forms.Label lblPrecioNuevo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbMarcasAgregar;
        private System.Windows.Forms.ComboBox cmbCategoriasAgregar;
    }
}