namespace CRUD
{
    partial class frmVerDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerDetalle));
            this.lblVerDetalle = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxMarca = new System.Windows.Forms.TextBox();
            this.tbxCategoria = new System.Windows.Forms.TextBox();
            this.pnlDeco = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.pnlDeco.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVerDetalle
            // 
            this.lblVerDetalle.AutoSize = true;
            this.lblVerDetalle.BackColor = System.Drawing.SystemColors.Control;
            this.lblVerDetalle.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblVerDetalle.Location = new System.Drawing.Point(1070, 9);
            this.lblVerDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerDetalle.Name = "lblVerDetalle";
            this.lblVerDetalle.Size = new System.Drawing.Size(194, 30);
            this.lblVerDetalle.TabIndex = 82;
            this.lblVerDetalle.Text = "Detalle Articulo";
            // 
            // tbxNombre
            // 
            this.tbxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNombre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbxNombre.Font = new System.Drawing.Font("Arial", 7.8F);
            this.tbxNombre.Location = new System.Drawing.Point(147, 86);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(328, 22);
            this.tbxNombre.TabIndex = 81;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.SystemColors.Window;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Font = new System.Drawing.Font("Arial", 7.8F);
            this.buttonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCerrar.Image")));
            this.buttonCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCerrar.Location = new System.Drawing.Point(1157, 571);
            this.buttonCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(107, 34);
            this.buttonCerrar.TabIndex = 80;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(713, 75);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(420, 420);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 78;
            this.pbxArticulo.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(42, 377);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(97, 18);
            this.lblDescripcion.TabIndex = 77;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDescripcion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbxDescripcion.Font = new System.Drawing.Font("Arial", 7.8F);
            this.tbxDescripcion.Location = new System.Drawing.Point(147, 376);
            this.tbxDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(328, 106);
            this.tbxDescripcion.TabIndex = 76;
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPrecio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbxPrecio.Font = new System.Drawing.Font("Arial", 7.8F);
            this.tbxPrecio.Location = new System.Drawing.Point(147, 318);
            this.tbxPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(328, 22);
            this.tbxPrecio.TabIndex = 75;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(42, 319);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(58, 18);
            this.lblPrecio.TabIndex = 74;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(42, 261);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(81, 18);
            this.lblCategoria.TabIndex = 72;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblMarca.Location = new System.Drawing.Point(42, 203);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 18);
            this.lblMarca.TabIndex = 71;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.Location = new System.Drawing.Point(42, 145);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 18);
            this.lblCodigo.TabIndex = 70;
            this.lblCodigo.Text = "Codigo:";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCodigo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbxCodigo.Font = new System.Drawing.Font("Arial", 7.8F);
            this.tbxCodigo.Location = new System.Drawing.Point(147, 144);
            this.tbxCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(328, 22);
            this.tbxCodigo.TabIndex = 67;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(42, 87);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 18);
            this.lblNombre.TabIndex = 65;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbxMarca
            // 
            this.tbxMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMarca.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbxMarca.Font = new System.Drawing.Font("Arial", 7.8F);
            this.tbxMarca.Location = new System.Drawing.Point(147, 202);
            this.tbxMarca.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMarca.Name = "tbxMarca";
            this.tbxMarca.Size = new System.Drawing.Size(328, 22);
            this.tbxMarca.TabIndex = 83;
            // 
            // tbxCategoria
            // 
            this.tbxCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCategoria.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbxCategoria.Font = new System.Drawing.Font("Arial", 7.8F);
            this.tbxCategoria.Location = new System.Drawing.Point(147, 260);
            this.tbxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCategoria.Name = "tbxCategoria";
            this.tbxCategoria.Size = new System.Drawing.Size(328, 22);
            this.tbxCategoria.TabIndex = 84;
            // 
            // pnlDeco
            // 
            this.pnlDeco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDeco.Controls.Add(this.lblMarca);
            this.pnlDeco.Controls.Add(this.tbxCategoria);
            this.pnlDeco.Controls.Add(this.lblNombre);
            this.pnlDeco.Controls.Add(this.tbxMarca);
            this.pnlDeco.Controls.Add(this.tbxCodigo);
            this.pnlDeco.Controls.Add(this.lblCodigo);
            this.pnlDeco.Controls.Add(this.tbxNombre);
            this.pnlDeco.Controls.Add(this.lblCategoria);
            this.pnlDeco.Controls.Add(this.lblPrecio);
            this.pnlDeco.Controls.Add(this.tbxPrecio);
            this.pnlDeco.Controls.Add(this.lblDescripcion);
            this.pnlDeco.Controls.Add(this.tbxDescripcion);
            this.pnlDeco.Location = new System.Drawing.Point(83, 0);
            this.pnlDeco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDeco.Name = "pnlDeco";
            this.pnlDeco.Size = new System.Drawing.Size(496, 622);
            this.pnlDeco.TabIndex = 85;
            // 
            // frmVerDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 618);
            this.Controls.Add(this.pnlDeco);
            this.Controls.Add(this.lblVerDetalle);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.pbxArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVerDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerDetalle";
            this.Load += new System.EventHandler(this.frmVerDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.pnlDeco.ResumeLayout(false);
            this.pnlDeco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerDetalle;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbxMarca;
        private System.Windows.Forms.TextBox tbxCategoria;
        private System.Windows.Forms.Panel pnlDeco;
    }
}