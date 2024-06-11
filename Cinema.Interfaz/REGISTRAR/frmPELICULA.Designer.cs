namespace Cinema.Interfaz.REGISTRAR
{
    partial class frmPELICULA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Enviar = new Button();
            panel1 = new Panel();
            ID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Title = new TextBox();
            label3 = new Label();
            Category = new TextBox();
            panel2 = new Panel();
            Language = new TextBox();
            label4 = new Label();
            Year = new TextBox();
            label5 = new Label();
            panel3 = new Panel();
            Label_Titulo = new Label();
            Cantidad = new Label();
            Titulo = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            Titulo.SuspendLayout();
            SuspendLayout();
            // 
            // Enviar
            // 
            Enviar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Enviar.BackColor = Color.LimeGreen;
            Enviar.Cursor = Cursors.Hand;
            Enviar.FlatAppearance.BorderColor = Color.White;
            Enviar.FlatAppearance.BorderSize = 4;
            Enviar.FlatStyle = FlatStyle.Flat;
            Enviar.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Enviar.ForeColor = Color.White;
            Enviar.Location = new Point(351, 4);
            Enviar.Margin = new Padding(3, 2, 3, 2);
            Enviar.MaximumSize = new Size(400, 45);
            Enviar.MinimumSize = new Size(400, 45);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(400, 45);
            Enviar.TabIndex = 22;
            Enviar.Text = "GUARDAR";
            Enviar.UseVisualStyleBackColor = false;
            Enviar.Click += Enviar_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 35);
            panel1.TabIndex = 5;
            // 
            // ID
            // 
            ID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ID.Cursor = Cursors.IBeam;
            ID.Location = new Point(29, 42);
            ID.Margin = new Padding(3, 2, 3, 2);
            ID.MaxLength = 5;
            ID.Name = "ID";
            ID.RightToLeft = RightToLeft.No;
            ID.Size = new Size(1040, 23);
            ID.TabIndex = 16;
            ID.KeyPress += NUM_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 0, 0, 0);
            label1.Size = new Size(152, 19);
            label1.TabIndex = 17;
            label1.Text = "ID DE PELÍCULAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(26, 94);
            label2.Name = "label2";
            label2.Padding = new Padding(4, 0, 0, 0);
            label2.Size = new Size(71, 19);
            label2.TabIndex = 18;
            label2.Text = "TÍTULO";
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Title.Cursor = Cursors.IBeam;
            Title.Location = new Point(29, 115);
            Title.Margin = new Padding(3, 2, 3, 2);
            Title.Name = "Title";
            Title.RightToLeft = RightToLeft.No;
            Title.Size = new Size(1040, 23);
            Title.TabIndex = 19;
            Title.KeyPress += Char_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(26, 169);
            label3.Name = "label3";
            label3.Padding = new Padding(4, 0, 0, 0);
            label3.Size = new Size(242, 19);
            label3.TabIndex = 20;
            label3.Text = "CATEGORÍA DE LA PELÍCULA";
            // 
            // Category
            // 
            Category.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Category.Cursor = Cursors.IBeam;
            Category.Location = new Point(29, 189);
            Category.Margin = new Padding(3, 2, 3, 2);
            Category.Name = "Category";
            Category.RightToLeft = RightToLeft.No;
            Category.Size = new Size(1040, 23);
            Category.TabIndex = 21;
            Category.KeyPress += Char_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 30, 35);
            panel2.Controls.Add(Language);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(Year);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(Category);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(Title);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ID);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 99);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(26, 0, 26, 0);
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(1097, 396);
            panel2.TabIndex = 7;
            // 
            // Language
            // 
            Language.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Language.Cursor = Cursors.IBeam;
            Language.Location = new Point(29, 338);
            Language.Margin = new Padding(3, 2, 3, 2);
            Language.Name = "Language";
            Language.RightToLeft = RightToLeft.No;
            Language.Size = new Size(1040, 23);
            Language.TabIndex = 25;
            Language.KeyPress += Char_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(26, 317);
            label4.Name = "label4";
            label4.Padding = new Padding(4, 0, 0, 0);
            label4.Size = new Size(69, 19);
            label4.TabIndex = 24;
            label4.Text = "IDIOMA";
            // 
            // Year
            // 
            Year.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Year.Cursor = Cursors.IBeam;
            Year.Location = new Point(29, 263);
            Year.Margin = new Padding(3, 2, 3, 2);
            Year.MaxLength = 4;
            Year.Name = "Year";
            Year.RightToLeft = RightToLeft.No;
            Year.Size = new Size(1040, 23);
            Year.TabIndex = 23;
            Year.KeyPress += NUM_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(26, 243);
            label5.Name = "label5";
            label5.Padding = new Padding(4, 0, 0, 0);
            label5.Size = new Size(194, 19);
            label5.TabIndex = 22;
            label5.Text = "AÑO DE LANZAMIENTO";
            // 
            // panel3
            // 
            panel3.Controls.Add(Enviar);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 495);
            panel3.Name = "panel3";
            panel3.Size = new Size(1097, 54);
            panel3.TabIndex = 24;
            // 
            // Label_Titulo
            // 
            Label_Titulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Label_Titulo.AutoSize = true;
            Label_Titulo.Font = new Font("Arial", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Titulo.Location = new Point(170, 13);
            Label_Titulo.Name = "Label_Titulo";
            Label_Titulo.Size = new Size(457, 43);
            Label_Titulo.TabIndex = 0;
            Label_Titulo.Text = "REGISTRAR PELÍCULAS";
            Label_Titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // Cantidad
            // 
            Cantidad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Cantidad.AutoSize = true;
            Cantidad.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cantidad.Location = new Point(782, 46);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(227, 18);
            Cantidad.TabIndex = 1;
            Cantidad.Text = "Almacenamiento disponible: 20";
            // 
            // Titulo
            // 
            Titulo.BackColor = Color.Brown;
            Titulo.Controls.Add(Cantidad);
            Titulo.Controls.Add(Label_Titulo);
            Titulo.Dock = DockStyle.Top;
            Titulo.ForeColor = Color.LightSalmon;
            Titulo.Location = new Point(0, 35);
            Titulo.Margin = new Padding(3, 2, 3, 2);
            Titulo.MaximumSize = new Size(0, 64);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(1097, 64);
            Titulo.TabIndex = 6;
            // 
            // frmPELICULA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 30, 35);
            ClientSize = new Size(1097, 549);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(Titulo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPELICULA";
            Text = "CATEGORIA_PELICULA";
            SizeChanged += Form_SizeChanged;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button Enviar;
        private Panel panel1;
        private TextBox ID;
        private Label label1;
        private Label label2;
        private TextBox Title;
        private Label label3;
        private TextBox Category;
        private Panel panel2;
        private Panel panel3;
        private Label Label_Titulo;
        private Label Cantidad;
        private Panel Titulo;
        private TextBox Language;
        private Label label4;
        private TextBox Year;
        private Label label5;
    }
}