namespace cochinitoDeDulce.Views
{
    partial class CategoriasView
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
            tpCategoriasAgregarEditar = new TabPage();
            txtIdCategoria = new TextBox();
            txtNombreCategoria = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            tpCategoriasVer = new TabPage();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            tbCategorias = new TabControl();
            tpCategoriasAgregarEditar.SuspendLayout();
            tpCategoriasVer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tbCategorias.SuspendLayout();
            SuspendLayout();
            // 
            // tpCategoriasAgregarEditar
            // 
            tpCategoriasAgregarEditar.Controls.Add(txtIdCategoria);
            tpCategoriasAgregarEditar.Controls.Add(txtNombreCategoria);
            tpCategoriasAgregarEditar.Controls.Add(label3);
            tpCategoriasAgregarEditar.Controls.Add(button1);
            tpCategoriasAgregarEditar.Controls.Add(label2);
            tpCategoriasAgregarEditar.Location = new Point(4, 24);
            tpCategoriasAgregarEditar.Name = "tpCategoriasAgregarEditar";
            tpCategoriasAgregarEditar.Padding = new Padding(3);
            tpCategoriasAgregarEditar.Size = new Size(632, 422);
            tpCategoriasAgregarEditar.TabIndex = 2;
            tpCategoriasAgregarEditar.Text = "Editar";
            tpCategoriasAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Location = new Point(6, 165);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(616, 23);
            txtIdCategoria.TabIndex = 7;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(8, 211);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(616, 23);
            txtNombreCategoria.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 147);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 6;
            label3.Text = "Id de la categoria";
            // 
            // button1
            // 
            button1.Location = new Point(8, 238);
            button1.Name = "button1";
            button1.Size = new Size(616, 23);
            button1.TabIndex = 5;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 191);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre de la categoria";
            // 
            // tpCategoriasVer
            // 
            tpCategoriasVer.Controls.Add(btnEliminar);
            tpCategoriasVer.Controls.Add(btnEditar);
            tpCategoriasVer.Controls.Add(btnAgregar);
            tpCategoriasVer.Controls.Add(btnBuscar);
            tpCategoriasVer.Controls.Add(textBox1);
            tpCategoriasVer.Controls.Add(dataGridView1);
            tpCategoriasVer.Location = new Point(4, 24);
            tpCategoriasVer.Name = "tpCategoriasVer";
            tpCategoriasVer.Padding = new Padding(3);
            tpCategoriasVer.Size = new Size(632, 422);
            tpCategoriasVer.TabIndex = 0;
            tpCategoriasVer.Text = "Todas las categorias";
            tpCategoriasVer.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(422, 380);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(201, 34);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(215, 380);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(201, 34);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(8, 380);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(201, 34);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(548, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(534, 23);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(617, 339);
            dataGridView1.TabIndex = 0;
            // 
            // tbCategorias
            // 
            tbCategorias.Controls.Add(tpCategoriasVer);
            tbCategorias.Controls.Add(tpCategoriasAgregarEditar);
            tbCategorias.Dock = DockStyle.Fill;
            tbCategorias.Location = new Point(0, 0);
            tbCategorias.Name = "tbCategorias";
            tbCategorias.SelectedIndex = 0;
            tbCategorias.Size = new Size(640, 450);
            tbCategorias.TabIndex = 0;
            // 
            // CategoriasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 450);
            Controls.Add(tbCategorias);
            Name = "CategoriasView";
            Text = "CategoriasView";
            tpCategoriasAgregarEditar.ResumeLayout(false);
            tpCategoriasAgregarEditar.PerformLayout();
            tpCategoriasVer.ResumeLayout(false);
            tpCategoriasVer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tbCategorias.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpCategoriasAgregarEditar;
        private TextBox txtIdCategoria;
        private TextBox txtNombreCategoria;
        private Label label3;
        private Button button1;
        private Label label2;
        private TabPage tpCategoriasVer;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private Button btnBuscar;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private TabControl tbCategorias;
    }
}