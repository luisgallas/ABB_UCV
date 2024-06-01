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
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Location = new Point(307, 57);
            treeView.Name = "treeView";
            treeView.Size = new Size(481, 269);
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
            btnInsertar.Location = new Point(18, 73);
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
            // 
            // btnMostrarSumaMultiplos
            // 
            btnMostrarSumaMultiplos.Location = new Point(146, 361);
            btnMostrarSumaMultiplos.Name = "btnMostrarSumaMultiplos";
            btnMostrarSumaMultiplos.Size = new Size(94, 29);
            btnMostrarSumaMultiplos.TabIndex = 4;
            btnMostrarSumaMultiplos.Text = "Multiplos";
            btnMostrarSumaMultiplos.UseVisualStyleBackColor = true;
            // 
            // btnMostrarMaxMin
            // 
            btnMostrarMaxMin.Location = new Point(277, 364);
            btnMostrarMaxMin.Name = "btnMostrarMaxMin";
            btnMostrarMaxMin.Size = new Size(94, 29);
            btnMostrarMaxMin.TabIndex = 5;
            btnMostrarMaxMin.Text = "Max y Min";
            btnMostrarMaxMin.UseVisualStyleBackColor = true;
            // 
            // btnAltura
            // 
            btnAltura.Location = new Point(410, 364);
            btnAltura.Name = "btnAltura";
            btnAltura.Size = new Size(94, 29);
            btnAltura.TabIndex = 6;
            btnAltura.Text = "Altura";
            btnAltura.UseVisualStyleBackColor = true;
            // 
            // btnInOrden
            // 
            btnInOrden.Location = new Point(12, 185);
            btnInOrden.Name = "btnInOrden";
            btnInOrden.Size = new Size(94, 29);
            btnInOrden.TabIndex = 7;
            btnInOrden.Text = "InOrden";
            btnInOrden.UseVisualStyleBackColor = true;
            // 
            // btnPreOrden
            // 
            btnPreOrden.Location = new Point(12, 242);
            btnPreOrden.Name = "btnPreOrden";
            btnPreOrden.Size = new Size(94, 29);
            btnPreOrden.TabIndex = 8;
            btnPreOrden.Text = "PreOrden";
            btnPreOrden.UseVisualStyleBackColor = true;
            // 
            // btnPosOrden
            // 
            btnPosOrden.Location = new Point(12, 297);
            btnPosOrden.Name = "btnPosOrden";
            btnPosOrden.Size = new Size(94, 29);
            btnPosOrden.TabIndex = 9;
            btnPosOrden.Text = "PosOrden";
            btnPosOrden.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
