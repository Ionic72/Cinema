namespace Cinema.Interfaz.REGISTRAR
{
    partial class frmCATEGORIA_PELICULA
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
            panel1 = new Panel();
            panel3 = new Panel();
            Enviar = new Button();
            Titulo = new Panel();
            Cantidad = new Label();
            Label_Titulo = new Label();
            ID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Nombre = new TextBox();
            label3 = new Label();
            Descripcion = new TextBox();
            panel2 = new Panel();
            panel3.SuspendLayout();
            Titulo.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // panel3
            // 
            panel3.Controls.Add(Enviar);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 495);
            panel3.Name = "panel3";
            panel3.Size = new Size(1097, 54);
            panel3.TabIndex = 24;
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
            // Label_Titulo
            // 
            Label_Titulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Label_Titulo.AutoSize = true;
            Label_Titulo.Font = new Font("Arial", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Titulo.Location = new Point(170, 13);
            Label_Titulo.Name = "Label_Titulo";
            Label_Titulo.Size = new Size(724, 43);
            Label_Titulo.TabIndex = 0;
            Label_Titulo.Text = "REGISTRAR CATEGORÍA DE PELICULA";
            // 
            // ID
            // 
            ID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ID.Cursor = Cursors.IBeam;
            ID.Location = new Point(26, 88);
            ID.Margin = new Padding(3, 2, 3, 2);
            ID.MaxLength = 5;
            ID.Name = "ID";
            ID.Size = new Size(1040, 23);
            ID.TabIndex = 16;
            ID.KeyPress += NUM_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(26, 68);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 0, 0, 0);
            label1.Size = new Size(178, 19);
            label1.TabIndex = 17;
            label1.Text = "ID DE LA CATEGORÍA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(26, 164);
            label2.Name = "label2";
            label2.Padding = new Padding(4, 0, 0, 0);
            label2.Size = new Size(85, 19);
            label2.TabIndex = 18;
            label2.Text = "NOMBRE";
            // 
            // Nombre
            // 
            Nombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Nombre.Cursor = Cursors.IBeam;
            Nombre.Location = new Point(26, 184);
            Nombre.Margin = new Padding(3, 2, 3, 2);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(1040, 23);
            Nombre.TabIndex = 19;
            Nombre.KeyPress += Char_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(26, 260);
            label3.Name = "label3";
            label3.Padding = new Padding(4, 0, 0, 0);
            label3.Size = new Size(126, 19);
            label3.TabIndex = 20;
            label3.Text = "DESCRIPCIÓN";
            // 
            // Descripcion
            // 
            Descripcion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Descripcion.Cursor = Cursors.IBeam;
            Descripcion.Location = new Point(26, 281);
            Descripcion.Margin = new Padding(3, 2, 3, 2);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(1040, 23);
            Descripcion.TabIndex = 21;
            Descripcion.KeyPress += Char_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 30, 35);
            panel2.Controls.Add(Descripcion);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(Nombre);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ID);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 99);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(26, 0, 26, 0);
            panel2.Size = new Size(1097, 396);
            panel2.TabIndex = 7;
            // 
            // frmCATEGORIA_PELICULA
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
            Name = "frmCATEGORIA_PELICULA";
            Text = "CATEGORIA_PELICULA";
            SizeChanged += Form_SizeChanged;
            panel3.ResumeLayout(false);
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel Titulo;
        private TextBox ID;
        private Label label1;
        private Label label2;
        private TextBox Nombre;
        private Label label3;
        private TextBox Descripcion;
        private Panel panel2;
        private Button Enviar;
        private Label Label_Titulo;
        private Label Cantidad;
    }
}