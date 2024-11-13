namespace cochinitoDeDulce.Views
{
    partial class LugaresView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tbLugar = new TabControl();
            tpBuscarLugar = new TabPage();
            txtBuscarMarca = new ControlesPersonalizados.CustomTextBox();
            btnIrEliminarLugar = new Button();
            btnIrEditarLugar = new Button();
            btnIrAgregarLugar = new Button();
            btnBuscar = new Button();
            dgLugar = new DataGridView();
            tpAgregarEditarLugar = new TabPage();
            txtAgregarEditar = new ControlesPersonalizados.CustomTextBox();
            lblAgregarEditar = new Label();
            btnRegresarEditarGuardar = new Button();
            btnGuardarEditar = new Button();
            tpEliminarLugar = new TabPage();
            cbLugares = new ControlesPersonalizados.CustomComboBox();
            btnCancelarLugar = new Button();
            btnEliminarEliminar = new Button();
            lblEliminarLugar = new Label();
            tbLugar.SuspendLayout();
            tpBuscarLugar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLugar).BeginInit();
            tpAgregarEditarLugar.SuspendLayout();
            tpEliminarLugar.SuspendLayout();
            SuspendLayout();
            // 
            // tbLugar
            // 
            tbLugar.Controls.Add(tpBuscarLugar);
            tbLugar.Controls.Add(tpAgregarEditarLugar);
            tbLugar.Controls.Add(tpEliminarLugar);
            tbLugar.Location = new Point(-10, -25);
            tbLugar.Name = "tbLugar";
            tbLugar.SelectedIndex = 0;
            tbLugar.Size = new Size(1415, 900);
            tbLugar.SizeMode = TabSizeMode.FillToRight;
            tbLugar.TabIndex = 1;
            // 
            // tpBuscarLugar
            // 
            tpBuscarLugar.Controls.Add(txtBuscarMarca);
            tpBuscarLugar.Controls.Add(btnIrEliminarLugar);
            tpBuscarLugar.Controls.Add(btnIrEditarLugar);
            tpBuscarLugar.Controls.Add(btnIrAgregarLugar);
            tpBuscarLugar.Controls.Add(btnBuscar);
            tpBuscarLugar.Controls.Add(dgLugar);
            tpBuscarLugar.Location = new Point(4, 24);
            tpBuscarLugar.Name = "tpBuscarLugar";
            tpBuscarLugar.Padding = new Padding(3);
            tpBuscarLugar.Size = new Size(1407, 872);
            tpBuscarLugar.TabIndex = 0;
            tpBuscarLugar.Text = "Todos los lugares";
            tpBuscarLugar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarMarca
            // 
            txtBuscarMarca.BorderColor = Color.MediumSlateBlue;
            txtBuscarMarca.BorderFocusColor = Color.HotPink;
            txtBuscarMarca.BorderSize = 2;
            txtBuscarMarca.Location = new Point(937, 10);
            txtBuscarMarca.Multiline = false;
            txtBuscarMarca.Name = "txtBuscarMarca";
            txtBuscarMarca.Padding = new Padding(7);
            txtBuscarMarca.PasswordChar = false;
            txtBuscarMarca.Size = new Size(159, 30);
            txtBuscarMarca.TabIndex = 6;
            txtBuscarMarca.Texts = "";
            txtBuscarMarca.UnderlinedStyle = false;
            // 
            // btnIrEliminarLugar
            // 
            btnIrEliminarLugar.Location = new Point(937, 490);
            btnIrEliminarLugar.Name = "btnIrEliminarLugar";
            btnIrEliminarLugar.Size = new Size(251, 249);
            btnIrEliminarLugar.TabIndex = 4;
            btnIrEliminarLugar.Text = "Eliminar";
            btnIrEliminarLugar.UseVisualStyleBackColor = true;
            // 
            // btnIrEditarLugar
            // 
            btnIrEditarLugar.Location = new Point(937, 245);
            btnIrEditarLugar.Name = "btnIrEditarLugar";
            btnIrEditarLugar.Size = new Size(251, 239);
            btnIrEditarLugar.TabIndex = 3;
            btnIrEditarLugar.Text = "Editar";
            btnIrEditarLugar.UseVisualStyleBackColor = true;
            // 
            // btnIrAgregarLugar
            // 
            btnIrAgregarLugar.Location = new Point(937, 46);
            btnIrAgregarLugar.Name = "btnIrAgregarLugar";
            btnIrAgregarLugar.Size = new Size(251, 193);
            btnIrAgregarLugar.TabIndex = 2;
            btnIrAgregarLugar.Text = "Agregar";
            btnIrAgregarLugar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1102, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 30);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgLugar
            // 
            dgLugar.BackgroundColor = Color.FromArgb(52, 52, 52);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 113, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(52, 52, 52);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgLugar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgLugar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLugar.Location = new Point(12, 7);
            dgLugar.Name = "dgLugar";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 113, 0);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(52, 52, 52);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgLugar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(52, 52, 52);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 113, 0);
            dgLugar.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgLugar.Size = new Size(919, 732);
            dgLugar.TabIndex = 0;
            // 
            // tpAgregarEditarLugar
            // 
            tpAgregarEditarLugar.Controls.Add(txtAgregarEditar);
            tpAgregarEditarLugar.Controls.Add(lblAgregarEditar);
            tpAgregarEditarLugar.Controls.Add(btnRegresarEditarGuardar);
            tpAgregarEditarLugar.Controls.Add(btnGuardarEditar);
            tpAgregarEditarLugar.Location = new Point(4, 24);
            tpAgregarEditarLugar.Name = "tpAgregarEditarLugar";
            tpAgregarEditarLugar.Padding = new Padding(3);
            tpAgregarEditarLugar.Size = new Size(1407, 872);
            tpAgregarEditarLugar.TabIndex = 1;
            tpAgregarEditarLugar.Text = "AgregarEditar marca";
            tpAgregarEditarLugar.UseVisualStyleBackColor = true;
            // 
            // txtAgregarEditar
            // 
            txtAgregarEditar.BorderColor = Color.MediumSlateBlue;
            txtAgregarEditar.BorderFocusColor = Color.HotPink;
            txtAgregarEditar.BorderSize = 2;
            txtAgregarEditar.Location = new Point(313, 336);
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
            lblAgregarEditar.Location = new Point(600, 312);
            lblAgregarEditar.Name = "lblAgregarEditar";
            lblAgregarEditar.Size = new Size(38, 15);
            lblAgregarEditar.TabIndex = 2;
            lblAgregarEditar.Text = "label1";
            // 
            // btnRegresarEditarGuardar
            // 
            btnRegresarEditarGuardar.Location = new Point(615, 381);
            btnRegresarEditarGuardar.Name = "btnRegresarEditarGuardar";
            btnRegresarEditarGuardar.Size = new Size(296, 22);
            btnRegresarEditarGuardar.TabIndex = 1;
            btnRegresarEditarGuardar.Text = "Cancelar";
            btnRegresarEditarGuardar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.Location = new Point(313, 381);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(296, 22);
            btnGuardarEditar.TabIndex = 0;
            btnGuardarEditar.Text = "button5";
            btnGuardarEditar.UseVisualStyleBackColor = true;
            // 
            // tpEliminarLugar
            // 
            tpEliminarLugar.Controls.Add(cbLugares);
            tpEliminarLugar.Controls.Add(btnCancelarLugar);
            tpEliminarLugar.Controls.Add(btnEliminarEliminar);
            tpEliminarLugar.Controls.Add(lblEliminarLugar);
            tpEliminarLugar.Location = new Point(4, 24);
            tpEliminarLugar.Name = "tpEliminarLugar";
            tpEliminarLugar.Padding = new Padding(3);
            tpEliminarLugar.Size = new Size(1407, 872);
            tpEliminarLugar.TabIndex = 2;
            tpEliminarLugar.Text = "Eliminar lugar";
            tpEliminarLugar.UseVisualStyleBackColor = true;
            // 
            // cbLugares
            // 
            cbLugares.BackColor = Color.WhiteSmoke;
            cbLugares.BorderColor = Color.MediumSlateBlue;
            cbLugares.BorderSize = 1;
            cbLugares.DropDownStyle = ComboBoxStyle.DropDown;
            cbLugares.Font = new Font("Segoe UI", 10F);
            cbLugares.ForeColor = Color.DimGray;
            cbLugares.IconColor = Color.MediumSlateBlue;
            cbLugares.ListBackColor = Color.FromArgb(230, 228, 245);
            cbLugares.ListTextColor = Color.DimGray;
            cbLugares.Location = new Point(272, 362);
            cbLugares.MinimumSize = new Size(100, 30);
            cbLugares.Name = "cbLugares";
            cbLugares.Padding = new Padding(1);
            cbLugares.Size = new Size(599, 30);
            cbLugares.TabIndex = 4;
            cbLugares.Texts = "";
            // 
            // btnCancelarLugar
            // 
            btnCancelarLugar.Location = new Point(573, 398);
            btnCancelarLugar.Name = "btnCancelarLugar";
            btnCancelarLugar.Size = new Size(298, 23);
            btnCancelarLugar.TabIndex = 3;
            btnCancelarLugar.Text = "Cancelar";
            btnCancelarLugar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEliminar
            // 
            btnEliminarEliminar.Location = new Point(272, 398);
            btnEliminarEliminar.Name = "btnEliminarEliminar";
            btnEliminarEliminar.Size = new Size(295, 23);
            btnEliminarEliminar.TabIndex = 2;
            btnEliminarEliminar.Text = "Eliminar";
            btnEliminarEliminar.UseVisualStyleBackColor = true;
            // 
            // lblEliminarLugar
            // 
            lblEliminarLugar.AutoSize = true;
            lblEliminarLugar.Location = new Point(552, 337);
            lblEliminarLugar.Name = "lblEliminarLugar";
            lblEliminarLugar.Size = new Size(38, 15);
            lblEliminarLugar.TabIndex = 0;
            lblEliminarLugar.Text = "label2";
            // 
            // LugaresView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 748);
            Controls.Add(tbLugar);
            Name = "LugaresView";
            Text = "ViewLugares";
            tbLugar.ResumeLayout(false);
            tpBuscarLugar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgLugar).EndInit();
            tpAgregarEditarLugar.ResumeLayout(false);
            tpAgregarEditarLugar.PerformLayout();
            tpEliminarLugar.ResumeLayout(false);
            tpEliminarLugar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbLugar;
        private TabPage tpBuscarLugar;
        private Button btnIrEliminarLugar;
        private Button btnIrEditarLugar;
        private Button btnIrAgregarLugar;
        private Button btnBuscar;
        private DataGridView dgLugar;
        private TabPage tpAgregarEditarLugar;
        private Label lblAgregarEditar;
        private Button btnRegresarEditarGuardar;
        private Button btnGuardarEditar;
        private TabPage tpEliminarLugar;
        private Button btnCancelarLugar;
        private Button btnEliminarEliminar;
        private Label lblEliminarLugar;
        private ControlesPersonalizados.CustomComboBox cbLugares;
        private ControlesPersonalizados.CustomTextBox txtBuscarMarca;
        private ControlesPersonalizados.CustomTextBox txtAgregarEditar;
    }
}