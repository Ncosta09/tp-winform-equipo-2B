namespace CRUD
{
    partial class frmVerTodos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerTodos));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.textBoxFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.labelCampo = new System.Windows.Forms.Label();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.comboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.BtnModificarArticulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.groupBoxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(310, 108);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(497, 390);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            this.dgvArticulos.DoubleClick += new System.EventHandler(this.dgvArticulos_DoubleClick);
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(833, 108);
            this.pbArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(389, 390);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulo.TabIndex = 1;
            this.pbArticulo.TabStop = false;
            // 
            // groupBoxFiltro
            // 
            this.groupBoxFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFiltro.Controls.Add(this.label2);
            this.groupBoxFiltro.Controls.Add(this.label1);
            this.groupBoxFiltro.Controls.Add(this.btnBusquedaAvanzada);
            this.groupBoxFiltro.Controls.Add(this.textBoxFiltroAvanzado);
            this.groupBoxFiltro.Controls.Add(this.labelCampo);
            this.groupBoxFiltro.Controls.Add(this.comboBoxCampo);
            this.groupBoxFiltro.Controls.Add(this.comboBoxCriterio);
            this.groupBoxFiltro.Location = new System.Drawing.Point(23, 117);
            this.groupBoxFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFiltro.Size = new System.Drawing.Size(208, 338);
            this.groupBoxFiltro.TabIndex = 0;
            this.groupBoxFiltro.TabStop = false;
            this.groupBoxFiltro.Text = "Filtro:";
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.BackColor = System.Drawing.SystemColors.Window;
            this.btnBusquedaAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusquedaAvanzada.Font = new System.Drawing.Font("Arial", 7.8F);
            this.btnBusquedaAvanzada.Image = ((System.Drawing.Image)(resources.GetObject("btnBusquedaAvanzada.Image")));
            this.btnBusquedaAvanzada.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(23, 270);
            this.btnBusquedaAvanzada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(160, 26);
            this.btnBusquedaAvanzada.TabIndex = 4;
            this.btnBusquedaAvanzada.Text = "Buscar";
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = false;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // textBoxFiltroAvanzado
            // 
            this.textBoxFiltroAvanzado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFiltroAvanzado.Font = new System.Drawing.Font("Arial", 7.8F);
            this.textBoxFiltroAvanzado.Location = new System.Drawing.Point(23, 203);
            this.textBoxFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFiltroAvanzado.Name = "textBoxFiltroAvanzado";
            this.textBoxFiltroAvanzado.Size = new System.Drawing.Size(160, 22);
            this.textBoxFiltroAvanzado.TabIndex = 3;
            // 
            // labelCampo
            // 
            this.labelCampo.AutoSize = true;
            this.labelCampo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampo.Location = new System.Drawing.Point(23, 44);
            this.labelCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(66, 19);
            this.labelCampo.TabIndex = 0;
            this.labelCampo.Text = "Campo:";
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.Font = new System.Drawing.Font("Arial", 7.8F);
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(23, 67);
            this.comboBoxCampo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(160, 24);
            this.comboBoxCampo.TabIndex = 1;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged);
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterio.Font = new System.Drawing.Font("Arial", 7.8F);
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Location = new System.Drawing.Point(23, 135);
            this.comboBoxCriterio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(160, 24);
            this.comboBoxCriterio.TabIndex = 2;
            // 
            // BtnModificarArticulo
            // 
            this.BtnModificarArticulo.BackColor = System.Drawing.SystemColors.Window;
            this.BtnModificarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarArticulo.Font = new System.Drawing.Font("Arial", 7.8F);
            this.BtnModificarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificarArticulo.Image")));
            this.BtnModificarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificarArticulo.Location = new System.Drawing.Point(23, 470);
            this.BtnModificarArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnModificarArticulo.Name = "BtnModificarArticulo";
            this.BtnModificarArticulo.Size = new System.Drawing.Size(208, 46);
            this.BtnModificarArticulo.TabIndex = 19;
            this.BtnModificarArticulo.Text = "Modificar";
            this.BtnModificarArticulo.UseVisualStyleBackColor = false;
            this.BtnModificarArticulo.Click += new System.EventHandler(this.BtnModificarArticulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label1.Location = new System.Drawing.Point(23, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Criterio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label2.Location = new System.Drawing.Point(23, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "*Para visualizar el detalle, dar doble click en el articulo.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1016, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Todos Los Articulos";
            // 
            // frmVerTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1277, 618);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnModificarArticulo);
            this.Controls.Add(this.groupBoxFiltro);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmVerTodos";
            this.Text = "frmVerTodos";
            this.Load += new System.EventHandler(this.frmVerTodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.groupBoxFiltro.ResumeLayout(false);
            this.groupBoxFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.GroupBox groupBoxFiltro;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.TextBox textBoxFiltroAvanzado;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
        private System.Windows.Forms.Button BtnModificarArticulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}