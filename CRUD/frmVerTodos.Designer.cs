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
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.groupBoxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 127);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(848, 390);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            this.dgvArticulos.DoubleClick += new System.EventHandler(this.dgvArticulos_DoubleClick);
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(875, 127);
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
            this.groupBoxFiltro.Controls.Add(this.btnBusquedaAvanzada);
            this.groupBoxFiltro.Controls.Add(this.textBoxFiltroAvanzado);
            this.groupBoxFiltro.Controls.Add(this.labelCampo);
            this.groupBoxFiltro.Controls.Add(this.comboBoxCampo);
            this.groupBoxFiltro.Controls.Add(this.comboBoxCriterio);
            this.groupBoxFiltro.Location = new System.Drawing.Point(624, 52);
            this.groupBoxFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFiltro.Size = new System.Drawing.Size(637, 57);
            this.groupBoxFiltro.TabIndex = 0;
            this.groupBoxFiltro.TabStop = false;
            this.groupBoxFiltro.Text = "Filtro Avanzado";
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBusquedaAvanzada.BackColor = System.Drawing.SystemColors.Control;
            this.btnBusquedaAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusquedaAvanzada.Image = ((System.Drawing.Image)(resources.GetObject("btnBusquedaAvanzada.Image")));
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(585, 16);
            this.btnBusquedaAvanzada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(31, 26);
            this.btnBusquedaAvanzada.TabIndex = 4;
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = false;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // textBoxFiltroAvanzado
            // 
            this.textBoxFiltroAvanzado.Location = new System.Drawing.Point(436, 16);
            this.textBoxFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFiltroAvanzado.Name = "textBoxFiltroAvanzado";
            this.textBoxFiltroAvanzado.Size = new System.Drawing.Size(127, 22);
            this.textBoxFiltroAvanzado.TabIndex = 3;
            // 
            // labelCampo
            // 
            this.labelCampo.AutoSize = true;
            this.labelCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampo.Location = new System.Drawing.Point(21, 18);
            this.labelCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(62, 20);
            this.labelCampo.TabIndex = 0;
            this.labelCampo.Text = "Campo";
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Items.AddRange(new object[] {
            "Nombre",
            "Codigo",
            "Descripcion",
            "Marca",
            "Categoria",
            "Precio"});
            this.comboBoxCampo.Location = new System.Drawing.Point(97, 16);
            this.comboBoxCampo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(160, 24);
            this.comboBoxCampo.TabIndex = 1;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged);
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Location = new System.Drawing.Point(267, 16);
            this.comboBoxCriterio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(160, 24);
            this.comboBoxCriterio.TabIndex = 2;
            // 
            // BtnModificarArticulo
            // 
            this.BtnModificarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificarArticulo.Image")));
            this.BtnModificarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificarArticulo.Location = new System.Drawing.Point(12, 57);
            this.BtnModificarArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnModificarArticulo.Name = "BtnModificarArticulo";
            this.BtnModificarArticulo.Size = new System.Drawing.Size(103, 46);
            this.BtnModificarArticulo.TabIndex = 19;
            this.BtnModificarArticulo.Text = "Modificar";
            this.BtnModificarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarArticulo.UseVisualStyleBackColor = true;
            this.BtnModificarArticulo.Click += new System.EventHandler(this.BtnModificarArticulo_Click);
            // 
            // frmVerTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1277, 618);
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
    }
}