namespace Inventario_Secciones
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Seccion secciones = new Seccion();
            secciones.ShowDialog();
        }
    }
}
