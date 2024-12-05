namespace Estructura_de_datos_AAU4
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lstValores = new ListBox();
            btnMostrar = new Button();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            txtValor = new TextBox();
            tabPage2 = new TabPage();
            lstResultados = new ListBox();
            label4 = new Label();
            label3 = new Label();
            txtPeso = new TextBox();
            txtDestino = new TextBox();
            txtOrigen = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNodo = new TextBox();
            btnDFS = new Button();
            btnAgregarArista = new Button();
            btnAgregarNodo = new Button();
            label5 = new Label();
            txtInicio = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(567, 316);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lstValores);
            tabPage1.Controls.Add(btnMostrar);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(btnEliminar);
            tabPage1.Controls.Add(btnInsertar);
            tabPage1.Controls.Add(txtValor);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(559, 283);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Arboles Binarios";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstValores
            // 
            lstValores.FormattingEnabled = true;
            lstValores.Location = new Point(234, 16);
            lstValores.Name = "lstValores";
            lstValores.Size = new Size(298, 204);
            lstValores.TabIndex = 5;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(16, 181);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(192, 29);
            btnMostrar.TabIndex = 4;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(16, 146);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(192, 29);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(16, 111);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(192, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(16, 76);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(192, 29);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 12F);
            txtValor.Location = new Point(16, 16);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(202, 34);
            txtValor.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtInicio);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(lstResultados);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtPeso);
            tabPage2.Controls.Add(txtDestino);
            tabPage2.Controls.Add(txtOrigen);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtNodo);
            tabPage2.Controls.Add(btnDFS);
            tabPage2.Controls.Add(btnAgregarArista);
            tabPage2.Controls.Add(btnAgregarNodo);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(559, 283);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Grafos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(309, 7);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(244, 264);
            lstResultados.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 127);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 13;
            label4.Text = "Peso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 91);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 12;
            label3.Text = "Destino";
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 12F);
            txtPeso.Location = new Point(90, 127);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(202, 34);
            txtPeso.TabIndex = 11;
            // 
            // txtDestino
            // 
            txtDestino.Font = new Font("Segoe UI", 12F);
            txtDestino.Location = new Point(90, 87);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(202, 34);
            txtDestino.TabIndex = 10;
            // 
            // txtOrigen
            // 
            txtOrigen.Font = new Font("Segoe UI", 12F);
            txtOrigen.Location = new Point(90, 46);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(202, 34);
            txtOrigen.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 52);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 8;
            label2.Text = "Origen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 16);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 7;
            label1.Text = "Nodo";
            // 
            // txtNodo
            // 
            txtNodo.Font = new Font("Segoe UI", 12F);
            txtNodo.Location = new Point(90, 6);
            txtNodo.Name = "txtNodo";
            txtNodo.Size = new Size(202, 34);
            txtNodo.TabIndex = 6;
            // 
            // btnDFS
            // 
            btnDFS.Location = new Point(167, 242);
            btnDFS.Name = "btnDFS";
            btnDFS.Size = new Size(125, 29);
            btnDFS.TabIndex = 3;
            btnDFS.Text = "Recorrido DFS";
            btnDFS.UseVisualStyleBackColor = true;
            btnDFS.Click += btnDFS_Click;
            // 
            // btnAgregarArista
            // 
            btnAgregarArista.Location = new Point(90, 202);
            btnAgregarArista.Name = "btnAgregarArista";
            btnAgregarArista.Size = new Size(202, 29);
            btnAgregarArista.TabIndex = 2;
            btnAgregarArista.Text = "Agregar arista";
            btnAgregarArista.UseVisualStyleBackColor = true;
            btnAgregarArista.Click += btnAgregarArista_Click;
            // 
            // btnAgregarNodo
            // 
            btnAgregarNodo.Location = new Point(90, 167);
            btnAgregarNodo.Name = "btnAgregarNodo";
            btnAgregarNodo.Size = new Size(202, 29);
            btnAgregarNodo.TabIndex = 1;
            btnAgregarNodo.Text = "Agregar nodo";
            btnAgregarNodo.UseVisualStyleBackColor = true;
            btnAgregarNodo.Click += btnAgregarNodo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 241);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 15;
            label5.Text = "Inicio";
            // 
            // txtInicio
            // 
            txtInicio.Font = new Font("Segoe UI", 12F);
            txtInicio.Location = new Point(90, 241);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(71, 34);
            txtInicio.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 340);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtValor;
        private ListBox lstValores;
        private Button btnMostrar;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnInsertar;
        private TextBox txtNodo;
        private Button btnDFS;
        private Button btnAgregarArista;
        private Button btnAgregarNodo;
        private Label label4;
        private Label label3;
        private TextBox txtPeso;
        private TextBox txtDestino;
        private TextBox txtOrigen;
        private Label label2;
        private Label label1;
        private ListBox lstResultados;
        private TextBox txtInicio;
        private Label label5;
    }
}
