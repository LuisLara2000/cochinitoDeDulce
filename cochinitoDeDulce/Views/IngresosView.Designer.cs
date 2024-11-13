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
            tbIngresos = new TabControl();
            tpBuscarIngresos = new TabPage();
            txtBuscarIngreso = new ControlesPersonalizados.CustomTextBox();
            btnEliminarIngreso = new Button();
            btnIrEditarMarca = new Button();
            btnIrAgregarMarca = new Button();
            btnBuscar = new Button();
            dgIngresos = new DataGridView();
            tpAgregarEditarIngresos = new TabPage();
            txtAgregarOrigen = new ControlesPersonalizados.CustomTextBox();
            txtAgregarMonto = new ControlesPersonalizados.CustomTextBox();
            label2 = new Label();
            label1 = new Label();
            lblAgregarEditar = new Label();
            btnRegresarEditarGuardar = new Button();
            btnGuardarEditar = new Button();
            tbIngresos.SuspendLayout();
            tpBuscarIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgIngresos).BeginInit();
            tpAgregarEditarIngresos.SuspendLayout();
            SuspendLayout();
            // 
            // tbIngresos
            // 
            tbIngresos.Controls.Add(tpBuscarIngresos);
            tbIngresos.Controls.Add(tpAgregarEditarIngresos);
            tbIngresos.Location = new Point(-10, -25);
            tbIngresos.Name = "tbIngresos";
            tbIngresos.SelectedIndex = 0;
            tbIngresos.Size = new Size(1415, 900);
            tbIngresos.SizeMode = TabSizeMode.FillToRight;
            tbIngresos.TabIndex = 1;
            // 
            // tpBuscarIngresos
            // 
            tpBuscarIngresos.Controls.Add(txtBuscarIngreso);
            tpBuscarIngresos.Controls.Add(btnEliminarIngreso);
            tpBuscarIngresos.Controls.Add(btnIrEditarMarca);
            tpBuscarIngresos.Controls.Add(btnIrAgregarMarca);
            tpBuscarIngresos.Controls.Add(btnBuscar);
            tpBuscarIngresos.Controls.Add(dgIngresos);
            tpBuscarIngresos.Location = new Point(4, 24);
            tpBuscarIngresos.Name = "tpBuscarIngresos";
            tpBuscarIngresos.Padding = new Padding(3);
            tpBuscarIngresos.Size = new Size(1407, 872);
            tpBuscarIngresos.TabIndex = 0;
            tpBuscarIngresos.Text = "Todos los ingresos";
            tpBuscarIngresos.UseVisualStyleBackColor = true;
            // 
            // txtBuscarIngreso
            // 
            txtBuscarIngreso.BorderColor = Color.MediumSlateBlue;
            txtBuscarIngreso.BorderFocusColor = Color.HotPink;
            txtBuscarIngreso.BorderSize = 2;
            txtBuscarIngreso.Location = new Point(941, 9);
            txtBuscarIngreso.Multiline = false;
            txtBuscarIngreso.Name = "txtBuscarIngreso";
            txtBuscarIngreso.Padding = new Padding(7);
            txtBuscarIngreso.PasswordChar = false;
            txtBuscarIngreso.Size = new Size(169, 30);
            txtBuscarIngreso.TabIndex = 6;
            txtBuscarIngreso.Texts = "";
            txtBuscarIngreso.UnderlinedStyle = false;
            // 
            // btnEliminarIngreso
            // 
            btnEliminarIngreso.Location = new Point(941, 555);
            btnEliminarIngreso.Name = "btnEliminarIngreso";
            btnEliminarIngreso.Size = new Size(250, 182);
            btnEliminarIngreso.TabIndex = 4;
            btnEliminarIngreso.Text = "Eliminar";
            btnEliminarIngreso.UseVisualStyleBackColor = true;
            // 
            // btnIrEditarMarca
            // 
            btnIrEditarMarca.Location = new Point(941, 342);
            btnIrEditarMarca.Name = "btnIrEditarMarca";
            btnIrEditarMarca.Size = new Size(250, 207);
            btnIrEditarMarca.TabIndex = 3;
            btnIrEditarMarca.Text = "Editar";
            btnIrEditarMarca.UseVisualStyleBackColor = true;
            // 
            // btnIrAgregarMarca
            // 
            btnIrAgregarMarca.Location = new Point(941, 45);
            btnIrAgregarMarca.Name = "btnIrAgregarMarca";
            btnIrAgregarMarca.Size = new Size(250, 291);
            btnIrAgregarMarca.TabIndex = 2;
            btnIrAgregarMarca.Text = "Agregar";
            btnIrAgregarMarca.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1116, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 31);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgIngresos
            // 
            dgIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgIngresos.Location = new Point(13, 6);
            dgIngresos.Name = "dgIngresos";
            dgIngresos.Size = new Size(922, 731);
            dgIngresos.TabIndex = 0;
            // 
            // tpAgregarEditarIngresos
            // 
            tpAgregarEditarIngresos.Controls.Add(txtAgregarOrigen);
            tpAgregarEditarIngresos.Controls.Add(txtAgregarMonto);
            tpAgregarEditarIngresos.Controls.Add(label2);
            tpAgregarEditarIngresos.Controls.Add(label1);
            tpAgregarEditarIngresos.Controls.Add(lblAgregarEditar);
            tpAgregarEditarIngresos.Controls.Add(btnRegresarEditarGuardar);
            tpAgregarEditarIngresos.Controls.Add(btnGuardarEditar);
            tpAgregarEditarIngresos.Location = new Point(4, 24);
            tpAgregarEditarIngresos.Name = "tpAgregarEditarIngresos";
            tpAgregarEditarIngresos.Padding = new Padding(3);
            tpAgregarEditarIngresos.Size = new Size(1407, 872);
            tpAgregarEditarIngresos.TabIndex = 1;
            tpAgregarEditarIngresos.Text = "AgregarEditar ingreso";
            tpAgregarEditarIngresos.UseVisualStyleBackColor = true;
            // 
            // txtAgregarOrigen
            // 
            txtAgregarOrigen.BorderColor = Color.MediumSlateBlue;
            txtAgregarOrigen.BorderFocusColor = Color.HotPink;
            txtAgregarOrigen.BorderSize = 2;
            txtAgregarOrigen.Location = new Point(325, 365);
            txtAgregarOrigen.Multiline = false;
            txtAgregarOrigen.Name = "txtAgregarOrigen";
            txtAgregarOrigen.Padding = new Padding(7);
            txtAgregarOrigen.PasswordChar = false;
            txtAgregarOrigen.Size = new Size(549, 30);
            txtAgregarOrigen.TabIndex = 8;
            txtAgregarOrigen.Texts = "";
            txtAgregarOrigen.UnderlinedStyle = false;
            // 
            // txtAgregarMonto
            // 
            txtAgregarMonto.BorderColor = Color.MediumSlateBlue;
            txtAgregarMonto.BorderFocusColor = Color.HotPink;
            txtAgregarMonto.BorderSize = 2;
            txtAgregarMonto.Location = new Point(325, 329);
            txtAgregarMonto.Multiline = false;
            txtAgregarMonto.Name = "txtAgregarMonto";
            txtAgregarMonto.Padding = new Padding(7);
            txtAgregarMonto.PasswordChar = false;
            txtAgregarMonto.Size = new Size(549, 30);
            txtAgregarMonto.TabIndex = 7;
            txtAgregarMonto.Texts = "";
            txtAgregarMonto.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 373);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Origen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 337);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Monto";
            // 
            // lblAgregarEditar
            // 
            lblAgregarEditar.AutoSize = true;
            lblAgregarEditar.Location = new Point(555, 297);
            lblAgregarEditar.Name = "lblAgregarEditar";
            lblAgregarEditar.Size = new Size(38, 15);
            lblAgregarEditar.TabIndex = 2;
            lblAgregarEditar.Text = "label1";
            // 
            // btnRegresarEditarGuardar
            // 
            btnRegresarEditarGuardar.Location = new Point(578, 408);
            btnRegresarEditarGuardar.Name = "btnRegresarEditarGuardar";
            btnRegresarEditarGuardar.Size = new Size(296, 22);
            btnRegresarEditarGuardar.TabIndex = 1;
            btnRegresarEditarGuardar.Text = "Cancelar";
            btnRegresarEditarGuardar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.Location = new Point(276, 408);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(296, 22);
            btnGuardarEditar.TabIndex = 0;
            btnGuardarEditar.Text = "button5";
            btnGuardarEditar.UseVisualStyleBackColor = true;
            // 
            // IngresosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 748);
            Controls.Add(tbIngresos);
            Name = "IngresosView";
            Text = "IngresosView";
            tbIngresos.ResumeLayout(false);
            tpBuscarIngresos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgIngresos).EndInit();
            tpAgregarEditarIngresos.ResumeLayout(false);
            tpAgregarEditarIngresos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbIngresos;
        private TabPage tpBuscarIngresos;
        private Button btnEliminarIngreso;
        private Button btnIrEditarMarca;
        private Button btnIrAgregarMarca;
        private Button btnBuscar;
        private DataGridView dgIngresos;
        private TabPage tpAgregarEditarIngresos;
        private Label lblAgregarEditar;
        private Button btnRegresarEditarGuardar;
        private Button btnGuardarEditar;
        private Label label2;
        private Label label1;
        private ControlesPersonalizados.CustomTextBox txtBuscarIngreso;
        private ControlesPersonalizados.CustomTextBox txtAgregarOrigen;
        private ControlesPersonalizados.CustomTextBox txtAgregarMonto;
    }
}