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
            txtBuscarMarca = new TextBox();
            button4 = new Button();
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
            button8 = new Button();
            button7 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
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
            tbMarca.Size = new Size(652, 440);
            tbMarca.SizeMode = TabSizeMode.FillToRight;
            tbMarca.TabIndex = 0;
            tbMarca.SelectedIndexChanged += tbMarca_SelectedIndexChanged;
            // 
            // tpBuscarMarca
            // 
            tpBuscarMarca.Controls.Add(txtBuscarMarca);
            tpBuscarMarca.Controls.Add(button4);
            tpBuscarMarca.Controls.Add(btnIrEditarMarca);
            tpBuscarMarca.Controls.Add(btnIrAgregarMarca);
            tpBuscarMarca.Controls.Add(btnBuscar);
            tpBuscarMarca.Controls.Add(dgMarcas);
            tpBuscarMarca.Location = new Point(4, 24);
            tpBuscarMarca.Name = "tpBuscarMarca";
            tpBuscarMarca.Padding = new Padding(3);
            tpBuscarMarca.Size = new Size(644, 412);
            tpBuscarMarca.TabIndex = 0;
            tpBuscarMarca.Text = "Todas las marcas";
            tpBuscarMarca.UseVisualStyleBackColor = true;
            // 
            // txtBuscarMarca
            // 
            txtBuscarMarca.Location = new Point(377, 6);
            txtBuscarMarca.Name = "txtBuscarMarca";
            txtBuscarMarca.Size = new Size(178, 23);
            txtBuscarMarca.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(377, 281);
            button4.Name = "button4";
            button4.Size = new Size(259, 117);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnIrEditarMarca
            // 
            btnIrEditarMarca.Location = new Point(377, 158);
            btnIrEditarMarca.Name = "btnIrEditarMarca";
            btnIrEditarMarca.Size = new Size(259, 117);
            btnIrEditarMarca.TabIndex = 3;
            btnIrEditarMarca.Text = "Editar";
            btnIrEditarMarca.UseVisualStyleBackColor = true;
            // 
            // btnIrAgregarMarca
            // 
            btnIrAgregarMarca.Location = new Point(377, 35);
            btnIrAgregarMarca.Name = "btnIrAgregarMarca";
            btnIrAgregarMarca.Size = new Size(259, 117);
            btnIrAgregarMarca.TabIndex = 2;
            btnIrAgregarMarca.Text = "Agregar";
            btnIrAgregarMarca.UseVisualStyleBackColor = true;
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
            // dgMarcas
            // 
            dgMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMarcas.Location = new Point(8, 6);
            dgMarcas.Name = "dgMarcas";
            dgMarcas.Size = new Size(363, 392);
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
            lblAgregarEditar.Location = new Point(311, 163);
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
            tpEliminarMarca.Controls.Add(button8);
            tpEliminarMarca.Controls.Add(button7);
            tpEliminarMarca.Controls.Add(comboBox1);
            tpEliminarMarca.Controls.Add(label2);
            tpEliminarMarca.Location = new Point(4, 24);
            tpEliminarMarca.Name = "tpEliminarMarca";
            tpEliminarMarca.Padding = new Padding(3);
            tpEliminarMarca.Size = new Size(644, 412);
            tpEliminarMarca.TabIndex = 2;
            tpEliminarMarca.Text = "Eliminar marca";
            tpEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(325, 225);
            button8.Name = "button8";
            button8.Size = new Size(298, 23);
            button8.TabIndex = 3;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(24, 225);
            button7.Name = "button7";
            button7.Size = new Size(295, 23);
            button7.TabIndex = 2;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 187);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(599, 23);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 161);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // MarcasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 440);
            Controls.Add(tbMarca);
            Name = "MarcasView";
            Text = "MarcasView";
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
        private TabPage tpAgregarEditarMarca;
        private TabPage tpEliminarMarca;
        private TextBox txtBuscarMarca;
        private Button button4;
        private Button btnIrEditarMarca;
        private Button btnIrAgregarMarca;
        private Button btnBuscar;
        private DataGridView dgMarcas;
        private TextBox txtAgregarEditar;
        private Label lblAgregarEditar;
        private Button btnRegresarEditarGuardar;
        private Button btnGuardarEditar;
        private ComboBox comboBox1;
        private Label label2;
        private Button button8;
        private Button button7;
    }
}