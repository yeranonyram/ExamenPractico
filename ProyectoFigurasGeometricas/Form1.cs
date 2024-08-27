namespace ProyectoFigurasGeometricas
{
    public partial class Form1 : Form
    {
        private Stack<Poligono> pilaPoligonos = new Stack<Poligono>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearTriangulo_Click(object sender, EventArgs e)
        {
            double baseTriangulo = double.Parse(txtBaseTriangulo.Text);
            double altura = double.Parse(txtAlturaTriangulo.Text);
            Triangulo triangulo = new Triangulo(baseTriangulo, altura);
            pilaPoligonos.Push(triangulo);
            lblPila.Text += triangulo.ToString() + Environment.NewLine;
        }

        private void btnCrearRectangulo_Click(object sender, EventArgs e)
        {
            double ancho = double.Parse(txtAnchoRectangulo.Text);
            double alto = double.Parse(txtAltoRectangulo.Text);
            Rectangulo rectangulo = new Rectangulo(ancho, alto);
            pilaPoligonos.Push(rectangulo);
            lblPila.Text += rectangulo.ToString() + Environment.NewLine;
        }

        private void btnCrearParalelogramo_Click(object sender, EventArgs e)
        {
            double baseParalelogramo = double.Parse(txtBaseParalelogramo.Text);
            double altura = double.Parse(txtAlturaParalelogramo.Text);
            Paralelogramo paralelogramo = new Paralelogramo(baseParalelogramo, altura);
            pilaPoligonos.Push(paralelogramo);
            lblPila.Text += paralelogramo.ToString() + Environment.NewLine;
        }

        private void btnMostrarPila_Click(object sender, EventArgs e)
        {
            lblPila.Text = "Elementos en la pila:" + Environment.NewLine;
            foreach (Poligono poligono in pilaPoligonos)
            {
                lblPila.Text += poligono.ToString() + Environment.NewLine;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
