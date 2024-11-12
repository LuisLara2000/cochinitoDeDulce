﻿namespace cochinitoDeDulce.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalView));
            panel1 = new Panel();
            pbLogo = new PictureBox();
            btnTipos = new Button();
            btnMarcas = new Button();
            btnLugares = new Button();
            btnIngresos = new Button();
            btnGastos = new Button();
            btnInicio = new Button();
            btnCategorias = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pbLogo);
            panel1.Controls.Add(btnTipos);
            panel1.Controls.Add(btnMarcas);
            panel1.Controls.Add(btnLugares);
            panel1.Controls.Add(btnIngresos);
            panel1.Controls.Add(btnGastos);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(btnCategorias);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 520);
            panel1.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(19, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(120, 120);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 9;
            pbLogo.TabStop = false;
            // 
            // btnTipos
            // 
            btnTipos.Location = new Point(0, 425);
            btnTipos.Name = "btnTipos";
            btnTipos.Size = new Size(150, 50);
            btnTipos.TabIndex = 8;
            btnTipos.Text = "Tipos";
            btnTipos.UseVisualStyleBackColor = true;
            // 
            // btnMarcas
            // 
            btnMarcas.Location = new Point(0, 325);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.Size = new Size(150, 50);
            btnMarcas.TabIndex = 7;
            btnMarcas.Text = "Marcas";
            btnMarcas.UseVisualStyleBackColor = true;
            // 
            // btnLugares
            // 
            btnLugares.Location = new Point(0, 375);
            btnLugares.Name = "btnLugares";
            btnLugares.Size = new Size(150, 50);
            btnLugares.TabIndex = 6;
            btnLugares.Text = "Lugares";
            btnLugares.UseVisualStyleBackColor = true;
            // 
            // btnIngresos
            // 
            btnIngresos.Location = new Point(0, 225);
            btnIngresos.Name = "btnIngresos";
            btnIngresos.Size = new Size(150, 50);
            btnIngresos.TabIndex = 4;
            btnIngresos.Text = "Ingresos";
            btnIngresos.UseVisualStyleBackColor = true;
            // 
            // btnGastos
            // 
            btnGastos.BackColor = SystemColors.ControlLightLight;
            btnGastos.Location = new Point(0, 175);
            btnGastos.Name = "btnGastos";
            btnGastos.Size = new Size(150, 50);
            btnGastos.TabIndex = 3;
            btnGastos.Text = "Gastos";
            btnGastos.UseVisualStyleBackColor = false;
            btnGastos.Click += btnGastos_Click;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(0, 125);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(150, 50);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            btnCategorias.Location = new Point(0, 275);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(150, 50);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 474);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 10;
            button1.Text = "Parametros";
            button1.UseVisualStyleBackColor = true;
            // 
            // PrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 520);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = Color.FromArgb(52, 52, 52);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "PrincipalView";
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cochinito de dulce";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnInicio;
        private Button btnCategorias;
        private Button btnTipos;
        private Button btnMarcas;
        private Button btnLugares;
        private Button btnIngresos;
        private Button btnGastos;
        private PictureBox pbLogo;
        private Button button1;
    }
}