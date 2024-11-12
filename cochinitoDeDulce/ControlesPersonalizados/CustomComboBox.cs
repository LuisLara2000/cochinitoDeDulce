using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;// para heredar los controles
using System.Drawing;// para dibujar formas
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Design; // para establecer los atributos del componente
namespace cochinitoDeDulce.ControlesPersonalizados
{
    [DefaultEvent("OnSelectedIndexChanged")]// eventro predeternmidao
    public class CustomComboBox:UserControl
    {
        //campos para la apariencia
        private Color backColor = Color.WhiteSmoke;// color de fondo
        private Color iconColor = Color.MediumSlateBlue;// color del icono
        private Color listBackColor = Color.FromArgb(230, 228, 245);// color de la lista desplegable
        private Color listTextColor = Color.DimGray;// texto de la lista desplegable
        private Color borderColor = Color.MediumSlateBlue;// color del borde
        private int borderSize = 1;// tamaño del borde

        //El control personalizado estara compuesto de estos controles
        private ComboBox cmbList;// combo box estandar para poder dezplegar la lista 
        private Label lblText;// la etiqueta para mostrar el texto
        private Button btnIcon;// un boton para el icono, para presionarlo y que se muestre la lista desplegable

        // propiedades
        public new Color BackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }
        [Category("Custom Combo Box - Appearance")]
        public Color IconColor
        {
            get { return iconColor; }
            set
            {
                iconColor = value;
                btnIcon.Invalidate();//Redraw icon, para poder redibuajr el icono
            }
        }
        [Category("Custom Combo Box - Appearance")]
        public Color ListBackColor
        {
            get { return listBackColor; }
            set
            {
                listBackColor = value;
                cmbList.BackColor = listBackColor;
            }
        }
        [Category("Custom Combo Box - Appearance")]
        public Color ListTextColor
        {
            get { return listTextColor; }
            set
            {
                listTextColor = value;
                cmbList.ForeColor = listTextColor;
            }
        }
        [Category("Custom Combo Box - Appearance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                base.BackColor = borderColor; //Border Color
            }
        }
        [Category("Custom Combo Box - Appearance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);//Border Size
                AdjustComboBoxDimensions();
            }
        }
        [Category("Custom Combo Box - Appearance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }
        [Category("Custom Combo Box - Appearance")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = value;//Optional
            }
        }
        [Category("Custom Combo Box - Appearance")]
        public string Texts
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }
        [Category("Custom Combo Box - Appearance")]
        public ComboBoxStyle DropDownStyle
        {
            get { return cmbList.DropDownStyle; }
            set
            {
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }
        // data
        [Category("RJ Code - Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            // retornamos la propiedad items del combo box
            get { return cmbList.Items; }
        }
        [Category("RJ Code - Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return cmbList.DataSource; }
            set { cmbList.DataSource = value; }
        }
        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return cmbList.AutoCompleteCustomSource; }
            set { cmbList.AutoCompleteCustomSource = value; }
        }
        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return cmbList.AutoCompleteSource; }
            set { cmbList.AutoCompleteSource = value; }
        }
        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return cmbList.AutoCompleteMode; }
            set { cmbList.AutoCompleteMode = value; }
        }
        [Category("RJ Code - Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get { return cmbList.SelectedItem; }
            set { cmbList.SelectedItem = value; }
        }
        [Category("RJ Code - Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get { return cmbList.SelectedIndex; }
            set { cmbList.SelectedIndex = value; }
        }
        [Category("RJ Code - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember
        {
            get { return cmbList.DisplayMember; }
            set { cmbList.DisplayMember = value; }
        }
        [Category("RJ Code - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get { return cmbList.ValueMember; }
            set { cmbList.ValueMember = value; }
        }

        //Evento predetermidado del control
        // volveremos a implementar el evento predetermidado del combobox

        public event EventHandler OnSelectedIndexChanged;//Default event

        // contructor
        public CustomComboBox()
        {
            // inicializamos los componentes
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            //ComboBox: Dropdown list
            cmbList.BackColor = listBackColor;// establecemos un color de fondo
            cmbList.Font = new Font(this.Font.Name, 10F);// tipo de letra
            cmbList.ForeColor = listTextColor;// color de letra

            // sucribimos el eventro predeterminado del combobox default a nuestro evento de nuestro control personalizado
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);//Default event
            // tambien es necesario suscribir el evento TextChanged para actualizar el texto del control
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged);//Refresh text
                                                                          
            //Button: Icon
            btnIcon.Dock = DockStyle.Right;// debe estar acoplado al lado derecho
            btnIcon.FlatStyle = FlatStyle.Flat;// bordes planos
            btnIcon.FlatAppearance.BorderSize = 0;// grosor
            btnIcon.BackColor = backColor;// color de fondo
            btnIcon.Size = new Size(30, 30);// tamaño
            btnIcon.Cursor = Cursors.Hand;
            // suscribimos el evento click para abrir la lista desplegable
            btnIcon.Click += new EventHandler(Icon_Click);//Open dropdown list
            // y el evento pait para dibujar el icono del boton
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);//Draw icon
            
            //Label: Text
            lblText.Dock = DockStyle.Fill;// el texto tomara el espacio restante que le deje el boton
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);
            //->Attach label events to user control event
            lblText.Click += new EventHandler(Surface_Click);//Select combo box
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave);

            //User Control
            // deben agregarse en ese orden
            this.Controls.Add(lblText);//2
            this.Controls.Add(btnIcon);//1
            this.Controls.Add(cmbList);//0
            
            this.MinimumSize = new Size(100, 30);
            this.Size = new Size(100, 30); // sdignamos el tamaño
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);//Border Size, responsable de hacer le tamaño de borde
            this.Font = new Font(this.Font.Name, 10F);
            base.BackColor = borderColor; //Border Color, es responable del color de borde
            this.ResumeLayout();
            AdjustComboBoxDimensions();// establecer el ancho y ubicacion del combo box
        }

        private void AdjustComboBoxDimensions()
        {


            // el ancho del combobox sera igual al ancho de la etiquta
            cmbList.Width = lblText.Width;
            // ubicado en la parte inferiro derecha
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }

        private void Surface_MouseLeave(object? sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object? sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void Surface_Click(object? sender, EventArgs e)
        {
            //Attach label click to user control click
            // cuado demos click en la etiqueta, seleccionamos el combo box
            this.OnClick(e);
            //Select combo box
            cmbList.Select();
            // si es un combo box modo lista, despleagamos la lista
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true;//Open dropdown list
        }

        private void Icon_Paint(object? sender, PaintEventArgs e)
        {
            //Fields
            int iconWidht = 14;
            int iconHeight = 6;
            // centramos el rectangulo
            var rectIcon = new Rectangle((btnIcon.Width - iconWidht) / 2, (btnIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            // objeto de tipo graficos
            Graphics graph = e.Graphics;

            //Draw arrow down icon
            // creamos un objeto grafico
            using (GraphicsPath path = new GraphicsPath())
                // y un boligrafo
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);// dibujamos una linea asi \
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);// despues dibujamos una linea asa /
                graph.DrawPath(pen, path);
            }
        }

        private void Icon_Click(object? sender, EventArgs e)
        {
            // seleccionamos el combo box
            cmbList.Select();
            cmbList.DroppedDown = true;//Open dropdown list
        }

        private void ComboBox_TextChanged(object? sender, EventArgs e)
        {
            //Refresh text
            lblText.Text = cmbList.Text;
        }

        // evento predeterminado de nuestro control
        private void ComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            //Refresh text
            lblText.Text = cmbList.Text;
        }

        //Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }
    }
}
