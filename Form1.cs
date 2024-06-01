namespace ABB_UCV
{
    public partial class Form1 : Form
    {
        private ArbolBinario arbol; // Instancia del árbol binario
        public Form1()
        {
            InitializeComponent();
            arbol = new ArbolBinario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                arbol.Insertar(valor);
                ActualizarTreeView();
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido.");
            }
            // Método para actualizar el TreeView
            private void ActualizarTreeView()
            {
                treeView.Nodes.Clear();
                AgregarNodoEnTreeView(arbol.Raiz, null);
            }
        }
    }
}
