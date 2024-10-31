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
            tpAgregarEditarMarca = new TabPage();
            tpEliminarMarca = new TabPage();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button7 = new Button();
            button8 = new Button();
            tbMarca.SuspendLayout();
            tpBuscarMarca.SuspendLayout();
            tpAgregarEditarMarca.SuspendLayout();
            tpEliminarMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tbMarca.SelectedIndexChanged += this.tbMarca_SelectedIndexChanged;
            // 
            // tpBuscarMarca
            // 
            tpBuscarMarca.Controls.Add(textBox1);
            tpBuscarMarca.Controls.Add(button4);
            tpBuscarMarca.Controls.Add(button3);
            tpBuscarMarca.Controls.Add(button2);
            tpBuscarMarca.Controls.Add(button1);
            tpBuscarMarca.Controls.Add(dataGridView1);
            tpBuscarMarca.Location = new Point(4, 24);
            tpBuscarMarca.Name = "tpBuscarMarca";
            tpBuscarMarca.Padding = new Padding(3);
            tpBuscarMarca.Size = new Size(644, 412);
            tpBuscarMarca.TabIndex = 0;
            tpBuscarMarca.Text = "Todas las marcas";
            tpBuscarMarca.UseVisualStyleBackColor = true;
            // 
            // tpAgregarEditarMarca
            // 
            tpAgregarEditarMarca.Controls.Add(textBox2);
            tpAgregarEditarMarca.Controls.Add(label1);
            tpAgregarEditarMarca.Controls.Add(button6);
            tpAgregarEditarMarca.Controls.Add(button5);
            tpAgregarEditarMarca.Location = new Point(4, 24);
            tpAgregarEditarMarca.Name = "tpAgregarEditarMarca";
            tpAgregarEditarMarca.Padding = new Padding(3);
            tpAgregarEditarMarca.Size = new Size(644, 412);
            tpAgregarEditarMarca.TabIndex = 1;
            tpAgregarEditarMarca.Text = "AgregarEditar marca";
            tpAgregarEditarMarca.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(363, 392);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(561, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(377, 35);
            button2.Name = "button2";
            button2.Size = new Size(259, 117);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(377, 158);
            button3.Name = "button3";
            button3.Size = new Size(259, 117);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(377, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 5;
            // 
            // button5
            // 
            button5.Location = new Point(27, 235);
            button5.Name = "button5";
            button5.Size = new Size(296, 22);
            button5.TabIndex = 0;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(329, 235);
            button6.Name = "button6";
            button6.Size = new Size(296, 22);
            button6.TabIndex = 1;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 163);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(598, 23);
            textBox2.TabIndex = 3;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 187);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(599, 23);
            comboBox1.TabIndex = 1;
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
            // button8
            // 
            button8.Location = new Point(325, 225);
            button8.Name = "button8";
            button8.Size = new Size(298, 23);
            button8.TabIndex = 3;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
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
            tpAgregarEditarMarca.ResumeLayout(false);
            tpAgregarEditarMarca.PerformLayout();
            tpEliminarMarca.ResumeLayout(false);
            tpEliminarMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbMarca;
        private TabPage tpBuscarMarca;
        private TabPage tpAgregarEditarMarca;
        private TabPage tpEliminarMarca;
        private TextBox textBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Label label1;
        private Button button6;
        private Button button5;
        private ComboBox comboBox1;
        private Label label2;
        private Button button8;
        private Button button7;
    }
}