namespace ABB_UCV
{
    public partial class Form1 : Form
    {
        //private ArbolBinario arbol; // Instancia del árbol binario
        private ArbolBinario arbol; // Instancia del árbol binario
        private TreeDrawer treeDrawer;
        // Variables para almacenar los colores seleccionados
        private Color colorRaiz = Color.Red;
        private Color colorNodosInternos = Color.Green;
        private Color colorNodosTerminales = Color.Blue;

        public Form1()
        {
            InitializeComponent();
            arbol = new ArbolBinario();
            treeDrawer = new TreeDrawer(arbol, panelDibujo, colorRaiz, colorNodosInternos, colorNodosTerminales);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                arbol.Insertar(valor);
                treeDrawer.Redibujar();
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
                    treeDrawer = new TreeDrawer(arbol, panelDibujo, colorRaiz, colorNodosInternos, colorNodosTerminales);
                    treeDrawer.Redibujar();
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
                    treeDrawer = new TreeDrawer(arbol, panelDibujo, colorRaiz, colorNodosInternos, colorNodosTerminales);
                    treeDrawer.Redibujar();
                }
            }
        }

        private void btnColorNodosTerminales_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorNodosTerminales = colorDialog.Color;
                    treeDrawer = new TreeDrawer(arbol, panelDibujo, colorRaiz, colorNodosInternos, colorNodosTerminales);
                    treeDrawer.Redibujar();
                }
            }
        }

        private void btnMostrarSuma_Click(object sender, EventArgs e)
        {
            int suma = arbol.SumaElementos(arbol.Raiz);
            MessageBox.Show($"Suma de los elementos del árbol: {suma}");
        }

        private void btnMostrarSumaMultiplos_Click(object sender, EventArgs e)
        {
            int suma2 = arbol.SumaMultiplos(arbol.Raiz, 2);
            int suma3 = arbol.SumaMultiplos(arbol.Raiz, 3);
            int suma5 = arbol.SumaMultiplos(arbol.Raiz, 5);
            MessageBox.Show($"Suma de múltiplos de 2: {suma2}\nSuma de múltiplos de 3: {suma3}\nSuma de múltiplos de 5: {suma5}");
        }

        private void btnMostrarMaxMin_Click(object sender, EventArgs e)
        {
            try
            {
                int maximo = arbol.Maximo(arbol.Raiz);
                int minimo = arbol.Minimo(arbol.Raiz);
                MessageBox.Show($"Máximo: {maximo}\nMínimo: {minimo}");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            int altura = arbol.Altura(arbol.Raiz);
            MessageBox.Show($"Altura del árbol: {altura}");
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            List<int> elementos = new List<int>();
            arbol.InOrden(arbol.Raiz, valor => elementos.Add(valor));
            MessageBox.Show($"Recorrido InOrden: {string.Join(", ", elementos)}");
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            List<int> elementos = new List<int>();
            arbol.PreOrden(arbol.Raiz, valor => elementos.Add(valor));
            MessageBox.Show($"Recorrido PreOrden: {string.Join(", ", elementos)}");
        }

        private void btnPosOrden_Click(object sender, EventArgs e)
        {
            List<int> elementos = new List<int>();
            arbol.PosOrden(arbol.Raiz, valor => elementos.Add(valor));
            MessageBox.Show($"Recorrido PosOrden: {string.Join(", ", elementos)}");
        }
    }
}
