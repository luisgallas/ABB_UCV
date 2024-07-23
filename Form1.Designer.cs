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
            menuStrip1 = new MenuStrip();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDelJuegoToolStripMenuItem = new ToolStripMenuItem();
            autorLuisFerreiraToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            reglaToolStripMenuItem = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();
            menuStrip1.SuspendLayout();
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
            txtValor.Location = new Point(106, 167);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(57, 27);
            txtValor.TabIndex = 1;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(6, 165);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(94, 29);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnMostrarSuma
            // 
            btnMostrarSuma.Location = new Point(6, 528);
            btnMostrarSuma.Name = "btnMostrarSuma";
            btnMostrarSuma.Size = new Size(94, 29);
            btnMostrarSuma.TabIndex = 3;
            btnMostrarSuma.Text = "Suma";
            btnMostrarSuma.UseVisualStyleBackColor = true;
            btnMostrarSuma.Click += btnMostrarSuma_Click;
            // 
            // btnMostrarSumaMultiplos
            // 
            btnMostrarSumaMultiplos.Location = new Point(120, 528);
            btnMostrarSumaMultiplos.Name = "btnMostrarSumaMultiplos";
            btnMostrarSumaMultiplos.Size = new Size(94, 29);
            btnMostrarSumaMultiplos.TabIndex = 4;
            btnMostrarSumaMultiplos.Text = "Multiplos";
            btnMostrarSumaMultiplos.UseVisualStyleBackColor = true;
            btnMostrarSumaMultiplos.Click += btnMostrarSumaMultiplos_Click;
            // 
            // btnMostrarMaxMin
            // 
            btnMostrarMaxMin.Location = new Point(238, 528);
            btnMostrarMaxMin.Name = "btnMostrarMaxMin";
            btnMostrarMaxMin.Size = new Size(94, 29);
            btnMostrarMaxMin.TabIndex = 5;
            btnMostrarMaxMin.Text = "Max y Min";
            btnMostrarMaxMin.UseVisualStyleBackColor = true;
            btnMostrarMaxMin.Click += btnMostrarMaxMin_Click;
            // 
            // btnAltura
            // 
            btnAltura.Location = new Point(353, 528);
            btnAltura.Name = "btnAltura";
            btnAltura.Size = new Size(94, 29);
            btnAltura.TabIndex = 6;
            btnAltura.Text = "Altura";
            btnAltura.UseVisualStyleBackColor = true;
            btnAltura.Click += btnAltura_Click;
            // 
            // btnInOrden
            // 
            btnInOrden.Location = new Point(6, 379);
            btnInOrden.Name = "btnInOrden";
            btnInOrden.Size = new Size(94, 29);
            btnInOrden.TabIndex = 7;
            btnInOrden.Text = "InOrden";
            btnInOrden.UseVisualStyleBackColor = true;
            btnInOrden.Click += btnInOrden_Click;
            // 
            // btnPreOrden
            // 
            btnPreOrden.Location = new Point(6, 427);
            btnPreOrden.Name = "btnPreOrden";
            btnPreOrden.Size = new Size(94, 29);
            btnPreOrden.TabIndex = 8;
            btnPreOrden.Text = "PreOrden";
            btnPreOrden.UseVisualStyleBackColor = true;
            btnPreOrden.Click += btnPreOrden_Click;
            // 
            // btnPosOrden
            // 
            btnPosOrden.Location = new Point(6, 476);
            btnPosOrden.Name = "btnPosOrden";
            btnPosOrden.Size = new Size(94, 29);
            btnPosOrden.TabIndex = 9;
            btnPosOrden.Text = "PosOrden";
            btnPosOrden.UseVisualStyleBackColor = true;
            btnPosOrden.Click += btnPosOrden_Click;
            // 
            // btnColorRaiz
            // 
            btnColorRaiz.Location = new Point(6, 200);
            btnColorRaiz.Name = "btnColorRaiz";
            btnColorRaiz.Size = new Size(94, 29);
            btnColorRaiz.TabIndex = 10;
            btnColorRaiz.Text = "Color Raiz";
            btnColorRaiz.UseVisualStyleBackColor = true;
            btnColorRaiz.Click += btnColorRaiz_Click;
            // 
            // btnColorNodosInternos
            // 
            btnColorNodosInternos.Location = new Point(6, 235);
            btnColorNodosInternos.Name = "btnColorNodosInternos";
            btnColorNodosInternos.Size = new Size(126, 63);
            btnColorNodosInternos.TabIndex = 11;
            btnColorNodosInternos.Text = "Color Nodos \r\nInternos";
            btnColorNodosInternos.TextAlign = ContentAlignment.TopLeft;
            btnColorNodosInternos.UseVisualStyleBackColor = true;
            btnColorNodosInternos.Click += btnColorNodosInternos_Click;
            // 
            // btnColorNodosTerminales
            // 
            btnColorNodosTerminales.Location = new Point(6, 304);
            btnColorNodosTerminales.Name = "btnColorNodosTerminales";
            btnColorNodosTerminales.Size = new Size(126, 58);
            btnColorNodosTerminales.TabIndex = 12;
            btnColorNodosTerminales.Text = "Color Nodos\r\nTerminal";
            btnColorNodosTerminales.TextAlign = ContentAlignment.TopLeft;
            btnColorNodosTerminales.UseVisualStyleBackColor = true;
            btnColorNodosTerminales.Click += btnColorNodosTerminales_Click;
            // 
            // panelDibujo
            // 
            panelDibujo.Location = new Point(211, 165);
            panelDibujo.Name = "panelDibujo";
            panelDibujo.Size = new Size(650, 327);
            panelDibujo.TabIndex = 13;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ayudaToolStripMenuItem, acercaDelJuegoToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(873, 28);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reglaToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDelJuegoToolStripMenuItem
            // 
            acercaDelJuegoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { autorLuisFerreiraToolStripMenuItem });
            acercaDelJuegoToolStripMenuItem.Name = "acercaDelJuegoToolStripMenuItem";
            acercaDelJuegoToolStripMenuItem.Size = new Size(135, 24);
            acercaDelJuegoToolStripMenuItem.Text = "Acerca del juego";
            // 
            // autorLuisFerreiraToolStripMenuItem
            // 
            autorLuisFerreiraToolStripMenuItem.Name = "autorLuisFerreiraToolStripMenuItem";
            autorLuisFerreiraToolStripMenuItem.Size = new Size(215, 26);
            autorLuisFerreiraToolStripMenuItem.Text = "Autor: Luis Ferreira";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 48);
            label1.Name = "label1";
            label1.Size = new Size(169, 27);
            label1.TabIndex = 15;
            label1.Text = "Bienvenidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("HP Simplified Hans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(255, 92);
            label2.Name = "label2";
            label2.Size = new Size(390, 23);
            label2.TabIndex = 16;
            label2.Text = "Simulador de Arbol Binario de Busqueda";
            // 
            // reglaToolStripMenuItem
            // 
            reglaToolStripMenuItem.Name = "reglaToolStripMenuItem";
            reglaToolStripMenuItem.Size = new Size(224, 26);
            reglaToolStripMenuItem.Text = "Reglas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 569);
            Controls.Add(label2);
            Controls.Add(label1);
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDelJuegoToolStripMenuItem;
        private ToolStripMenuItem autorLuisFerreiraToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem reglaToolStripMenuItem;
        private FontDialog fontDialog1;
    }
}
