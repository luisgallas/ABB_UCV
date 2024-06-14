namespace ABB_UCV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView = new TreeView();
            txtValor = new TextBox();
            btnInsertar = new Button();
            btnMostrarSuma = new Button();
            btnMostrarSumaMultiplos = new Button();
            btnMostrarMaxMin = new Button();
            btnAltura = new Button();
            btnInOrden = new Button();
            btnPreOrden = new Button();
            btnPosOrden = new Button();
            btnColorRaiz = new Button();
            btnColorNodosInternos = new Button();
            btnColorNodosTerminales = new Button();
            panelDibujo = new Panel();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Location = new Point(778, 12);
            treeView.Name = "treeView";
            treeView.Size = new Size(10, 10);
            treeView.TabIndex = 0;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(135, 75);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 27);
            txtValor.TabIndex = 1;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(12, 73);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(94, 29);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnMostrarSuma
            // 
            btnMostrarSuma.Location = new Point(18, 361);
            btnMostrarSuma.Name = "btnMostrarSuma";
            btnMostrarSuma.Size = new Size(94, 29);
            btnMostrarSuma.TabIndex = 3;
            btnMostrarSuma.Text = "Suma";
            btnMostrarSuma.UseVisualStyleBackColor = true;
            btnMostrarSuma.Click += btnMostrarSuma_Click;
            // 
            // btnMostrarSumaMultiplos
            // 
            btnMostrarSumaMultiplos.Location = new Point(146, 361);
            btnMostrarSumaMultiplos.Name = "btnMostrarSumaMultiplos";
            btnMostrarSumaMultiplos.Size = new Size(94, 29);
            btnMostrarSumaMultiplos.TabIndex = 4;
            btnMostrarSumaMultiplos.Text = "Multiplos";
            btnMostrarSumaMultiplos.UseVisualStyleBackColor = true;
            btnMostrarSumaMultiplos.Click += btnMostrarSumaMultiplos_Click;
            // 
            // btnMostrarMaxMin
            // 
            btnMostrarMaxMin.Location = new Point(277, 364);
            btnMostrarMaxMin.Name = "btnMostrarMaxMin";
            btnMostrarMaxMin.Size = new Size(94, 29);
            btnMostrarMaxMin.TabIndex = 5;
            btnMostrarMaxMin.Text = "Max y Min";
            btnMostrarMaxMin.UseVisualStyleBackColor = true;
            btnMostrarMaxMin.Click += btnMostrarMaxMin_Click;
            // 
            // btnAltura
            // 
            btnAltura.Location = new Point(410, 364);
            btnAltura.Name = "btnAltura";
            btnAltura.Size = new Size(94, 29);
            btnAltura.TabIndex = 6;
            btnAltura.Text = "Altura";
            btnAltura.UseVisualStyleBackColor = true;
            btnAltura.Click += btnAltura_Click;
            // 
            // btnInOrden
            // 
            btnInOrden.Location = new Point(12, 227);
            btnInOrden.Name = "btnInOrden";
            btnInOrden.Size = new Size(94, 29);
            btnInOrden.TabIndex = 7;
            btnInOrden.Text = "InOrden";
            btnInOrden.UseVisualStyleBackColor = true;
            btnInOrden.Click += btnInOrden_Click;
            // 
            // btnPreOrden
            // 
            btnPreOrden.Location = new Point(12, 262);
            btnPreOrden.Name = "btnPreOrden";
            btnPreOrden.Size = new Size(94, 29);
            btnPreOrden.TabIndex = 8;
            btnPreOrden.Text = "PreOrden";
            btnPreOrden.UseVisualStyleBackColor = true;
            btnPreOrden.Click += btnPreOrden_Click;
            // 
            // btnPosOrden
            // 
            btnPosOrden.Location = new Point(12, 297);
            btnPosOrden.Name = "btnPosOrden";
            btnPosOrden.Size = new Size(94, 29);
            btnPosOrden.TabIndex = 9;
            btnPosOrden.Text = "PosOrden";
            btnPosOrden.UseVisualStyleBackColor = true;
            btnPosOrden.Click += btnPosOrden_Click;
            // 
            // btnColorRaiz
            // 
            btnColorRaiz.Location = new Point(12, 127);
            btnColorRaiz.Name = "btnColorRaiz";
            btnColorRaiz.Size = new Size(94, 29);
            btnColorRaiz.TabIndex = 10;
            btnColorRaiz.Text = "Color Raiz";
            btnColorRaiz.UseVisualStyleBackColor = true;
            btnColorRaiz.Click += btnColorRaiz_Click;
            // 
            // btnColorNodosInternos
            // 
            btnColorNodosInternos.Location = new Point(12, 162);
            btnColorNodosInternos.Name = "btnColorNodosInternos";
            btnColorNodosInternos.Size = new Size(120, 29);
            btnColorNodosInternos.TabIndex = 11;
            btnColorNodosInternos.Text = "Color Nodos in";
            btnColorNodosInternos.UseVisualStyleBackColor = true;
            btnColorNodosInternos.Click += btnColorNodosInternos_Click;
            // 
            // btnColorNodosTerminales
            // 
            btnColorNodosTerminales.Location = new Point(12, 192);
            btnColorNodosTerminales.Name = "btnColorNodosTerminales";
            btnColorNodosTerminales.Size = new Size(126, 29);
            btnColorNodosTerminales.TabIndex = 12;
            btnColorNodosTerminales.Text = "Color Nodo Ter";
            btnColorNodosTerminales.UseVisualStyleBackColor = true;
            btnColorNodosTerminales.Click += btnColorNodosTerminales_Click;
            // 
            // panelDibujo
            // 
            panelDibujo.Location = new Point(299, 12);
            panelDibujo.Name = "panelDibujo";
            panelDibujo.Size = new Size(489, 330);
            panelDibujo.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDibujo);
            Controls.Add(btnColorNodosTerminales);
            Controls.Add(btnColorNodosInternos);
            Controls.Add(btnColorRaiz);
            Controls.Add(btnPosOrden);
            Controls.Add(btnPreOrden);
            Controls.Add(btnInOrden);
            Controls.Add(btnAltura);
            Controls.Add(btnMostrarMaxMin);
            Controls.Add(btnMostrarSumaMultiplos);
            Controls.Add(btnMostrarSuma);
            Controls.Add(btnInsertar);
            Controls.Add(txtValor);
            Controls.Add(treeView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView;
        private TextBox txtValor;
        private Button btnInsertar;
        private Button btnMostrarSuma;
        private Button btnMostrarSumaMultiplos;
        private Button btnMostrarMaxMin;
        private Button btnAltura;
        private Button btnInOrden;
        private Button btnPreOrden;
        private Button btnPosOrden;
        private Button btnColorRaiz;
        private Button btnColorNodosInternos;
        private Button btnColorNodosTerminales;
        private Panel panelDibujo;
    }
}
