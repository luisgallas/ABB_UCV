using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace ABB_UCV
{
    internal class TreeDrawer
    {
        
        
        private ArbolBinario arbol;
        private Panel panel;
        private Color colorRaiz;
        private Color colorNodosInternos;
        private Color colorNodosTerminales;
        private Color colorRecorrido;
        private List<Nodo> recorridoActual;
        private int indiceRecorrido;

        public TreeDrawer(ArbolBinario arbol, Panel panel, Color colorRaiz, Color colorNodosInternos, Color colorNodosTerminales, Color colorRecorrido)
        {
            this.arbol = arbol;
            this.panel = panel;
            this.colorRaiz = colorRaiz;
            this.colorNodosInternos = colorNodosInternos;
            this.colorNodosTerminales = colorNodosTerminales;
            this.colorRecorrido = colorRecorrido;
            this.panel.Paint += new PaintEventHandler(DibujarArbol);
        }

        public void DibujarArbol(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(panel.BackColor);
            if (arbol.Raiz != null)
            {
                DibujarNodo(e.Graphics, arbol.Raiz, panel.Width / 2, 20, panel.Width / 4);
            }
        }

        private void DibujarNodo(Graphics graphics, Nodo nodo, int x, int y, int xOffset)
        {
            if (nodo == null) return;

            // Determinar el color del nodo
            Color colorNodo = colorNodosInternos;
            if (nodo == arbol.Raiz)
            {
                colorNodo = colorRaiz;
            }
            else if (nodo.Izquierdo == null && nodo.Derecho == null)
            {
                colorNodo = colorNodosTerminales;
            }

            // Verificar si el nodo está en el recorrido actual
            if (recorridoActual != null && recorridoActual.Contains(nodo) && recorridoActual.IndexOf(nodo) <= indiceRecorrido)
            {
                colorNodo = colorRecorrido;
            }

            // Dibujar la conexión al nodo izquierdo
            if (nodo.Izquierdo != null)
            {
                graphics.DrawLine(Pens.Black, x, y, x - xOffset, y + 40);
                DibujarNodo(graphics, nodo.Izquierdo, x - xOffset, y + 40, xOffset / 2);
            }

            // Dibujar la conexión al nodo derecho
            if (nodo.Derecho != null)
            {
                graphics.DrawLine(Pens.Black, x, y, x + xOffset, y + 40);
                DibujarNodo(graphics, nodo.Derecho, x + xOffset, y + 40, xOffset / 2);
            }

            // Dibujar el nodo
            Rectangle rect = new Rectangle(x - 15, y - 15, 30, 30);
            graphics.FillEllipse(new SolidBrush(colorNodo), rect);
            graphics.DrawEllipse(Pens.Black, rect);
            graphics.DrawString(nodo.Valor.ToString(), new Font("Arial", 12), Brushes.White, x - 10, y - 10);
        }

        public void IniciarRecorrido(List<Nodo> recorrido)
        {
            recorridoActual = recorrido;
            indiceRecorrido = -1; // Inicia antes del primer nodo
            panel.Invalidate();
        }

        public void AvanzarRecorrido()
        {
            if (recorridoActual != null && indiceRecorrido < recorridoActual.Count - 1)
            {
                indiceRecorrido++;
                panel.Invalidate();
            }
        }

        public void ReiniciarColores()
        {
            recorridoActual = null;
            indiceRecorrido = -1;
            panel.Invalidate();
        }
        public void Redibujar()
        {
            panel.Invalidate();
        }
    }
    
}

