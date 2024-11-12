namespace cochinitoDeDulce.Views
{
    partial class TiposView
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
            tbTipo = new TabControl();
            tpBuscarTipo = new TabPage();
            txtBuscarTipo = new ControlesPersonalizados.CustomTextBox();
            btnIrEliminarTipo = new Button();
            btnIrEditarTipo = new Button();
            btnIrAgregarTipo = new Button();
            btnBuscar = new Button();
            dgTipos = new DataGridView();
            tpAgregarEditarTipo = new TabPage();
            txtAgregarEditar = new ControlesPersonalizados.CustomTextBox();
            lblAgregarEditar = new Label();
            btnRegresarEditarGuardar = new Button();
            btnGuardarEditar = new Button();
            tpEliminarTipo = new TabPage();
            cbTipos = new ControlesPersonalizados.CustomComboBox();
            btnCancelarEliminar = new Button();
            btnEliminarEliminar = new Button();
            lblEliminarTipo = new Label();
            tbTipo.SuspendLayout();
            tpBuscarTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTipos).BeginInit();
            tpAgregarEditarTipo.SuspendLayout();
            tpEliminarTipo.SuspendLayout();
            SuspendLayout();
            // 
            // tbTipo
            // 
            tbTipo.Controls.Add(tpBuscarTipo);
            tbTipo.Controls.Add(tpAgregarEditarTipo);
            tbTipo.Controls.Add(tpEliminarTipo);
            tbTipo.Location = new Point(-10, -25);
            tbTipo.Name = "tbTipo";
            tbTipo.SelectedIndex = 0;
            tbTipo.Size = new Size(1415, 900);
            tbTipo.SizeMode = TabSizeMode.FillToRight;
            tbTipo.TabIndex = 2;
            // 
            // tpBuscarTipo
            // 
            tpBuscarTipo.Controls.Add(txtBuscarTipo);
            tpBuscarTipo.Controls.Add(btnIrEliminarTipo);
            tpBuscarTipo.Controls.Add(btnIrEditarTipo);
            tpBuscarTipo.Controls.Add(btnIrAgregarTipo);
            tpBuscarTipo.Controls.Add(btnBuscar);
            tpBuscarTipo.Controls.Add(dgTipos);
            tpBuscarTipo.Location = new Point(4, 24);
            tpBuscarTipo.Name = "tpBuscarTipo";
            tpBuscarTipo.Padding = new Padding(3);
            tpBuscarTipo.Size = new Size(1407, 872);
            tpBuscarTipo.TabIndex = 0;
            tpBuscarTipo.Text = "Todos los tipos";
            tpBuscarTipo.UseVisualStyleBackColor = true;
            // 
            // txtBuscarTipo
            // 
            txtBuscarTipo.BorderColor = Color.MediumSlateBlue;
            txtBuscarTipo.BorderFocusColor = Color.HotPink;
            txtBuscarTipo.BorderSize = 2;
            txtBuscarTipo.Location = new Point(769, 9);
            txtBuscarTipo.Multiline = false;
            txtBuscarTipo.Name = "txtBuscarTipo";
            txtBuscarTipo.Padding = new Padding(7);
            txtBuscarTipo.PasswordChar = false;
            txtBuscarTipo.Size = new Size(338, 30);
            txtBuscarTipo.TabIndex = 6;
            txtBuscarTipo.Texts = "";
            txtBuscarTipo.UnderlinedStyle = false;
            // 
            // btnIrEliminarTipo
            // 
            btnIrEliminarTipo.Location = new Point(769, 551);
            btnIrEliminarTipo.Name = "btnIrEliminarTipo";
            btnIrEliminarTipo.Size = new Size(419, 186);
            btnIrEliminarTipo.TabIndex = 4;
            btnIrEliminarTipo.Text = "Eliminar";
            btnIrEliminarTipo.UseVisualStyleBackColor = true;
            // 
            // btnIrEditarTipo
            // 
            btnIrEditarTipo.Location = new Point(769, 337);
            btnIrEditarTipo.Name = "btnIrEditarTipo";
            btnIrEditarTipo.Size = new Size(419, 208);
            btnIrEditarTipo.TabIndex = 3;
            btnIrEditarTipo.Text = "Editar";
            btnIrEditarTipo.UseVisualStyleBackColor = true;
            // 
            // btnIrAgregarTipo
            // 
            btnIrAgregarTipo.Location = new Point(769, 45);
            btnIrAgregarTipo.Name = "btnIrAgregarTipo";
            btnIrAgregarTipo.Size = new Size(419, 286);
            btnIrAgregarTipo.TabIndex = 2;
            btnIrAgregarTipo.Text = "Agregar";
            btnIrAgregarTipo.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1111, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(84, 30);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgTipos
            // 
            dgTipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTipos.Location = new Point(15, 6);
            dgTipos.Name = "dgTipos";
            dgTipos.Size = new Size(748, 731);
            dgTipos.TabIndex = 0;
            // 
            // tpAgregarEditarTipo
            // 
            tpAgregarEditarTipo.Controls.Add(txtAgregarEditar);
            tpAgregarEditarTipo.Controls.Add(lblAgregarEditar);
            tpAgregarEditarTipo.Controls.Add(btnRegresarEditarGuardar);
            tpAgregarEditarTipo.Controls.Add(btnGuardarEditar);
            tpAgregarEditarTipo.Location = new Point(4, 24);
            tpAgregarEditarTipo.Name = "tpAgregarEditarTipo";
            tpAgregarEditarTipo.Padding = new Padding(3);
            tpAgregarEditarTipo.Size = new Size(1407, 872);
            tpAgregarEditarTipo.TabIndex = 1;
            tpAgregarEditarTipo.Text = "AgregarEditar tipo";
            tpAgregarEditarTipo.UseVisualStyleBackColor = true;
            tpAgregarEditarTipo.UseWaitCursor = true;
            // 
            // txtAgregarEditar
            // 
            txtAgregarEditar.BorderColor = Color.MediumSlateBlue;
            txtAgregarEditar.BorderFocusColor = Color.HotPink;
            txtAgregarEditar.BorderSize = 2;
            txtAgregarEditar.Location = new Point(251, 346);
            txtAgregarEditar.Multiline = false;
            txtAgregarEditar.Name = "txtAgregarEditar";
            txtAgregarEditar.Padding = new Padding(7);
            txtAgregarEditar.PasswordChar = false;
            txtAgregarEditar.Size = new Size(734, 30);
            txtAgregarEditar.TabIndex = 4;
            txtAgregarEditar.Texts = "";
            txtAgregarEditar.UnderlinedStyle = false;
            txtAgregarEditar.UseWaitCursor = true;
            // 
            // lblAgregarEditar
            // 
            lblAgregarEditar.AutoSize = true;
            lblAgregarEditar.Location = new Point(607, 317);
            lblAgregarEditar.Name = "lblAgregarEditar";
            lblAgregarEditar.Size = new Size(38, 15);
            lblAgregarEditar.TabIndex = 2;
            lblAgregarEditar.Text = "label1";
            lblAgregarEditar.UseWaitCursor = true;
            // 
            // btnRegresarEditarGuardar
            // 
            btnRegresarEditarGuardar.Location = new Point(631, 382);
            btnRegresarEditarGuardar.Name = "btnRegresarEditarGuardar";
            btnRegresarEditarGuardar.Size = new Size(364, 37);
            btnRegresarEditarGuardar.TabIndex = 1;
            btnRegresarEditarGuardar.Text = "Cancelar";
            btnRegresarEditarGuardar.UseVisualStyleBackColor = true;
            btnRegresarEditarGuardar.UseWaitCursor = true;
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.Location = new Point(251, 382);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(374, 37);
            btnGuardarEditar.TabIndex = 0;
            btnGuardarEditar.Text = "button5";
            btnGuardarEditar.UseVisualStyleBackColor = true;
            btnGuardarEditar.UseWaitCursor = true;
            // 
            // tpEliminarTipo
            // 
            tpEliminarTipo.Controls.Add(cbTipos);
            tpEliminarTipo.Controls.Add(btnCancelarEliminar);
            tpEliminarTipo.Controls.Add(btnEliminarEliminar);
            tpEliminarTipo.Controls.Add(lblEliminarTipo);
            tpEliminarTipo.Location = new Point(4, 24);
            tpEliminarTipo.Name = "tpEliminarTipo";
            tpEliminarTipo.Padding = new Padding(3);
            tpEliminarTipo.Size = new Size(1407, 872);
            tpEliminarTipo.TabIndex = 2;
            tpEliminarTipo.Text = "Eliminar tipo";
            tpEliminarTipo.UseVisualStyleBackColor = true;
            // 
            // cbTipos
            // 
            cbTipos.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTipos.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbTipos.BackColor = Color.WhiteSmoke;
            cbTipos.BorderColor = Color.MediumSlateBlue;
            cbTipos.BorderSize = 1;
            cbTipos.DropDownStyle = ComboBoxStyle.DropDown;
            cbTipos.Font = new Font("Segoe UI", 10F);
            cbTipos.ForeColor = Color.DimGray;
            cbTipos.IconColor = Color.MediumSlateBlue;
            cbTipos.ListBackColor = Color.FromArgb(230, 228, 245);
            cbTipos.ListTextColor = Color.DimGray;
            cbTipos.Location = new Point(296, 381);
            cbTipos.MinimumSize = new Size(100, 15);
            cbTipos.Name = "cbTipos";
            cbTipos.Padding = new Padding(1);
            cbTipos.Size = new Size(599, 30);
            cbTipos.TabIndex = 4;
            cbTipos.Texts = "";
            // 
            // btnCancelarEliminar
            // 
            btnCancelarEliminar.Location = new Point(597, 417);
            btnCancelarEliminar.Name = "btnCancelarEliminar";
            btnCancelarEliminar.Size = new Size(298, 23);
            btnCancelarEliminar.TabIndex = 3;
            btnCancelarEliminar.Text = "Cancelar";
            btnCancelarEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEliminar
            // 
            btnEliminarEliminar.Location = new Point(296, 417);
            btnEliminarEliminar.Name = "btnEliminarEliminar";
            btnEliminarEliminar.Size = new Size(295, 23);
            btnEliminarEliminar.TabIndex = 2;
            btnEliminarEliminar.Text = "Elininar";
            btnEliminarEliminar.UseVisualStyleBackColor = true;
            // 
            // lblEliminarTipo
            // 
            lblEliminarTipo.AutoSize = true;
            lblEliminarTipo.Location = new Point(579, 352);
            lblEliminarTipo.Name = "lblEliminarTipo";
            lblEliminarTipo.Size = new Size(38, 15);
            lblEliminarTipo.TabIndex = 0;
            lblEliminarTipo.Text = "label2";
            // 
            // TiposView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 748);
            Controls.Add(tbTipo);
            Name = "TiposView";
            Text = "ViewTipos";
            tbTipo.ResumeLayout(false);
            tpBuscarTipo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgTipos).EndInit();
            tpAgregarEditarTipo.ResumeLayout(false);
            tpAgregarEditarTipo.PerformLayout();
            tpEliminarTipo.ResumeLayout(false);
            tpEliminarTipo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbTipo;
        private TabPage tpBuscarTipo;
        private Button btnIrEliminarTipo;
        private Button btnIrEditarTipo;
        private Button btnIrAgregarTipo;
        private Button btnBuscar;
        private DataGridView dgTipos;
        private TabPage tpAgregarEditarTipo;
        private Label lblAgregarEditar;
        private Button btnRegresarEditarGuardar;
        private Button btnGuardarEditar;
        private TabPage tpEliminarTipo;
        private Button btnCancelarEliminar;
        private Button btnEliminarEliminar;
        private Label lblEliminarTipo;
        private ControlesPersonalizados.CustomComboBox cbTipos;
        private ControlesPersonalizados.CustomTextBox txtBuscarTipo;
        private ControlesPersonalizados.CustomTextBox txtAgregarEditar;
    }
}