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
            txtBuscarIngreso = new TextBox();
            btnEliminarIngreso = new Button();
            btnIrEditarMarca = new Button();
            btnIrAgregarMarca = new Button();
            btnBuscar = new Button();
            dgIngresos = new DataGridView();
            tpAgregarEditarIngresos = new TabPage();
            label2 = new Label();
            label1 = new Label();
            txtAgregarOrigen = new TextBox();
            txtAgregarMonto = new TextBox();
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
            tbIngresos.Dock = DockStyle.Fill;
            tbIngresos.Location = new Point(0, 0);
            tbIngresos.Name = "tbIngresos";
            tbIngresos.SelectedIndex = 0;
            tbIngresos.Size = new Size(800, 450);
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
            tpBuscarIngresos.Size = new Size(792, 422);
            tpBuscarIngresos.TabIndex = 0;
            tpBuscarIngresos.Text = "Todos los ingresos";
            tpBuscarIngresos.UseVisualStyleBackColor = true;
            // 
            // txtBuscarIngreso
            // 
            txtBuscarIngreso.Location = new Point(525, 7);
            txtBuscarIngreso.Name = "txtBuscarIngreso";
            txtBuscarIngreso.Size = new Size(178, 23);
            txtBuscarIngreso.TabIndex = 5;
            // 
            // btnEliminarIngreso
            // 
            btnEliminarIngreso.Location = new Point(525, 281);
            btnEliminarIngreso.Name = "btnEliminarIngreso";
            btnEliminarIngreso.Size = new Size(259, 117);
            btnEliminarIngreso.TabIndex = 4;
            btnEliminarIngreso.Text = "Eliminar";
            btnEliminarIngreso.UseVisualStyleBackColor = true;
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
            // dgIngresos
            // 
            dgIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgIngresos.Location = new Point(8, 7);
            dgIngresos.Name = "dgIngresos";
            dgIngresos.Size = new Size(511, 392);
            dgIngresos.TabIndex = 0;
            // 
            // tpAgregarEditarIngresos
            // 
            tpAgregarEditarIngresos.Controls.Add(label2);
            tpAgregarEditarIngresos.Controls.Add(label1);
            tpAgregarEditarIngresos.Controls.Add(txtAgregarOrigen);
            tpAgregarEditarIngresos.Controls.Add(txtAgregarMonto);
            tpAgregarEditarIngresos.Controls.Add(lblAgregarEditar);
            tpAgregarEditarIngresos.Controls.Add(btnRegresarEditarGuardar);
            tpAgregarEditarIngresos.Controls.Add(btnGuardarEditar);
            tpAgregarEditarIngresos.Location = new Point(4, 24);
            tpAgregarEditarIngresos.Name = "tpAgregarEditarIngresos";
            tpAgregarEditarIngresos.Padding = new Padding(3);
            tpAgregarEditarIngresos.Size = new Size(792, 422);
            tpAgregarEditarIngresos.TabIndex = 1;
            tpAgregarEditarIngresos.Text = "AgregarEditar ingreso";
            tpAgregarEditarIngresos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 175);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Origen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 175);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Monto";
            // 
            // txtAgregarOrigen
            // 
            txtAgregarOrigen.Location = new Point(329, 193);
            txtAgregarOrigen.Name = "txtAgregarOrigen";
            txtAgregarOrigen.Size = new Size(296, 23);
            txtAgregarOrigen.TabIndex = 4;
            // 
            // txtAgregarMonto
            // 
            txtAgregarMonto.Location = new Point(27, 193);
            txtAgregarMonto.Name = "txtAgregarMonto";
            txtAgregarMonto.Size = new Size(296, 23);
            txtAgregarMonto.TabIndex = 3;
            // 
            // lblAgregarEditar
            // 
            lblAgregarEditar.AutoSize = true;
            lblAgregarEditar.Location = new Point(306, 132);
            lblAgregarEditar.Name = "lblAgregarEditar";
            lblAgregarEditar.Size = new Size(38, 15);
            lblAgregarEditar.TabIndex = 2;
            lblAgregarEditar.Text = "label1";
            // 
            // btnRegresarEditarGuardar
            // 
            btnRegresarEditarGuardar.Location = new Point(27, 272);
            btnRegresarEditarGuardar.Name = "btnRegresarEditarGuardar";
            btnRegresarEditarGuardar.Size = new Size(598, 22);
            btnRegresarEditarGuardar.TabIndex = 1;
            btnRegresarEditarGuardar.Text = "Cancelar";
            btnRegresarEditarGuardar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.Location = new Point(27, 235);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(598, 22);
            btnGuardarEditar.TabIndex = 0;
            btnGuardarEditar.Text = "button5";
            btnGuardarEditar.UseVisualStyleBackColor = true;
            // 
            // IngresosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbIngresos);
            Name = "IngresosView";
            Text = "IngresosView";
            tbIngresos.ResumeLayout(false);
            tpBuscarIngresos.ResumeLayout(false);
            tpBuscarIngresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgIngresos).EndInit();
            tpAgregarEditarIngresos.ResumeLayout(false);
            tpAgregarEditarIngresos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbIngresos;
        private TabPage tpBuscarIngresos;
        private TextBox txtBuscarIngreso;
        private Button btnEliminarIngreso;
        private Button btnIrEditarMarca;
        private Button btnIrAgregarMarca;
        private Button btnBuscar;
        private DataGridView dgIngresos;
        private TabPage tpAgregarEditarIngresos;
        private TextBox txtAgregarMonto;
        private Label lblAgregarEditar;
        private Button btnRegresarEditarGuardar;
        private Button btnGuardarEditar;
        private Label label2;
        private Label label1;
        private TextBox txtAgregarOrigen;
    }
}