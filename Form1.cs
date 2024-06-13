namespace ABB_UCV
{
    public partial class Form1 : Form
    {
        //private ArbolBinario arbol; // Instancia del árbol binario
        private ArbolBinario arbol; // Instancia del árbol binario

        // Variables para almacenar los colores seleccionados
        private Color colorRaiz = Color.Red;
        private Color colorNodosInternos = Color.Green;
        private Color colorNodosTerminales = Color.Blue;

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

        }
        // Método para actualizar el TreeView
        private void ActualizarTreeView()
        {
            treeView.Nodes.Clear();
            AgregarNodoEnTreeView(arbol.Raiz, null);
        }
        // Método recursivo para agregar nodos en el TreeView
        private void AgregarNodoEnTreeView(Nodo nodo, TreeNode treeNode)
        {
            /* if (nodo == null) return;

             TreeNode nuevoNodo = new TreeNode(nodo.Valor.ToString());
             if (treeNode == null)
             {
                 treeView.Nodes.Add(nuevoNodo);
             }
             else
             {
                 treeNode.Nodes.Add(nuevoNodo);
             }

             AgregarNodoEnTreeView(nodo.Izquierdo, nuevoNodo);
             AgregarNodoEnTreeView(nodo.Derecho, nuevoNodo);*/
            if (nodo == null) return;

            TreeNode nuevoNodo = new TreeNode(nodo.Valor.ToString());

            // Asignar colores según el tipo de nodo
            if (treeNode == null) // Nodo raíz
            {
                nuevoNodo.ForeColor = colorRaiz;
            }
            else if (nodo.Izquierdo == null && nodo.Derecho == null) // Nodo terminal
            {
                nuevoNodo.ForeColor = colorNodosTerminales;
            }
            else // Nodo interno
            {
                nuevoNodo.ForeColor = colorNodosInternos;
            }

            if (treeNode == null)
            {
                treeView.Nodes.Add(nuevoNodo);
            }
            else
            {
                treeNode.Nodes.Add(nuevoNodo);
            }

            AgregarNodoEnTreeView(nodo.Izquierdo, nuevoNodo);
            AgregarNodoEnTreeView(nodo.Derecho, nuevoNodo);
        }

        private void btnColorRaiz_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorRaiz = colorDialog.Color;
                }
            }
        }

        private void btnColorNodosInternos_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorNodosInternos = colorDialog.Color;
                }
            }
        }

    }
}
