namespace CRUD
{
    partial class frmEliminarMarca
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
            this.lblMarcasViejas = new System.Windows.Forms.Label();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.pnlDeco = new System.Windows.Forms.Panel();
            this.pnlMarca = new System.Windows.Forms.Panel();
            this.tbxEliminarMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblEliminarMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.pnlDeco.SuspendLayout();
            this.pnlMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMarcasViejas
            // 
            this.lblMarcasViejas.AutoSize = true;
            this.lblMarcasViejas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblMarcasViejas.Location = new System.Drawing.Point(496, 138);
            this.lblMarcasViejas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarcasViejas.Name = "lblMarcasViejas";
            this.lblMarcasViejas.Size = new System.Drawing.Size(53, 15);
            this.lblMarcasViejas.TabIndex = 10;
            this.lblMarcasViejas.Text = "Marcas:";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(499, 155);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.RowTemplate.Height = 24;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(338, 184);
            this.dgvMarcas.TabIndex = 9;
            this.dgvMarcas.Click += new System.EventHandler(this.dgvMarcas_Click);
            // 
            // pnlDeco
            // 
            this.pnlDeco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDeco.Controls.Add(this.pnlMarca);
            this.pnlDeco.Controls.Add(this.btnEliminar);
            this.pnlDeco.Location = new System.Drawing.Point(34, -1);
            this.pnlDeco.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDeco.Name = "pnlDeco";
            this.pnlDeco.Size = new System.Drawing.Size(372, 505);
            this.pnlDeco.TabIndex = 8;
            // 
            // pnlMarca
            // 
            this.pnlMarca.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlMarca.Controls.Add(this.tbxEliminarMarca);
            this.pnlMarca.Controls.Add(this.label1);
            this.pnlMarca.Location = new System.Drawing.Point(82, 156);
            this.pnlMarca.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMarca.Name = "pnlMarca";
            this.pnlMarca.Size = new System.Drawing.Size(199, 144);
            this.pnlMarca.TabIndex = 0;
            // 
            // tbxEliminarMarca
            // 
            this.tbxEliminarMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxEliminarMarca.Location = new System.Drawing.Point(10, 39);
            this.tbxEliminarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEliminarMarca.Name = "tbxEliminarMarca";
            this.tbxEliminarMarca.ReadOnly = true;
            this.tbxEliminarMarca.Size = new System.Drawing.Size(176, 20);
            this.tbxEliminarMarca.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 7.8F);
            this.btnEliminar.Location = new System.Drawing.Point(145, 319);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 21);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblEliminarMarca
            // 
            this.lblEliminarMarca.AutoSize = true;
            this.lblEliminarMarca.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblEliminarMarca.Location = new System.Drawing.Point(791, 7);
            this.lblEliminarMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEliminarMarca.Name = "lblEliminarMarca";
            this.lblEliminarMarca.Size = new System.Drawing.Size(150, 24);
            this.lblEliminarMarca.TabIndex = 7;
            this.lblEliminarMarca.Text = "Eliminar Marca";
            // 
            // frmEliminarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 502);
            this.Controls.Add(this.lblMarcasViejas);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.pnlDeco);
            this.Controls.Add(this.lblEliminarMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEliminarMarca";
            this.Text = "frmEliminarMarca";
            this.Load += new System.EventHandler(this.frmEliminarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.pnlDeco.ResumeLayout(false);
            this.pnlMarca.ResumeLayout(false);
            this.pnlMarca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarcasViejas;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Panel pnlDeco;
        private System.Windows.Forms.Panel pnlMarca;
        private System.Windows.Forms.TextBox tbxEliminarMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblEliminarMarca;
    }
}