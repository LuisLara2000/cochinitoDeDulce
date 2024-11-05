namespace cochinitoDeDulce.Views
{
    partial class GastosView
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
            tpAgregarEditarGasto = new TabPage();
            cbUnidades = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            cbTipos = new ComboBox();
            cbLugares = new ComboBox();
            cbMarcas = new ComboBox();
            cbCategorias = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txtAgregarEditar = new TextBox();
            label1 = new Label();
            lblAgregarEditar = new Label();
            btnRegresarEditarGuardar = new Button();
            btnGuardarEditar = new Button();
            tpBuscarGasto = new TabPage();
            txtBuscarMarca = new TextBox();
            btnIrEliminarLugar = new Button();
            btnIrEditarLugar = new Button();
            btnIrAgregarGasto = new Button();
            btnBuscar = new Button();
            dgGasto = new DataGridView();
            tbGasto = new TabControl();
            tpAgregarEditarGasto.SuspendLayout();
            tpBuscarGasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgGasto).BeginInit();
            tbGasto.SuspendLayout();
            SuspendLayout();
            // 
            // tpAgregarEditarGasto
            // 
            tpAgregarEditarGasto.Controls.Add(cbUnidades);
            tpAgregarEditarGasto.Controls.Add(label9);
            tpAgregarEditarGasto.Controls.Add(label8);
            tpAgregarEditarGasto.Controls.Add(label7);
            tpAgregarEditarGasto.Controls.Add(cbTipos);
            tpAgregarEditarGasto.Controls.Add(cbLugares);
            tpAgregarEditarGasto.Controls.Add(cbMarcas);
            tpAgregarEditarGasto.Controls.Add(cbCategorias);
            tpAgregarEditarGasto.Controls.Add(label6);
            tpAgregarEditarGasto.Controls.Add(label5);
            tpAgregarEditarGasto.Controls.Add(label4);
            tpAgregarEditarGasto.Controls.Add(label3);
            tpAgregarEditarGasto.Controls.Add(label2);
            tpAgregarEditarGasto.Controls.Add(textBox5);
            tpAgregarEditarGasto.Controls.Add(textBox4);
            tpAgregarEditarGasto.Controls.Add(textBox2);
            tpAgregarEditarGasto.Controls.Add(textBox1);
            tpAgregarEditarGasto.Controls.Add(txtAgregarEditar);
            tpAgregarEditarGasto.Controls.Add(label1);
            tpAgregarEditarGasto.Controls.Add(lblAgregarEditar);
            tpAgregarEditarGasto.Controls.Add(btnRegresarEditarGuardar);
            tpAgregarEditarGasto.Controls.Add(btnGuardarEditar);
            tpAgregarEditarGasto.Location = new Point(4, 24);
            tpAgregarEditarGasto.Name = "tpAgregarEditarGasto";
            tpAgregarEditarGasto.Padding = new Padding(3);
            tpAgregarEditarGasto.Size = new Size(964, 450);
            tpAgregarEditarGasto.TabIndex = 1;
            tpAgregarEditarGasto.Text = "AgregarEditar marca";
            tpAgregarEditarGasto.UseVisualStyleBackColor = true;
            // 
            // cbUnidades
            // 
            cbUnidades.FormattingEnabled = true;
            cbUnidades.Location = new Point(210, 87);
            cbUnidades.Name = "cbUnidades";
            cbUnidades.Size = new Size(96, 23);
            cbUnidades.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(736, 143);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 21;
            label9.Text = "Tipo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(491, 143);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 20;
            label8.Text = "Lugar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(248, 143);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 19;
            label7.Text = "Marca";
            // 
            // cbTipos
            // 
            cbTipos.FormattingEnabled = true;
            cbTipos.Location = new Point(736, 172);
            cbTipos.Name = "cbTipos";
            cbTipos.Size = new Size(220, 23);
            cbTipos.TabIndex = 18;
            // 
            // cbLugares
            // 
            cbLugares.FormattingEnabled = true;
            cbLugares.Location = new Point(491, 172);
            cbLugares.Name = "cbLugares";
            cbLugares.Size = new Size(220, 23);
            cbLugares.TabIndex = 17;
            // 
            // cbMarcas
            // 
            cbMarcas.FormattingEnabled = true;
            cbMarcas.Location = new Point(248, 172);
            cbMarcas.Name = "cbMarcas";
            cbMarcas.Size = new Size(220, 23);
            cbMarcas.TabIndex = 16;
            // 
            // cbCategorias
            // 
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Location = new Point(8, 172);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new Size(220, 23);
            cbCategorias.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 143);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 14;
            label6.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(409, 69);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 13;
            label5.Text = "Comentarios";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(312, 69);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 12;
            label4.Text = "Descuento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 69);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 11;
            label3.Text = "Unidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 69);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 10;
            label2.Text = "Cantidad";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(409, 87);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(547, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(312, 87);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(86, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(86, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(86, 23);
            textBox1.TabIndex = 5;
            // 
            // txtAgregarEditar
            // 
            txtAgregarEditar.Location = new Point(8, 38);
            txtAgregarEditar.Name = "txtAgregarEditar";
            txtAgregarEditar.Size = new Size(948, 23);
            txtAgregarEditar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 69);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Precio";
            // 
            // lblAgregarEditar
            // 
            lblAgregarEditar.AutoSize = true;
            lblAgregarEditar.Location = new Point(8, 20);
            lblAgregarEditar.Name = "lblAgregarEditar";
            lblAgregarEditar.Size = new Size(102, 15);
            lblAgregarEditar.TabIndex = 2;
            lblAgregarEditar.Text = "Nombre del gasto";
            // 
            // btnRegresarEditarGuardar
            // 
            btnRegresarEditarGuardar.Location = new Point(484, 220);
            btnRegresarEditarGuardar.Name = "btnRegresarEditarGuardar";
            btnRegresarEditarGuardar.Size = new Size(472, 222);
            btnRegresarEditarGuardar.TabIndex = 1;
            btnRegresarEditarGuardar.Text = "Cancelar";
            btnRegresarEditarGuardar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.Location = new Point(8, 220);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(460, 222);
            btnGuardarEditar.TabIndex = 0;
            btnGuardarEditar.Text = "button5";
            btnGuardarEditar.UseVisualStyleBackColor = true;
            // 
            // tpBuscarGasto
            // 
            tpBuscarGasto.Controls.Add(txtBuscarMarca);
            tpBuscarGasto.Controls.Add(btnIrEliminarLugar);
            tpBuscarGasto.Controls.Add(btnIrEditarLugar);
            tpBuscarGasto.Controls.Add(btnIrAgregarGasto);
            tpBuscarGasto.Controls.Add(btnBuscar);
            tpBuscarGasto.Controls.Add(dgGasto);
            tpBuscarGasto.Location = new Point(4, 24);
            tpBuscarGasto.Name = "tpBuscarGasto";
            tpBuscarGasto.Padding = new Padding(3);
            tpBuscarGasto.Size = new Size(964, 450);
            tpBuscarGasto.TabIndex = 0;
            tpBuscarGasto.Text = "Todos los lugares";
            tpBuscarGasto.UseVisualStyleBackColor = true;
            // 
            // txtBuscarMarca
            // 
            txtBuscarMarca.Location = new Point(8, 7);
            txtBuscarMarca.Name = "txtBuscarMarca";
            txtBuscarMarca.Size = new Size(867, 23);
            txtBuscarMarca.TabIndex = 5;
            // 
            // btnIrEliminarLugar
            // 
            btnIrEliminarLugar.Location = new Point(697, 404);
            btnIrEliminarLugar.Name = "btnIrEliminarLugar";
            btnIrEliminarLugar.Size = new Size(259, 43);
            btnIrEliminarLugar.TabIndex = 4;
            btnIrEliminarLugar.Text = "Eliminar";
            btnIrEliminarLugar.UseVisualStyleBackColor = true;
            // 
            // btnIrEditarLugar
            // 
            btnIrEditarLugar.Location = new Point(273, 404);
            btnIrEditarLugar.Name = "btnIrEditarLugar";
            btnIrEditarLugar.Size = new Size(418, 43);
            btnIrEditarLugar.TabIndex = 3;
            btnIrEditarLugar.Text = "Editar";
            btnIrEditarLugar.UseVisualStyleBackColor = true;
            // 
            // btnIrAgregarGasto
            // 
            btnIrAgregarGasto.Location = new Point(8, 404);
            btnIrAgregarGasto.Name = "btnIrAgregarGasto";
            btnIrAgregarGasto.Size = new Size(259, 40);
            btnIrAgregarGasto.TabIndex = 2;
            btnIrAgregarGasto.Text = "Agregar";
            btnIrAgregarGasto.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(881, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgGasto
            // 
            dgGasto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgGasto.Location = new Point(8, 35);
            dgGasto.Name = "dgGasto";
            dgGasto.Size = new Size(948, 363);
            dgGasto.TabIndex = 0;
            // 
            // tbGasto
            // 
            tbGasto.Controls.Add(tpBuscarGasto);
            tbGasto.Controls.Add(tpAgregarEditarGasto);
            tbGasto.Dock = DockStyle.Fill;
            tbGasto.Location = new Point(0, 0);
            tbGasto.Name = "tbGasto";
            tbGasto.SelectedIndex = 0;
            tbGasto.Size = new Size(972, 478);
            tbGasto.SizeMode = TabSizeMode.FillToRight;
            tbGasto.TabIndex = 2;
            // 
            // GastosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 478);
            Controls.Add(tbGasto);
            Name = "GastosView";
            Text = "GastosView";
            tpAgregarEditarGasto.ResumeLayout(false);
            tpAgregarEditarGasto.PerformLayout();
            tpBuscarGasto.ResumeLayout(false);
            tpBuscarGasto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgGasto).EndInit();
            tbGasto.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpAgregarEditarGasto;
        private ComboBox cbUnidades;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox cbTipos;
        private ComboBox cbLugares;
        private ComboBox cbMarcas;
        private ComboBox cbCategorias;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox txtAgregarEditar;
        private Label label1;
        private Label lblAgregarEditar;
        private Button btnRegresarEditarGuardar;
        private Button btnGuardarEditar;
        private TabPage tpBuscarGasto;
        private TextBox txtBuscarMarca;
        private Button btnIrEliminarLugar;
        private Button btnIrEditarLugar;
        private Button btnIrAgregarGasto;
        private Button btnBuscar;
        private DataGridView dgGasto;
        private TabControl tbGasto;
    }
}