﻿namespace cochinitoDeDulce.Views
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
            btnRegresar = new Button();
            txtIdCategoria = new TextBox();
            txtNombreCategoria = new TextBox();
            label3 = new Label();
            btnGuardar = new Button();
            label2 = new Label();
            tpCategoriasVer = new TabPage();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            btnBuscar = new Button();
            txtBuscarCategoria = new TextBox();
            dgCategorias = new DataGridView();
            tbCategorias = new TabControl();
            tpEliminar = new TabPage();
            btnEliminarCategoriaCancelar = new Button();
            btnEliminarCategoriaEliminar = new Button();
            cbEliminarCategoria = new ComboBox();
            label1 = new Label();
            tpCategoriasAgregarEditar.SuspendLayout();
            tpCategoriasVer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCategorias).BeginInit();
            tbCategorias.SuspendLayout();
            tpEliminar.SuspendLayout();
            SuspendLayout();
            // 
            // tpCategoriasAgregarEditar
            // 
            tpCategoriasAgregarEditar.Controls.Add(btnRegresar);
            tpCategoriasAgregarEditar.Controls.Add(txtIdCategoria);
            tpCategoriasAgregarEditar.Controls.Add(txtNombreCategoria);
            tpCategoriasAgregarEditar.Controls.Add(label3);
            tpCategoriasAgregarEditar.Controls.Add(btnGuardar);
            tpCategoriasAgregarEditar.Controls.Add(label2);
            tpCategoriasAgregarEditar.Location = new Point(4, 24);
            tpCategoriasAgregarEditar.Name = "tpCategoriasAgregarEditar";
            tpCategoriasAgregarEditar.Padding = new Padding(3);
            tpCategoriasAgregarEditar.Size = new Size(632, 422);
            tpCategoriasAgregarEditar.TabIndex = 2;
            tpCategoriasAgregarEditar.Text = "/GuardarCategoria";
            tpCategoriasAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(318, 240);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(308, 23);
            btnRegresar.TabIndex = 8;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
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
            // btnGuardar
            // 
            btnGuardar.Location = new Point(6, 240);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(307, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
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
            tpCategoriasVer.Controls.Add(txtBuscarCategoria);
            tpCategoriasVer.Controls.Add(dgCategorias);
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
            // txtBuscarCategoria
            // 
            txtBuscarCategoria.Location = new Point(8, 6);
            txtBuscarCategoria.Name = "txtBuscarCategoria";
            txtBuscarCategoria.Size = new Size(534, 23);
            txtBuscarCategoria.TabIndex = 1;
            // 
            // dgCategorias
            // 
            dgCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategorias.Location = new Point(6, 35);
            dgCategorias.Name = "dgCategorias";
            dgCategorias.Size = new Size(617, 339);
            dgCategorias.TabIndex = 0;
            // 
            // tbCategorias
            // 
            tbCategorias.Controls.Add(tpCategoriasVer);
            tbCategorias.Controls.Add(tpCategoriasAgregarEditar);
            tbCategorias.Controls.Add(tpEliminar);
            tbCategorias.Dock = DockStyle.Fill;
            tbCategorias.Location = new Point(0, 0);
            tbCategorias.Name = "tbCategorias";
            tbCategorias.SelectedIndex = 0;
            tbCategorias.Size = new Size(640, 450);
            tbCategorias.TabIndex = 0;
            // 
            // tpEliminar
            // 
            tpEliminar.Controls.Add(btnEliminarCategoriaCancelar);
            tpEliminar.Controls.Add(btnEliminarCategoriaEliminar);
            tpEliminar.Controls.Add(cbEliminarCategoria);
            tpEliminar.Controls.Add(label1);
            tpEliminar.Location = new Point(4, 24);
            tpEliminar.Name = "tpEliminar";
            tpEliminar.Padding = new Padding(3);
            tpEliminar.Size = new Size(632, 422);
            tpEliminar.TabIndex = 3;
            tpEliminar.Text = "Eliminar categoria";
            tpEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCategoriaCancelar
            // 
            btnEliminarCategoriaCancelar.Location = new Point(318, 179);
            btnEliminarCategoriaCancelar.Name = "btnEliminarCategoriaCancelar";
            btnEliminarCategoriaCancelar.Size = new Size(190, 98);
            btnEliminarCategoriaCancelar.TabIndex = 7;
            btnEliminarCategoriaCancelar.Text = "Cancelar";
            btnEliminarCategoriaCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCategoriaEliminar
            // 
            btnEliminarCategoriaEliminar.Location = new Point(101, 179);
            btnEliminarCategoriaEliminar.Name = "btnEliminarCategoriaEliminar";
            btnEliminarCategoriaEliminar.Size = new Size(190, 98);
            btnEliminarCategoriaEliminar.TabIndex = 6;
            btnEliminarCategoriaEliminar.Text = "Eliminar";
            btnEliminarCategoriaEliminar.UseVisualStyleBackColor = true;
            // 
            // cbEliminarCategoria
            // 
            cbEliminarCategoria.FormattingEnabled = true;
            cbEliminarCategoria.Location = new Point(20, 150);
            cbEliminarCategoria.Name = "cbEliminarCategoria";
            cbEliminarCategoria.Size = new Size(592, 23);
            cbEliminarCategoria.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 132);
            label1.Name = "label1";
            label1.Size = new Size(438, 15);
            label1.TabIndex = 4;
            label1.Text = "La categoria \"inserte categoria\" al ser eliminada sera reemplazada por la categoria:";
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
            ((System.ComponentModel.ISupportInitialize)dgCategorias).EndInit();
            tbCategorias.ResumeLayout(false);
            tpEliminar.ResumeLayout(false);
            tpEliminar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpCategoriasAgregarEditar;
        private TextBox txtIdCategoria;
        private TextBox txtNombreCategoria;
        private Label label3;
        private Button btnGuardar;
        private Label label2;
        private TabPage tpCategoriasVer;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private Button btnBuscar;
        private TextBox txtBuscarCategoria;
        private DataGridView dgCategorias;
        private TabControl tbCategorias;
        private Button btnRegresar;
        private TabPage tpEliminar;
        private ComboBox cbEliminarCategoria;
        private Label label1;
        private Button btnEliminarCategoriaCancelar;
        private Button btnEliminarCategoriaEliminar;
    }
}