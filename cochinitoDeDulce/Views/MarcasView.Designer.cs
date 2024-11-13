namespace cochinitoDeDulce.Views
{
    partial class MarcasView
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
            tbMarca = new TabControl();
            tpBuscarMarca = new TabPage();
            txtBuscarMarca = new ControlesPersonalizados.CustomTextBox();
            btnIrEliminarMarca = new Button();
            btnIrEditarMarca = new Button();
            btnIrAgregarMarca = new Button();
            btnBuscar = new Button();
            dgMarcas = new DataGridView();
            tpAgregarEditarMarca = new TabPage();
            txtAgregarEditar = new ControlesPersonalizados.CustomTextBox();
            lblAgregarEditar = new Label();
            btnRegresarEditarGuardar = new Button();
            btnGuardarEditar = new Button();
            tpEliminarMarca = new TabPage();
            cbMarcas = new ControlesPersonalizados.CustomComboBox();
            btnCancelarEliminar = new Button();
            btnEliminarEliminar = new Button();
            lblEliminarMarca = new Label();
            tbMarca.SuspendLayout();
            tpBuscarMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMarcas).BeginInit();
            tpAgregarEditarMarca.SuspendLayout();
            tpEliminarMarca.SuspendLayout();
            SuspendLayout();
            // 
            // tbMarca
            // 
            tbMarca.Controls.Add(tpBuscarMarca);
            tbMarca.Controls.Add(tpAgregarEditarMarca);
            tbMarca.Controls.Add(tpEliminarMarca);
            tbMarca.Location = new Point(-10, -25);
            tbMarca.Name = "tbMarca";
            tbMarca.SelectedIndex = 0;
            tbMarca.Size = new Size(1415, 900);
            tbMarca.SizeMode = TabSizeMode.FillToRight;
            tbMarca.TabIndex = 0;
            tbMarca.SelectedIndexChanged += tbMarca_SelectedIndexChanged;
            // 
            // tpBuscarMarca
            // 
            tpBuscarMarca.Controls.Add(txtBuscarMarca);
            tpBuscarMarca.Controls.Add(btnIrEliminarMarca);
            tpBuscarMarca.Controls.Add(btnIrEditarMarca);
            tpBuscarMarca.Controls.Add(btnIrAgregarMarca);
            tpBuscarMarca.Controls.Add(btnBuscar);
            tpBuscarMarca.Controls.Add(dgMarcas);
            tpBuscarMarca.Location = new Point(4, 24);
            tpBuscarMarca.Name = "tpBuscarMarca";
            tpBuscarMarca.Padding = new Padding(3);
            tpBuscarMarca.Size = new Size(1407, 872);
            tpBuscarMarca.TabIndex = 0;
            tpBuscarMarca.Text = "Todas las marcas";
            tpBuscarMarca.UseVisualStyleBackColor = true;
            // 
            // txtBuscarMarca
            // 
            txtBuscarMarca.BorderColor = Color.MediumSlateBlue;
            txtBuscarMarca.BorderFocusColor = Color.HotPink;
            txtBuscarMarca.BorderSize = 2;
            txtBuscarMarca.Location = new Point(938, 7);
            txtBuscarMarca.Multiline = false;
            txtBuscarMarca.Name = "txtBuscarMarca";
            txtBuscarMarca.Padding = new Padding(7);
            txtBuscarMarca.PasswordChar = false;
            txtBuscarMarca.Size = new Size(169, 30);
            txtBuscarMarca.TabIndex = 6;
            txtBuscarMarca.Texts = "";
            txtBuscarMarca.UnderlinedStyle = false;
            // 
            // btnIrEliminarMarca
            // 
            btnIrEliminarMarca.Location = new Point(938, 553);
            btnIrEliminarMarca.Name = "btnIrEliminarMarca";
            btnIrEliminarMarca.Size = new Size(250, 184);
            btnIrEliminarMarca.TabIndex = 4;
            btnIrEliminarMarca.Text = "Eliminar";
            btnIrEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // btnIrEditarMarca
            // 
            btnIrEditarMarca.Location = new Point(938, 339);
            btnIrEditarMarca.Name = "btnIrEditarMarca";
            btnIrEditarMarca.Size = new Size(250, 208);
            btnIrEditarMarca.TabIndex = 3;
            btnIrEditarMarca.Text = "Editar";
            btnIrEditarMarca.UseVisualStyleBackColor = true;
            // 
            // btnIrAgregarMarca
            // 
            btnIrAgregarMarca.Location = new Point(938, 42);
            btnIrAgregarMarca.Name = "btnIrAgregarMarca";
            btnIrAgregarMarca.Size = new Size(250, 293);
            btnIrAgregarMarca.TabIndex = 2;
            btnIrAgregarMarca.Text = "Agregar";
            btnIrAgregarMarca.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1113, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 30);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgMarcas
            // 
            dgMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMarcas.Location = new Point(15, 7);
            dgMarcas.Name = "dgMarcas";
            dgMarcas.Size = new Size(917, 730);
            dgMarcas.TabIndex = 0;
            // 
            // tpAgregarEditarMarca
            // 
            tpAgregarEditarMarca.Controls.Add(txtAgregarEditar);
            tpAgregarEditarMarca.Controls.Add(lblAgregarEditar);
            tpAgregarEditarMarca.Controls.Add(btnRegresarEditarGuardar);
            tpAgregarEditarMarca.Controls.Add(btnGuardarEditar);
            tpAgregarEditarMarca.Location = new Point(4, 24);
            tpAgregarEditarMarca.Name = "tpAgregarEditarMarca";
            tpAgregarEditarMarca.Padding = new Padding(3);
            tpAgregarEditarMarca.Size = new Size(1407, 872);
            tpAgregarEditarMarca.TabIndex = 1;
            tpAgregarEditarMarca.Text = "AgregarEditar marca";
            tpAgregarEditarMarca.UseVisualStyleBackColor = true;
            // 
            // txtAgregarEditar
            // 
            txtAgregarEditar.BorderColor = Color.MediumSlateBlue;
            txtAgregarEditar.BorderFocusColor = Color.HotPink;
            txtAgregarEditar.BorderSize = 2;
            txtAgregarEditar.Location = new Point(295, 370);
            txtAgregarEditar.Multiline = false;
            txtAgregarEditar.Name = "txtAgregarEditar";
            txtAgregarEditar.Padding = new Padding(7);
            txtAgregarEditar.PasswordChar = false;
            txtAgregarEditar.Size = new Size(598, 30);
            txtAgregarEditar.TabIndex = 4;
            txtAgregarEditar.Texts = "";
            txtAgregarEditar.UnderlinedStyle = false;
            // 
            // lblAgregarEditar
            // 
            lblAgregarEditar.AutoSize = true;
            lblAgregarEditar.Location = new Point(579, 334);
            lblAgregarEditar.Name = "lblAgregarEditar";
            lblAgregarEditar.Size = new Size(38, 15);
            lblAgregarEditar.TabIndex = 2;
            lblAgregarEditar.Text = "label1";
            // 
            // btnRegresarEditarGuardar
            // 
            btnRegresarEditarGuardar.Location = new Point(597, 406);
            btnRegresarEditarGuardar.Name = "btnRegresarEditarGuardar";
            btnRegresarEditarGuardar.Size = new Size(296, 22);
            btnRegresarEditarGuardar.TabIndex = 1;
            btnRegresarEditarGuardar.Text = "Cancelar";
            btnRegresarEditarGuardar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.Location = new Point(295, 406);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(296, 22);
            btnGuardarEditar.TabIndex = 0;
            btnGuardarEditar.Text = "button5";
            btnGuardarEditar.UseVisualStyleBackColor = true;
            // 
            // tpEliminarMarca
            // 
            tpEliminarMarca.Controls.Add(cbMarcas);
            tpEliminarMarca.Controls.Add(btnCancelarEliminar);
            tpEliminarMarca.Controls.Add(btnEliminarEliminar);
            tpEliminarMarca.Controls.Add(lblEliminarMarca);
            tpEliminarMarca.Location = new Point(4, 24);
            tpEliminarMarca.Name = "tpEliminarMarca";
            tpEliminarMarca.Padding = new Padding(3);
            tpEliminarMarca.Size = new Size(1407, 872);
            tpEliminarMarca.TabIndex = 2;
            tpEliminarMarca.Text = "Eliminar marca";
            tpEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // cbMarcas
            // 
            cbMarcas.BackColor = Color.WhiteSmoke;
            cbMarcas.BorderColor = Color.MediumSlateBlue;
            cbMarcas.BorderSize = 1;
            cbMarcas.DropDownStyle = ComboBoxStyle.DropDown;
            cbMarcas.Font = new Font("Segoe UI", 10F);
            cbMarcas.ForeColor = Color.DimGray;
            cbMarcas.IconColor = Color.MediumSlateBlue;
            cbMarcas.ListBackColor = Color.FromArgb(230, 228, 245);
            cbMarcas.ListTextColor = Color.DimGray;
            cbMarcas.Location = new Point(326, 348);
            cbMarcas.MinimumSize = new Size(100, 30);
            cbMarcas.Name = "cbMarcas";
            cbMarcas.Padding = new Padding(1);
            cbMarcas.Size = new Size(599, 30);
            cbMarcas.TabIndex = 4;
            cbMarcas.Texts = "";
            // 
            // btnCancelarEliminar
            // 
            btnCancelarEliminar.Location = new Point(627, 384);
            btnCancelarEliminar.Name = "btnCancelarEliminar";
            btnCancelarEliminar.Size = new Size(298, 23);
            btnCancelarEliminar.TabIndex = 3;
            btnCancelarEliminar.Text = "Cancelar";
            btnCancelarEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEliminar
            // 
            btnEliminarEliminar.Location = new Point(326, 384);
            btnEliminarEliminar.Name = "btnEliminarEliminar";
            btnEliminarEliminar.Size = new Size(295, 23);
            btnEliminarEliminar.TabIndex = 2;
            btnEliminarEliminar.Text = "Eliminar";
            btnEliminarEliminar.UseVisualStyleBackColor = true;
            // 
            // lblEliminarMarca
            // 
            lblEliminarMarca.AutoSize = true;
            lblEliminarMarca.Location = new Point(603, 320);
            lblEliminarMarca.Name = "lblEliminarMarca";
            lblEliminarMarca.Size = new Size(38, 15);
            lblEliminarMarca.TabIndex = 0;
            lblEliminarMarca.Text = "label2";
            // 
            // MarcasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 748);
            Controls.Add(tbMarca);
            Name = "MarcasView";
            Text = "MarcasView";
            tbMarca.ResumeLayout(false);
            tpBuscarMarca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgMarcas).EndInit();
            tpAgregarEditarMarca.ResumeLayout(false);
            tpAgregarEditarMarca.PerformLayout();
            tpEliminarMarca.ResumeLayout(false);
            tpEliminarMarca.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbMarca;
        private TabPage tpBuscarMarca;
        private TabPage tpAgregarEditarMarca;
        private TabPage tpEliminarMarca;
        private Button btnIrEliminarMarca;
        private Button btnIrEditarMarca;
        private Button btnIrAgregarMarca;
        private Button btnBuscar;
        private DataGridView dgMarcas;
        private Label lblAgregarEditar;
        private Button btnRegresarEditarGuardar;
        private Button btnGuardarEditar;
        private Label lblEliminarMarca;
        private Button btnCancelarEliminar;
        private Button btnEliminarEliminar;
        private ControlesPersonalizados.CustomComboBox cbMarcas;
        private ControlesPersonalizados.CustomTextBox txtBuscarMarca;
        private ControlesPersonalizados.CustomTextBox txtAgregarEditar;
    }
}