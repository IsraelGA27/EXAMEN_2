namespace EXAMEN_2

{
    public partial class Form1 : Form
    {
        private Button btnVentana; // Va a ser el "Calcular"
        private int num; // Para recorrer lo que obtengamos del Form2

        private Label? lblFigura;
        private ComboBox? cmbFiguras;
        private Label? lblCalculo;
        private TextBox? txtMonto;


        public Form1()
        {
            num = 1;
            btnVentana = new Button();
            InitializeComponent();
            InicializarComponenetes();
        }


        private void InicializarComponenetes()
        {
            // Tamaño de la ventana
            this.Size = new Size(300, 350);
            this.Text = "Inicio";

            //Etiqueta Moneda
            lblFigura = new Label();
            lblFigura.Text = "Moneda";
            lblFigura.AutoSize = true;
            lblFigura.Location = new Point(10, 10);

            //ComboBox Monedas
            cmbFiguras = new ComboBox();
            cmbFiguras.Items.Add("Selecciona Moneda");
            cmbFiguras.Items.Add("MXN (Peso Mexicano)");
            cmbFiguras.Items.Add("USD (Dolar Estadounidense)");
            cmbFiguras.Items.Add("CAD (Dolar Canadiense)");
            cmbFiguras.Items.Add("EUR (Euro)");
            cmbFiguras.Items.Add("JPY (Yen Japones)");

            cmbFiguras.SelectedIndex = 0;
            cmbFiguras.Location = new Point(10, 40);
            cmbFiguras.SelectedValueChanged += new EventHandler(cmb_ValueChanged);

            //Etiqueta Monto
            lblCalculo = new Label();
            lblCalculo.Text = "Monto";
            lblCalculo.AutoSize = true;
            lblCalculo.Location = new Point(150, 10);

            //Cuadro de texto para el Monto
            txtMonto = new TextBox();
            txtMonto.Size = new Size(100, 20);
            txtMonto.Location = new Point(150, 40);


            btnVentana.Text = "Calcular";
            btnVentana.AutoSize = true;

            btnVentana.Location = new Point(150,70);
            btnVentana.Click += new EventHandler(btnVentana_Click);
            this.Controls.Add(btnVentana);

            //Agregar controles a la ventana
            this.Controls.Add(lblFigura);
            this.Controls.Add(cmbFiguras);
            this.Controls.Add(lblCalculo);
            this.Controls.Add(btnVentana);
            this.Controls.Add(txtMonto);

        }

        private void cmb_ValueChanged(object sender, EventArgs e)
        {
            if (cmbFiguras.SelectedIndex != 0)
            {
                if (cmbFiguras.SelectedItem.ToString() == "MXN (Peso Mexicano)")
                {
                    //cmbFigura.SelectedIndex==1 Siempre va en comentario esta linea
                    //if (cmbCalculos.SelectedItem.ToString() == "Périmetro")
                    //{

                    //}
                    //if (cmbCalculos.SelectedItem.ToString() == "Área")
                    //{

                    //}
                }
                if (cmbFiguras.SelectedItem.ToString() == "USD (Dolar Estadounidense)")
                {

                }
                if (cmbFiguras.SelectedItem.ToString() == "CAD (Dolar Canadiense)")
                {

                }
                if (cmbFiguras.SelectedItem.ToString() == "EUR (Euro)")
                {

                }
                if (cmbFiguras.SelectedItem.ToString() == "JPY (Yen Japones)")
                {

                }
            }
            else
            {
                //txtAltura.Visible = false;
                //lblAltura.Visible = false;
            }
        }





        private void btnVentana_Click(Object? sender, EventArgs e) // Calcular
        {
            Form2 frmVentana = new Form2();
            if (frmVentana.ShowDialog() == DialogResult.OK)
            {
                Label lblAgregado = new Label();
                lblAgregado.Text = frmVentana.mensaje; // Obtener un valor de el otro formulario
                lblAgregado.AutoSize = true;    
                lblAgregado.Location = new Point(10,60*num);
                num++; // Recorrer
                this.Controls.Add(lblAgregado);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}