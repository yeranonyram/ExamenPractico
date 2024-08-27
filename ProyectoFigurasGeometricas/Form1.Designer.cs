namespace ProyectoFigurasGeometricas
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            btnCrearTriangulo = new Button();
            txtAlturaTriangulo = new TextBox();
            txtBaseTriangulo = new TextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            btnCrearRectangulo = new Button();
            txtAltoRectangulo = new TextBox();
            txtAnchoRectangulo = new TextBox();
            groupBox3 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            btnCrearParalelogramo = new Button();
            txtAlturaParalelogramo = new TextBox();
            txtBaseParalelogramo = new TextBox();
            btnMostrarPila = new Button();
            lblPila = new Label();
            button1 = new Button();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCrearTriangulo);
            groupBox1.Controls.Add(txtAlturaTriangulo);
            groupBox1.Controls.Add(txtBaseTriangulo);
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(55, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 209);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Triangulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 124);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 4;
            label2.Text = "Altura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 59);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 3;
            label1.Text = "Base";
            label1.Click += label1_Click;
            // 
            // btnCrearTriangulo
            // 
            btnCrearTriangulo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearTriangulo.ForeColor = SystemColors.ActiveCaptionText;
            btnCrearTriangulo.Location = new Point(58, 165);
            btnCrearTriangulo.Name = "btnCrearTriangulo";
            btnCrearTriangulo.Size = new Size(129, 35);
            btnCrearTriangulo.TabIndex = 2;
            btnCrearTriangulo.Text = "Crear triangulo";
            btnCrearTriangulo.UseVisualStyleBackColor = true;
            btnCrearTriangulo.Click += btnCrearTriangulo_Click;
            // 
            // txtAlturaTriangulo
            // 
            txtAlturaTriangulo.Location = new Point(117, 116);
            txtAlturaTriangulo.Name = "txtAlturaTriangulo";
            txtAlturaTriangulo.Size = new Size(100, 33);
            txtAlturaTriangulo.TabIndex = 1;
            // 
            // txtBaseTriangulo
            // 
            txtBaseTriangulo.Location = new Point(117, 56);
            txtBaseTriangulo.Name = "txtBaseTriangulo";
            txtBaseTriangulo.Size = new Size(100, 33);
            txtBaseTriangulo.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnCrearRectangulo);
            groupBox2.Controls.Add(txtAltoRectangulo);
            groupBox2.Controls.Add(txtAnchoRectangulo);
            groupBox2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(359, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(229, 209);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Regtangulo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 124);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 5;
            label4.Text = "Altura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 64);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 4;
            label3.Text = "Base";
            // 
            // btnCrearRectangulo
            // 
            btnCrearRectangulo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearRectangulo.ForeColor = SystemColors.ActiveCaptionText;
            btnCrearRectangulo.Location = new Point(35, 165);
            btnCrearRectangulo.Name = "btnCrearRectangulo";
            btnCrearRectangulo.Size = new Size(158, 34);
            btnCrearRectangulo.TabIndex = 2;
            btnCrearRectangulo.Text = "Crear rectangulo";
            btnCrearRectangulo.UseVisualStyleBackColor = true;
            btnCrearRectangulo.Click += btnCrearRectangulo_Click;
            // 
            // txtAltoRectangulo
            // 
            txtAltoRectangulo.Location = new Point(111, 116);
            txtAltoRectangulo.Name = "txtAltoRectangulo";
            txtAltoRectangulo.Size = new Size(100, 33);
            txtAltoRectangulo.TabIndex = 1;
            // 
            // txtAnchoRectangulo
            // 
            txtAnchoRectangulo.Location = new Point(111, 61);
            txtAnchoRectangulo.Name = "txtAnchoRectangulo";
            txtAnchoRectangulo.Size = new Size(100, 33);
            txtAnchoRectangulo.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(btnCrearParalelogramo);
            groupBox3.Controls.Add(txtAlturaParalelogramo);
            groupBox3.Controls.Add(txtBaseParalelogramo);
            groupBox3.FlatStyle = FlatStyle.Popup;
            groupBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(650, 77);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(223, 209);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Paralelogramo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 124);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 6;
            label6.Text = "Altura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 64);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 5;
            label5.Text = "Base";
            // 
            // btnCrearParalelogramo
            // 
            btnCrearParalelogramo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearParalelogramo.ForeColor = SystemColors.ActiveCaptionText;
            btnCrearParalelogramo.Location = new Point(59, 165);
            btnCrearParalelogramo.Name = "btnCrearParalelogramo";
            btnCrearParalelogramo.Size = new Size(136, 35);
            btnCrearParalelogramo.TabIndex = 2;
            btnCrearParalelogramo.Text = "Crear paralelogramo";
            btnCrearParalelogramo.UseVisualStyleBackColor = true;
            btnCrearParalelogramo.Click += btnCrearParalelogramo_Click;
            // 
            // txtAlturaParalelogramo
            // 
            txtAlturaParalelogramo.Location = new Point(104, 116);
            txtAlturaParalelogramo.Name = "txtAlturaParalelogramo";
            txtAlturaParalelogramo.Size = new Size(100, 33);
            txtAlturaParalelogramo.TabIndex = 1;
            // 
            // txtBaseParalelogramo
            // 
            txtBaseParalelogramo.Location = new Point(104, 56);
            txtBaseParalelogramo.Name = "txtBaseParalelogramo";
            txtBaseParalelogramo.Size = new Size(100, 33);
            txtBaseParalelogramo.TabIndex = 0;
            // 
            // btnMostrarPila
            // 
            btnMostrarPila.Location = new Point(55, 306);
            btnMostrarPila.Name = "btnMostrarPila";
            btnMostrarPila.Size = new Size(110, 23);
            btnMostrarPila.TabIndex = 3;
            btnMostrarPila.Text = "Mostrar Pila";
            btnMostrarPila.UseVisualStyleBackColor = true;
            btnMostrarPila.Click += btnMostrarPila_Click;
            // 
            // lblPila
            // 
            lblPila.AutoSize = true;
            lblPila.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPila.ForeColor = SystemColors.Control;
            lblPila.Location = new Point(198, 302);
            lblPila.Name = "lblPila";
            lblPila.Size = new Size(0, 25);
            lblPila.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(780, 395);
            button1.Name = "button1";
            button1.Size = new Size(93, 29);
            button1.TabIndex = 5;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(335, 19);
            label7.Name = "label7";
            label7.Size = new Size(235, 32);
            label7.TabIndex = 6;
            label7.Text = "Figuras Geometricas";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(922, 450);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(lblPila);
            Controls.Add(btnMostrarPila);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Figuras Geometricas";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCrearTriangulo;
        private TextBox txtAlturaTriangulo;
        private TextBox txtBaseTriangulo;
        private GroupBox groupBox2;
        private Button btnCrearRectangulo;
        private TextBox txtAltoRectangulo;
        private TextBox txtAnchoRectangulo;
        private GroupBox groupBox3;
        private Button btnCrearParalelogramo;
        private TextBox txtAlturaParalelogramo;
        private TextBox txtBaseParalelogramo;
        private Button btnMostrarPila;
        private Label lblPila;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label7;
    }
}
