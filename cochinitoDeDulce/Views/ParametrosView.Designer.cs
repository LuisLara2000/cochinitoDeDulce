namespace cochinitoDeDulce.Views
{
    partial class ParametrosView
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
            btnCategorias = new Button();
            btnMarcas = new Button();
            btnLugares = new Button();
            btnTipos = new Button();
            SuspendLayout();
            // 
            // btnCategorias
            // 
            btnCategorias.Location = new Point(25, 191);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(573, 174);
            btnCategorias.TabIndex = 0;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            // 
            // btnMarcas
            // 
            btnMarcas.Location = new Point(25, 371);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.Size = new Size(573, 174);
            btnMarcas.TabIndex = 1;
            btnMarcas.Text = "Marcas";
            btnMarcas.UseVisualStyleBackColor = true;
            // 
            // btnLugares
            // 
            btnLugares.Location = new Point(604, 191);
            btnLugares.Name = "btnLugares";
            btnLugares.Size = new Size(573, 174);
            btnLugares.TabIndex = 2;
            btnLugares.Text = "Lugares";
            btnLugares.UseVisualStyleBackColor = true;
            // 
            // btnTipos
            // 
            btnTipos.Location = new Point(604, 371);
            btnTipos.Name = "btnTipos";
            btnTipos.Size = new Size(573, 174);
            btnTipos.TabIndex = 3;
            btnTipos.Text = "Tipos";
            btnTipos.UseVisualStyleBackColor = true;
            // 
            // ParametrosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 748);
            Controls.Add(btnTipos);
            Controls.Add(btnLugares);
            Controls.Add(btnMarcas);
            Controls.Add(btnCategorias);
            Name = "ParametrosView";
            Text = "ParametrosView";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCategorias;
        private Button btnMarcas;
        private Button btnLugares;
        private Button btnTipos;
    }
}