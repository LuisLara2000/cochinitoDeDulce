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
            button2 = new Button();
            btnCategorias = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnCategorias);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 407);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(1, 0);
            button2.Name = "button2";
            button2.Size = new Size(197, 50);
            button2.TabIndex = 2;
            button2.Text = "Inicio";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            btnCategorias.Location = new Point(0, 48);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(197, 50);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            // 
            // PrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 407);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "PrincipalView";
            Text = "PrincipalView";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button btnCategorias;
    }
}