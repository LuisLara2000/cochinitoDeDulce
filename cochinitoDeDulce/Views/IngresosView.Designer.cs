namespace cochinitoDeDulce.Views
{
    partial class IngresosView
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
            txtBuscarMarca = new TextBox();
            btnIrEliminarMarca = new Button();
            btnIrEditarMarca = new Button();
            btnIrAgregarMarca = new Button();
            btnBuscar = new Button();
            dgMarcas = new DataGridView();
            tpAgregarEditarMarca = new TabPage();
            txtAgregarEditar = new TextBox();
            lblAgregarEditar = new Label();
            btnRegresarEditarGuardar = new Button();
            btnGuardarEditar = new Button();
            tpEliminarMarca = new TabPage();
            btnCancelarEliminar = new Button();
            btnEliminarEliminar = new Button();
            cbMarcas = new ComboBox();
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
            tbMarca.Dock = DockStyle.Fill;
            tbMarca.Location = new Point(0, 0);
            tbMarca.Name = "tbMarca";
            tbMarca.SelectedIndex = 0;
            tbMarca.Size = new Size(800, 450);
            tbMarca.SizeMode = TabSizeMode.FillToRight;
            tbMarca.TabIndex = 1;
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
            tpBuscarMarca.Size = new Size(792, 422);
            tpBuscarMarca.TabIndex = 0;
            tpBuscarMarca.Text = "Todas las marcas";
            tpBuscarMarca.UseVisualStyleBackColor = true;
            // 
            // txtBuscarMarca
            // 
            txtBuscarMarca.Location = new Point(525, 7);
            txtBuscarMarca.Name = "txtBuscarMarca";
            txtBuscarMarca.Size = new Size(178, 23);
            txtBuscarMarca.TabIndex = 5;
            // 
            // btnIrEliminarMarca
            // 
            btnIrEliminarMarca.Location = new Point(525, 281);
            btnIrEliminarMarca.Name = "btnIrEliminarMarca";
            btnIrEliminarMarca.Size = new Size(259, 117);
            btnIrEliminarMarca.TabIndex = 4;
            btnIrEliminarMarca.Text = "Eliminar";
            btnIrEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // btnIrEditarMarca
            // 
            btnIrEditarMarca.Location = new Point(525, 158);
            btnIrEditarMarca.Name = "btnIrEditarMarca";
            btnIrEditarMarca.Size = new Size(259, 117);
            btnIrEditarMarca.TabIndex = 3;
            btnIrEditarMarca.Text = "Editar";
            btnIrEditarMarca.UseVisualStyleBackColor = true;
            // 
            // btnIrAgregarMarca
            // 
            btnIrAgregarMarca.Location = new Point(525, 35);
            btnIrAgregarMarca.Name = "btnIrAgregarMarca";
            btnIrAgregarMarca.Size = new Size(259, 117);
            btnIrAgregarMarca.TabIndex = 2;
            btnIrAgregarMarca.Text = "Agregar";
            btnIrAgregarMarca.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(709, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgMarcas
            // 
            dgMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMarcas.Location = new Point(8, 6);
            dgMarcas.Name = "dgMarcas";
            dgMarcas.Size = new Size(511, 392);
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
            tpAgregarEditarMarca.Size = new Size(644, 412);
            tpAgregarEditarMarca.TabIndex = 1;
            tpAgregarEditarMarca.Text = "AgregarEditar marca";
            tpAgregarEditarMarca.UseVisualStyleBackColor = true;
            // 
            // txtAgregarEditar
            // 
            txtAgregarEditar.Location = new Point(27, 193);
            txtAgregarEditar.Name = "txtAgregarEditar";
            txtAgregarEditar.Size = new Size(598, 23);
            txtAgregarEditar.TabIndex = 3;
            // 
            // lblAgregarEditar
            // 
            lblAgregarEditar.AutoSize = true;
            lblAgregarEditar.Location = new Point(314, 166);
            lblAgregarEditar.Name = "lblAgregarEditar";
            lblAgregarEditar.Size = new Size(38, 15);
            lblAgregarEditar.TabIndex = 2;
            lblAgregarEditar.Text = "label1";
            // 
            // btnRegresarEditarGuardar
            // 
            btnRegresarEditarGuardar.Location = new Point(329, 235);
            btnRegresarEditarGuardar.Name = "btnRegresarEditarGuardar";
            btnRegresarEditarGuardar.Size = new Size(296, 22);
            btnRegresarEditarGuardar.TabIndex = 1;
            btnRegresarEditarGuardar.Text = "Cancelar";
            btnRegresarEditarGuardar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.Location = new Point(27, 235);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(296, 22);
            btnGuardarEditar.TabIndex = 0;
            btnGuardarEditar.Text = "button5";
            btnGuardarEditar.UseVisualStyleBackColor = true;
            // 
            // tpEliminarMarca
            // 
            tpEliminarMarca.Controls.Add(btnCancelarEliminar);
            tpEliminarMarca.Controls.Add(btnEliminarEliminar);
            tpEliminarMarca.Controls.Add(cbMarcas);
            tpEliminarMarca.Controls.Add(lblEliminarMarca);
            tpEliminarMarca.Location = new Point(4, 24);
            tpEliminarMarca.Name = "tpEliminarMarca";
            tpEliminarMarca.Padding = new Padding(3);
            tpEliminarMarca.Size = new Size(644, 412);
            tpEliminarMarca.TabIndex = 2;
            tpEliminarMarca.Text = "Eliminar marca";
            tpEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // btnCancelarEliminar
            // 
            btnCancelarEliminar.Location = new Point(325, 225);
            btnCancelarEliminar.Name = "btnCancelarEliminar";
            btnCancelarEliminar.Size = new Size(298, 23);
            btnCancelarEliminar.TabIndex = 3;
            btnCancelarEliminar.Text = "Cancelar";
            btnCancelarEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEliminar
            // 
            btnEliminarEliminar.Location = new Point(24, 225);
            btnEliminarEliminar.Name = "btnEliminarEliminar";
            btnEliminarEliminar.Size = new Size(295, 23);
            btnEliminarEliminar.TabIndex = 2;
            btnEliminarEliminar.Text = "Eliminar";
            btnEliminarEliminar.UseVisualStyleBackColor = true;
            // 
            // cbMarcas
            // 
            cbMarcas.FormattingEnabled = true;
            cbMarcas.Location = new Point(24, 187);
            cbMarcas.Name = "cbMarcas";
            cbMarcas.Size = new Size(599, 23);
            cbMarcas.TabIndex = 1;
            // 
            // lblEliminarMarca
            // 
            lblEliminarMarca.AutoSize = true;
            lblEliminarMarca.Location = new Point(304, 164);
            lblEliminarMarca.Name = "lblEliminarMarca";
            lblEliminarMarca.Size = new Size(38, 15);
            lblEliminarMarca.TabIndex = 0;
            lblEliminarMarca.Text = "label2";
            // 
            // IngresosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbMarca);
            Name = "IngresosView";
            Text = "IngresosView";
            tbMarca.ResumeLayout(false);
            tpBuscarMarca.ResumeLayout(false);
            tpBuscarMarca.PerformLayout();
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
        private TextBox txtBuscarMarca;
        private Button btnIrEliminarMarca;
        private Button btnIrEditarMarca;
        private Button btnIrAgregarMarca;
        private Button btnBuscar;
        private DataGridView dgMarcas;
        private TabPage tpAgregarEditarMarca;
        private TextBox txtAgregarEditar;
        private Label lblAgregarEditar;
        private Button btnRegresarEditarGuardar;
        private Button btnGuardarEditar;
        private TabPage tpEliminarMarca;
        private Button btnCancelarEliminar;
        private Button btnEliminarEliminar;
        private ComboBox cbMarcas;
        private Label lblEliminarMarca;
    }
}