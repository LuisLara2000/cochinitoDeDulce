namespace cochinitoDeDulce.Views
{
    partial class PrincipalView
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
            panel1 = new Panel();
            btnTipos = new Button();
            btnMarcas = new Button();
            btnLugares = new Button();
            btnParametros = new Button();
            btnIngresos = new Button();
            btnGastos = new Button();
            button2 = new Button();
            btnCategorias = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTipos);
            panel1.Controls.Add(btnMarcas);
            panel1.Controls.Add(btnLugares);
            panel1.Controls.Add(btnParametros);
            panel1.Controls.Add(btnIngresos);
            panel1.Controls.Add(btnGastos);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnCategorias);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 520);
            panel1.TabIndex = 0;
            // 
            // btnTipos
            // 
            btnTipos.Location = new Point(12, 447);
            btnTipos.Name = "btnTipos";
            btnTipos.Size = new Size(188, 50);
            btnTipos.TabIndex = 8;
            btnTipos.Text = "Tipos";
            btnTipos.UseVisualStyleBackColor = true;
            // 
            // btnMarcas
            // 
            btnMarcas.Location = new Point(12, 355);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.Size = new Size(188, 50);
            btnMarcas.TabIndex = 7;
            btnMarcas.Text = "Marcas";
            btnMarcas.UseVisualStyleBackColor = true;
            // 
            // btnLugares
            // 
            btnLugares.Location = new Point(11, 401);
            btnLugares.Name = "btnLugares";
            btnLugares.Size = new Size(188, 50);
            btnLugares.TabIndex = 6;
            btnLugares.Text = "Lugares";
            btnLugares.UseVisualStyleBackColor = true;
            // 
            // btnParametros
            // 
            btnParametros.Location = new Point(3, 264);
            btnParametros.Name = "btnParametros";
            btnParametros.Size = new Size(197, 50);
            btnParametros.TabIndex = 5;
            btnParametros.Text = "Parametros";
            btnParametros.UseVisualStyleBackColor = true;
            // 
            // btnIngresos
            // 
            btnIngresos.Location = new Point(3, 218);
            btnIngresos.Name = "btnIngresos";
            btnIngresos.Size = new Size(197, 50);
            btnIngresos.TabIndex = 4;
            btnIngresos.Text = "Ingresos";
            btnIngresos.UseVisualStyleBackColor = true;
            // 
            // btnGastos
            // 
            btnGastos.Location = new Point(2, 171);
            btnGastos.Name = "btnGastos";
            btnGastos.Size = new Size(197, 50);
            btnGastos.TabIndex = 3;
            btnGastos.Text = "Gastos";
            btnGastos.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 124);
            button2.Name = "button2";
            button2.Size = new Size(197, 50);
            button2.TabIndex = 2;
            button2.Text = "Inicio";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            btnCategorias.Location = new Point(12, 310);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(188, 50);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoTemporal;
            pictureBox1.Location = new Point(27, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // PrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 520);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "PrincipalView";
            Text = "Cochinito de dulce";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button btnCategorias;
        private Button btnTipos;
        private Button btnMarcas;
        private Button btnLugares;
        private Button btnParametros;
        private Button btnIngresos;
        private Button btnGastos;
        private PictureBox pictureBox1;
    }
}