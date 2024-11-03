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
            txtBuscarTipo = new TextBox();
            btnIrEliminarTipo = new Button();
            btnIrEditarTipo = new Button();
            btnIrAgregarTipo = new Button();
            btnBuscar = new Button();
            dgTipos = new DataGridView();
            tpAgregarEditarTipo = new TabPage();
            txtAgregarEditar = new TextBox();
            lblAgregarEditar = new Label();
            btnRegresarEditarGuardar = new Button();
            btnGuardarEditar = new Button();
            tpEliminarTipo = new TabPage();
            btnCancelarEliminar = new Button();
            btnEliminarEliminar = new Button();
            cbTipos = new ComboBox();
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
            tbTipo.Dock = DockStyle.Fill;
            tbTipo.Location = new Point(0, 0);
            tbTipo.Name = "tbTipo";
            tbTipo.SelectedIndex = 0;
            tbTipo.Size = new Size(661, 450);
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
            tpBuscarTipo.Size = new Size(653, 422);
            tpBuscarTipo.TabIndex = 0;
            tpBuscarTipo.Text = "Todos los tipos";
            tpBuscarTipo.UseVisualStyleBackColor = true;
            // 
            // txtBuscarTipo
            // 
            txtBuscarTipo.Location = new Point(377, 6);
            txtBuscarTipo.Name = "txtBuscarTipo";
            txtBuscarTipo.Size = new Size(178, 23);
            txtBuscarTipo.TabIndex = 5;
            // 
            // btnIrEliminarTipo
            // 
            btnIrEliminarTipo.Location = new Point(377, 281);
            btnIrEliminarTipo.Name = "btnIrEliminarTipo";
            btnIrEliminarTipo.Size = new Size(259, 117);
            btnIrEliminarTipo.TabIndex = 4;
            btnIrEliminarTipo.Text = "Eliminar";
            btnIrEliminarTipo.UseVisualStyleBackColor = true;
            // 
            // btnIrEditarTipo
            // 
            btnIrEditarTipo.Location = new Point(377, 158);
            btnIrEditarTipo.Name = "btnIrEditarTipo";
            btnIrEditarTipo.Size = new Size(259, 117);
            btnIrEditarTipo.TabIndex = 3;
            btnIrEditarTipo.Text = "Editar";
            btnIrEditarTipo.UseVisualStyleBackColor = true;
            // 
            // btnIrAgregarTipo
            // 
            btnIrAgregarTipo.Location = new Point(377, 35);
            btnIrAgregarTipo.Name = "btnIrAgregarTipo";
            btnIrAgregarTipo.Size = new Size(259, 117);
            btnIrAgregarTipo.TabIndex = 2;
            btnIrAgregarTipo.Text = "Agregar";
            btnIrAgregarTipo.UseVisualStyleBackColor = true;
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
            // dgTipos
            // 
            dgTipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTipos.Location = new Point(8, 6);
            dgTipos.Name = "dgTipos";
            dgTipos.Size = new Size(363, 392);
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
            tpAgregarEditarTipo.Size = new Size(653, 422);
            tpAgregarEditarTipo.TabIndex = 1;
            tpAgregarEditarTipo.Text = "AgregarEditar tipo";
            tpAgregarEditarTipo.UseVisualStyleBackColor = true;
            tpAgregarEditarTipo.UseWaitCursor = true;
            // 
            // txtAgregarEditar
            // 
            txtAgregarEditar.Location = new Point(27, 193);
            txtAgregarEditar.Name = "txtAgregarEditar";
            txtAgregarEditar.Size = new Size(598, 23);
            txtAgregarEditar.TabIndex = 3;
            txtAgregarEditar.UseWaitCursor = true;
            // 
            // lblAgregarEditar
            // 
            lblAgregarEditar.AutoSize = true;
            lblAgregarEditar.Location = new Point(317, 169);
            lblAgregarEditar.Name = "lblAgregarEditar";
            lblAgregarEditar.Size = new Size(38, 15);
            lblAgregarEditar.TabIndex = 2;
            lblAgregarEditar.Text = "label1";
            lblAgregarEditar.UseWaitCursor = true;
            // 
            // btnRegresarEditarGuardar
            // 
            btnRegresarEditarGuardar.Location = new Point(329, 235);
            btnRegresarEditarGuardar.Name = "btnRegresarEditarGuardar";
            btnRegresarEditarGuardar.Size = new Size(296, 22);
            btnRegresarEditarGuardar.TabIndex = 1;
            btnRegresarEditarGuardar.Text = "Cancelar";
            btnRegresarEditarGuardar.UseVisualStyleBackColor = true;
            btnRegresarEditarGuardar.UseWaitCursor = true;
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.Location = new Point(27, 235);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(296, 22);
            btnGuardarEditar.TabIndex = 0;
            btnGuardarEditar.Text = "button5";
            btnGuardarEditar.UseVisualStyleBackColor = true;
            btnGuardarEditar.UseWaitCursor = true;
            // 
            // tpEliminarTipo
            // 
            tpEliminarTipo.Controls.Add(btnCancelarEliminar);
            tpEliminarTipo.Controls.Add(btnEliminarEliminar);
            tpEliminarTipo.Controls.Add(cbTipos);
            tpEliminarTipo.Controls.Add(lblEliminarTipo);
            tpEliminarTipo.Location = new Point(4, 24);
            tpEliminarTipo.Name = "tpEliminarTipo";
            tpEliminarTipo.Padding = new Padding(3);
            tpEliminarTipo.Size = new Size(653, 422);
            tpEliminarTipo.TabIndex = 2;
            tpEliminarTipo.Text = "Eliminar tipo";
            tpEliminarTipo.UseVisualStyleBackColor = true;
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
            btnEliminarEliminar.Text = "Elininar";
            btnEliminarEliminar.UseVisualStyleBackColor = true;
            // 
            // cbTipos
            // 
            cbTipos.FormattingEnabled = true;
            cbTipos.Location = new Point(24, 187);
            cbTipos.Name = "cbTipos";
            cbTipos.Size = new Size(599, 23);
            cbTipos.TabIndex = 1;
            // 
            // lblEliminarTipo
            // 
            lblEliminarTipo.AutoSize = true;
            lblEliminarTipo.Location = new Point(307, 167);
            lblEliminarTipo.Name = "lblEliminarTipo";
            lblEliminarTipo.Size = new Size(38, 15);
            lblEliminarTipo.TabIndex = 0;
            lblEliminarTipo.Text = "label2";
            // 
            // TiposView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 450);
            Controls.Add(tbTipo);
            Name = "TiposView";
            Text = "ViewTipos";
            tbTipo.ResumeLayout(false);
            tpBuscarTipo.ResumeLayout(false);
            tpBuscarTipo.PerformLayout();
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
        private TextBox txtBuscarTipo;
        private Button btnIrEliminarTipo;
        private Button btnIrEditarTipo;
        private Button btnIrAgregarTipo;
        private Button btnBuscar;
        private DataGridView dgTipos;
        private TabPage tpAgregarEditarTipo;
        private TextBox txtAgregarEditar;
        private Label lblAgregarEditar;
        private Button btnRegresarEditarGuardar;
        private Button btnGuardarEditar;
        private TabPage tpEliminarTipo;
        private Button btnCancelarEliminar;
        private Button btnEliminarEliminar;
        private ComboBox cbTipos;
        private Label lblEliminarTipo;
    }
}