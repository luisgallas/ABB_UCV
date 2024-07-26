using System.Windows.Forms;

namespace ABB_UCV
{
    public partial class Form1 : Form
    {
        //private ArbolBinario arbol; // Instancia del árbol binario
        private ArbolBinario arbol; // Instancia del árbol binario
        private TreeDrawer treeDrawer;
        
        private List<Nodo> recorridoActual;
        // Variables para almacenar los colores seleccionados
       // private Panel panelArbol;
        private Color colorRaiz = Color.Red;
        private Color colorNodosInternos = Color.Green;
        private Color colorNodosTerminales = Color.Blue;

        public Form1()
        {
            InitializeComponent();
            /*Bitmap img = new Bitmap(Application.StartupPath + @"\image\uca.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch; */
            arbol = new ArbolBinario();
            treeDrawer = new TreeDrawer(arbol, panelArbol, Color.Red, Color.Green, Color.Blue, Color.Yellow);
            //treeDrawer = new TreeDrawer(arbol, panelDibujo, colorRaiz, colorNodosInternos, colorNodosTerminales);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile("\"C:\\Users\\pedfe\\OneDrive\\Pictures\\uca.png\"");
            //this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void panelArbol_Paint(object sender, PaintEventArgs e)
        {
            treeDrawer.DibujarArbol(sender, e);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                //arbol.Insertar(valor);
                //treeDrawer.Redibujar();
                if (valor <= 0 || valor >= 100)
                {
                    MessageBox.Show("Error. Debe ingresar un valor entre 1 y 99");
                }
                else if (arbol.Contiene(valor))
                {
                    MessageBox.Show($"El valor {valor} ya ha sido ingresado");
                }
                else
                {
                    arbol.Insertar(valor);
                    treeDrawer.Redibujar();
                    txtValor.Text = "";
                }
            }
            else
            {

                MessageBox.Show("Ingrese un valor válido.");
            }
            /*if (txtValor.Text == "")
             {
                 MessageBox.Show("Debe ingresar un valor valido");
             }
            else
             {
                 valor = int.Parse(txtValor.Text);
                 if (valor <= 0 || valor >= 100)
                     MessageBox.Show("Error de ingreso. Solo recibe valores del 1 al 99");
             }*/
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
        //Evento para elegir el color de la raiz
        private void btnColorRaiz_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorRaiz = colorDialog.Color;
                    treeDrawer = new TreeDrawer(arbol, panelArbol, Color.Red, Color.Green, Color.Blue, Color.Yellow);
                    // treeDrawer = new TreeDrawer(arbol, panelDibujo, colorRaiz, colorNodosInternos, colorNodosTerminales);
                    treeDrawer.Redibujar();
                }
            }
        }
        //Evento para elegir el color de los nodos internos
        private void btnColorNodosInternos_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorNodosInternos = colorDialog.Color;
                    treeDrawer = new TreeDrawer(arbol, panelArbol, Color.Red, Color.Green, Color.Blue, Color.Yellow);
                   // treeDrawer = new TreeDrawer(arbol, panelDibujo, colorRaiz, colorNodosInternos, colorNodosTerminales);
                    treeDrawer.Redibujar();
                }
            }
        }
        //mentodo para elegir el color de los nodos terminales
        private void btnColorNodosTerminales_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorNodosTerminales = colorDialog.Color;
                    treeDrawer = new TreeDrawer(arbol, panelArbol, Color.Red, Color.Green, Color.Blue, Color.Yellow);
                   // treeDrawer = new TreeDrawer(arbol, panelDibujo, colorRaiz, colorNodosInternos, colorNodosTerminales);
                    treeDrawer.Redibujar();
                }
            }
        }
        //metodo para mostrar la suma del arbol
        private void btnMostrarSuma_Click(object sender, EventArgs e)
        {
            int suma = arbol.SumaElementos(arbol.Raiz);
            MessageBox.Show($"Suma de los elementos del árbol: {suma}");
        }
        //metodo para mostrar los multiplos 
        private void btnMostrarSumaMultiplos_Click(object sender, EventArgs e)
        {
            int suma2 = arbol.SumaMultiplos(arbol.Raiz, 2);
            int suma3 = arbol.SumaMultiplos(arbol.Raiz, 3);
            int suma5 = arbol.SumaMultiplos(arbol.Raiz, 5);
            MessageBox.Show($"Suma de múltiplos de 2: {suma2}\nSuma de múltiplos de 3: {suma3}\nSuma de múltiplos de 5: {suma5}");
        }
        //metodo para mostrar el maximo y minimo del arbol
        private void btnMostrarMaxMin_Click(object sender, EventArgs e)
        {
            try                                                          //try-catch se utiliza para manejar posibles errores  Si ocurre un error, se muestra un mensaje de error en lugar de que la aplicación falle.
            {
                int maximo = arbol.Maximo(arbol.Raiz);                  //al obtener los valores máximo y mínimo del árbol binario de búsqueda.
                int minimo = arbol.Minimo(arbol.Raiz);                  //Si ocurre un error, se muestra un mensaje de error en lugar de que la aplicación falle.
                MessageBox.Show($"Máximo: {maximo}\nMínimo: {minimo}");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //metodo para mostrar la altura del arbol
        private void btnAltura_Click(object sender, EventArgs e)
        {
            int altura = arbol.Altura(arbol.Raiz);
            MessageBox.Show($"Altura del árbol: {altura}");
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            /* List<int> elementos = new List<int>();
             arbol.InOrden(arbol.Raiz, valor => elementos.Add(valor));
             MessageBox.Show($"Recorrido InOrden: {string.Join(", ", elementos)}");*/
            recorridoActual = arbol.ObtenerRecorridoEnOrden();
            treeDrawer.IniciarRecorrido(recorridoActual);
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            /*List<int> elementos = new List<int>();
            arbol.PreOrden(arbol.Raiz, valor => elementos.Add(valor));
            MessageBox.Show($"Recorrido PreOrden: {string.Join(", ", elementos)}");*/
            /* recorridoActual = arbol.ObtenerRecorridoPreOrden();
             treeDrawer.IniciarRecorrido(recorridoActual);*/
            recorridoActual = arbol.ObtenerRecorridoPreOrden();
            treeDrawer.IniciarRecorrido(recorridoActual);
        }

        private void btnPosOrden_Click(object sender, EventArgs e)
        {
            /*List<int> elementos = new List<int>();
            arbol.PosOrden(arbol.Raiz, valor => elementos.Add(valor));
            MessageBox.Show($"Recorrido PosOrden: {string.Join(", ", elementos)}");*/
            recorridoActual = arbol.ObtenerRecorridoPostOrden();
            treeDrawer.IniciarRecorrido(recorridoActual);
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            treeDrawer.AvanzarRecorrido();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            treeDrawer.ReiniciarColores();
        }
    }
}
