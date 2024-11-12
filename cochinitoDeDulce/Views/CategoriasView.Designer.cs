namespace cochinitoDeDulce.Views
{
    partial class CategoriasView
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
            tpCategoriasAgregarEditar = new TabPage();
            txtNombreCategoria = new ControlesPersonalizados.CustomTextBox();
            btnRegresar = new Button();
            btnGuardar = new Button();
            lblGuardarEditar = new Label();
            tpCategoriasVer = new TabPage();
            txtBuscarCategoria = new ControlesPersonalizados.CustomTextBox();
            btnIrEliminar = new Button();
            btnIrEditar = new Button();
            btnIrAgregar = new Button();
            btnBuscar = new Button();
            dgCategorias = new DataGridView();
            tbCategorias = new TabControl();
            tpEliminar = new TabPage();
            cbEliminarCategoria = new ControlesPersonalizados.CustomComboBox();
            btnEliminarCategoriaCancelar = new Button();
            btnEliminarCategoriaEliminar = new Button();
            lblElimimarCategoria = new Label();
            tpCategoriasAgregarEditar.SuspendLayout();
            tpCategoriasVer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCategorias).BeginInit();
            tbCategorias.SuspendLayout();
            tpEliminar.SuspendLayout();
            SuspendLayout();
            // 
            // tpCategoriasAgregarEditar
            // 
            tpCategoriasAgregarEditar.Controls.Add(txtNombreCategoria);
            tpCategoriasAgregarEditar.Controls.Add(btnRegresar);
            tpCategoriasAgregarEditar.Controls.Add(btnGuardar);
            tpCategoriasAgregarEditar.Controls.Add(lblGuardarEditar);
            tpCategoriasAgregarEditar.Location = new Point(4, 24);
            tpCategoriasAgregarEditar.Name = "tpCategoriasAgregarEditar";
            tpCategoriasAgregarEditar.Padding = new Padding(3);
            tpCategoriasAgregarEditar.Size = new Size(1202, 759);
            tpCategoriasAgregarEditar.TabIndex = 2;
            tpCategoriasAgregarEditar.Text = "/GuardarCategoria";
            tpCategoriasAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.BorderColor = Color.MediumSlateBlue;
            txtNombreCategoria.BorderFocusColor = Color.HotPink;
            txtNombreCategoria.BorderSize = 2;
            txtNombreCategoria.Location = new Point(231, 360);
            txtNombreCategoria.Multiline = false;
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Padding = new Padding(7);
            txtNombreCategoria.PasswordChar = false;
            txtNombreCategoria.Size = new Size(740, 30);
            txtNombreCategoria.TabIndex = 9;
            txtNombreCategoria.Texts = "";
            txtNombreCategoria.UnderlinedStyle = false;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(582, 406);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(389, 41);
            btnRegresar.TabIndex = 8;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(231, 406);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(345, 41);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblGuardarEditar
            // 
            lblGuardarEditar.AutoSize = true;
            lblGuardarEditar.Location = new Point(491, 333);
            lblGuardarEditar.Name = "lblGuardarEditar";
            lblGuardarEditar.Size = new Size(166, 15);
            lblGuardarEditar.TabIndex = 3;
            lblGuardarEditar.Text = "Nombre de la nueva categoria";
            // 
            // tpCategoriasVer
            // 
            tpCategoriasVer.Controls.Add(txtBuscarCategoria);
            tpCategoriasVer.Controls.Add(btnIrEliminar);
            tpCategoriasVer.Controls.Add(btnIrEditar);
            tpCategoriasVer.Controls.Add(btnIrAgregar);
            tpCategoriasVer.Controls.Add(btnBuscar);
            tpCategoriasVer.Controls.Add(dgCategorias);
            tpCategoriasVer.Location = new Point(4, 24);
            tpCategoriasVer.Name = "tpCategoriasVer";
            tpCategoriasVer.Padding = new Padding(3);
            tpCategoriasVer.Size = new Size(1407, 872);
            tpCategoriasVer.TabIndex = 0;
            tpCategoriasVer.Text = "Todas las categorias";
            tpCategoriasVer.UseVisualStyleBackColor = true;
            tpCategoriasVer.Click += tpCategoriasVer_Click;
            // 
            // txtBuscarCategoria
            // 
            txtBuscarCategoria.BorderColor = Color.MediumSlateBlue;
            txtBuscarCategoria.BorderFocusColor = Color.HotPink;
            txtBuscarCategoria.BorderSize = 2;
            txtBuscarCategoria.Location = new Point(542, 13);
            txtBuscarCategoria.Multiline = false;
            txtBuscarCategoria.Name = "txtBuscarCategoria";
            txtBuscarCategoria.Padding = new Padding(7);
            txtBuscarCategoria.PasswordChar = false;
            txtBuscarCategoria.Size = new Size(536, 30);
            txtBuscarCategoria.TabIndex = 6;
            txtBuscarCategoria.Texts = "";
            txtBuscarCategoria.UnderlinedStyle = false;
            // 
            // btnIrEliminar
            // 
            btnIrEliminar.Location = new Point(542, 477);
            btnIrEliminar.Name = "btnIrEliminar";
            btnIrEliminar.Size = new Size(654, 260);
            btnIrEliminar.TabIndex = 5;
            btnIrEliminar.Text = "Eliminar";
            btnIrEliminar.UseVisualStyleBackColor = true;
            // 
            // btnIrEditar
            // 
            btnIrEditar.Location = new Point(542, 244);
            btnIrEditar.Name = "btnIrEditar";
            btnIrEditar.Size = new Size(654, 227);
            btnIrEditar.TabIndex = 4;
            btnIrEditar.Text = "Editar";
            btnIrEditar.UseVisualStyleBackColor = true;
            // 
            // btnIrAgregar
            // 
            btnIrAgregar.Location = new Point(542, 49);
            btnIrAgregar.Name = "btnIrAgregar";
            btnIrAgregar.Size = new Size(654, 189);
            btnIrAgregar.TabIndex = 3;
            btnIrAgregar.Text = "Agregar";
            btnIrAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1084, 13);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 32);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgCategorias
            // 
            dgCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategorias.Location = new Point(18, 13);
            dgCategorias.Name = "dgCategorias";
            dgCategorias.Size = new Size(518, 724);
            dgCategorias.TabIndex = 0;
            // 
            // tbCategorias
            // 
            tbCategorias.Controls.Add(tpCategoriasVer);
            tbCategorias.Controls.Add(tpCategoriasAgregarEditar);
            tbCategorias.Controls.Add(tpEliminar);
            tbCategorias.Location = new Point(-10, -25);
            tbCategorias.Name = "tbCategorias";
            tbCategorias.SelectedIndex = 0;
            tbCategorias.Size = new Size(1415, 900);
            tbCategorias.TabIndex = 0;
            // 
            // tpEliminar
            // 
            tpEliminar.Controls.Add(cbEliminarCategoria);
            tpEliminar.Controls.Add(btnEliminarCategoriaCancelar);
            tpEliminar.Controls.Add(btnEliminarCategoriaEliminar);
            tpEliminar.Controls.Add(lblElimimarCategoria);
            tpEliminar.Location = new Point(4, 24);
            tpEliminar.Name = "tpEliminar";
            tpEliminar.Padding = new Padding(3);
            tpEliminar.Size = new Size(1202, 759);
            tpEliminar.TabIndex = 3;
            tpEliminar.Text = "Eliminar categoria";
            tpEliminar.UseVisualStyleBackColor = true;
            // 
            // cbEliminarCategoria
            // 
            cbEliminarCategoria.BackColor = Color.WhiteSmoke;
            cbEliminarCategoria.BorderColor = Color.MediumSlateBlue;
            cbEliminarCategoria.BorderSize = 1;
            cbEliminarCategoria.DropDownStyle = ComboBoxStyle.DropDown;
            cbEliminarCategoria.Font = new Font("Segoe UI", 10F);
            cbEliminarCategoria.ForeColor = Color.DimGray;
            cbEliminarCategoria.IconColor = Color.MediumSlateBlue;
            cbEliminarCategoria.ListBackColor = Color.FromArgb(230, 228, 245);
            cbEliminarCategoria.ListTextColor = Color.DimGray;
            cbEliminarCategoria.Location = new Point(318, 288);
            cbEliminarCategoria.MinimumSize = new Size(100, 30);
            cbEliminarCategoria.Name = "cbEliminarCategoria";
            cbEliminarCategoria.Padding = new Padding(1);
            cbEliminarCategoria.Size = new Size(592, 30);
            cbEliminarCategoria.TabIndex = 8;
            cbEliminarCategoria.Texts = "";
            // 
            // btnEliminarCategoriaCancelar
            // 
            btnEliminarCategoriaCancelar.Location = new Point(631, 335);
            btnEliminarCategoriaCancelar.Name = "btnEliminarCategoriaCancelar";
            btnEliminarCategoriaCancelar.Size = new Size(279, 68);
            btnEliminarCategoriaCancelar.TabIndex = 7;
            btnEliminarCategoriaCancelar.Text = "Cancelar";
            btnEliminarCategoriaCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCategoriaEliminar
            // 
            btnEliminarCategoriaEliminar.Location = new Point(318, 335);
            btnEliminarCategoriaEliminar.Name = "btnEliminarCategoriaEliminar";
            btnEliminarCategoriaEliminar.Size = new Size(307, 68);
            btnEliminarCategoriaEliminar.TabIndex = 6;
            btnEliminarCategoriaEliminar.Text = "Eliminar";
            btnEliminarCategoriaEliminar.UseVisualStyleBackColor = true;
            // 
            // lblElimimarCategoria
            // 
            lblElimimarCategoria.AutoSize = true;
            lblElimimarCategoria.Location = new Point(408, 259);
            lblElimimarCategoria.Name = "lblElimimarCategoria";
            lblElimimarCategoria.Size = new Size(438, 15);
            lblElimimarCategoria.TabIndex = 4;
            lblElimimarCategoria.Text = "La categoria \"inserte categoria\" al ser eliminada sera reemplazada por la categoria:";
            // 
            // CategoriasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 748);
            Controls.Add(tbCategorias);
            Name = "CategoriasView";
            Text = "CategoriasView";
            Load += CategoriasView_Load;
            tpCategoriasAgregarEditar.ResumeLayout(false);
            tpCategoriasAgregarEditar.PerformLayout();
            tpCategoriasVer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgCategorias).EndInit();
            tbCategorias.ResumeLayout(false);
            tpEliminar.ResumeLayout(false);
            tpEliminar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpCategoriasAgregarEditar;
        private Button btnGuardar;
        private Label lblGuardarEditar;
        private TabPage tpCategoriasVer;
        private Button btnIrEliminar;
        private Button btnIrEditar;
        private Button btnIrAgregar;
        private Button btnBuscar;
        private DataGridView dgCategorias;
        private TabControl tbCategorias;
        private Button btnRegresar;
        private TabPage tpEliminar;
        private Label lblElimimarCategoria;
        private Button btnEliminarCategoriaCancelar;
        private Button btnEliminarCategoriaEliminar;
        private ControlesPersonalizados.CustomComboBox cbEliminarCategoria;
        private ControlesPersonalizados.CustomTextBox txtBuscarCategoria;
        private ControlesPersonalizados.CustomTextBox txtNombreCategoria;
    }
}