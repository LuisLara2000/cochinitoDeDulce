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
            tbLugar = new TabControl();
            tpBuscarLugar = new TabPage();
            txtBuscarMarca = new TextBox();
            btnIrEliminarLugar = new Button();
            btnIrEditarLugar = new Button();
            btnIrAgregarLugar = new Button();
            btnBuscar = new Button();
            dgLugar = new DataGridView();
            tpAgregarEditarLugar = new TabPage();
            txtAgregarEditar = new TextBox();
            lblAgregarEditar = new Label();
            btnRegresarEditarGuardar = new Button();
            btnGuardarEditar = new Button();
            tpEliminarLugar = new TabPage();
            btnCancelarLugar = new Button();
            btnEliminarEliminar = new Button();
            cbLugares = new ComboBox();
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
            tbLugar.Dock = DockStyle.Fill;
            tbLugar.Location = new Point(0, 0);
            tbLugar.Name = "tbLugar";
            tbLugar.SelectedIndex = 0;
            tbLugar.Size = new Size(657, 450);
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
            tpBuscarLugar.Size = new Size(649, 422);
            tpBuscarLugar.TabIndex = 0;
            tpBuscarLugar.Text = "Todos los lugares";
            tpBuscarLugar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarMarca
            // 
            txtBuscarMarca.Location = new Point(377, 6);
            txtBuscarMarca.Name = "txtBuscarMarca";
            txtBuscarMarca.Size = new Size(178, 23);
            txtBuscarMarca.TabIndex = 5;
            // 
            // btnIrEliminarLugar
            // 
            btnIrEliminarLugar.Location = new Point(377, 281);
            btnIrEliminarLugar.Name = "btnIrEliminarLugar";
            btnIrEliminarLugar.Size = new Size(259, 117);
            btnIrEliminarLugar.TabIndex = 4;
            btnIrEliminarLugar.Text = "Eliminar";
            btnIrEliminarLugar.UseVisualStyleBackColor = true;
            // 
            // btnIrEditarLugar
            // 
            btnIrEditarLugar.Location = new Point(377, 158);
            btnIrEditarLugar.Name = "btnIrEditarLugar";
            btnIrEditarLugar.Size = new Size(259, 117);
            btnIrEditarLugar.TabIndex = 3;
            btnIrEditarLugar.Text = "Editar";
            btnIrEditarLugar.UseVisualStyleBackColor = true;
            // 
            // btnIrAgregarLugar
            // 
            btnIrAgregarLugar.Location = new Point(377, 35);
            btnIrAgregarLugar.Name = "btnIrAgregarLugar";
            btnIrAgregarLugar.Size = new Size(259, 117);
            btnIrAgregarLugar.TabIndex = 2;
            btnIrAgregarLugar.Text = "Agregar";
            btnIrAgregarLugar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(561, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgLugar
            // 
            dgLugar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLugar.Location = new Point(8, 6);
            dgLugar.Name = "dgLugar";
            dgLugar.Size = new Size(363, 392);
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
            tpAgregarEditarLugar.Size = new Size(649, 422);
            tpAgregarEditarLugar.TabIndex = 1;
            tpAgregarEditarLugar.Text = "AgregarEditar marca";
            tpAgregarEditarLugar.UseVisualStyleBackColor = true;
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
            // tpEliminarLugar
            // 
            tpEliminarLugar.Controls.Add(btnCancelarLugar);
            tpEliminarLugar.Controls.Add(btnEliminarEliminar);
            tpEliminarLugar.Controls.Add(cbLugares);
            tpEliminarLugar.Controls.Add(lblEliminarLugar);
            tpEliminarLugar.Location = new Point(4, 24);
            tpEliminarLugar.Name = "tpEliminarLugar";
            tpEliminarLugar.Padding = new Padding(3);
            tpEliminarLugar.Size = new Size(649, 422);
            tpEliminarLugar.TabIndex = 2;
            tpEliminarLugar.Text = "Eliminar lugar";
            tpEliminarLugar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarLugar
            // 
            btnCancelarLugar.Location = new Point(325, 225);
            btnCancelarLugar.Name = "btnCancelarLugar";
            btnCancelarLugar.Size = new Size(298, 23);
            btnCancelarLugar.TabIndex = 3;
            btnCancelarLugar.Text = "Cancelar";
            btnCancelarLugar.UseVisualStyleBackColor = true;
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
            // cbLugares
            // 
            cbLugares.FormattingEnabled = true;
            cbLugares.Location = new Point(24, 187);
            cbLugares.Name = "cbLugares";
            cbLugares.Size = new Size(599, 23);
            cbLugares.TabIndex = 1;
            // 
            // lblEliminarLugar
            // 
            lblEliminarLugar.AutoSize = true;
            lblEliminarLugar.Location = new Point(304, 164);
            lblEliminarLugar.Name = "lblEliminarLugar";
            lblEliminarLugar.Size = new Size(38, 15);
            lblEliminarLugar.TabIndex = 0;
            lblEliminarLugar.Text = "label2";
            // 
            // LugaresView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 450);
            Controls.Add(tbLugar);
            Name = "LugaresView";
            Text = "ViewLugares";
            tbLugar.ResumeLayout(false);
            tpBuscarLugar.ResumeLayout(false);
            tpBuscarLugar.PerformLayout();
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
        private TextBox txtBuscarMarca;
        private Button btnIrEliminarLugar;
        private Button btnIrEditarLugar;
        private Button btnIrAgregarLugar;
        private Button btnBuscar;
        private DataGridView dgLugar;
        private TabPage tpAgregarEditarLugar;
        private TextBox txtAgregarEditar;
        private Label lblAgregarEditar;
        private Button btnRegresarEditarGuardar;
        private Button btnGuardarEditar;
        private TabPage tpEliminarLugar;
        private Button btnCancelarLugar;
        private Button btnEliminarEliminar;
        private ComboBox cbLugares;
        private Label lblEliminarLugar;
    }
}