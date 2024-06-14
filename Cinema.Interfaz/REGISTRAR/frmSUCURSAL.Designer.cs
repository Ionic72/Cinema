namespace Cinema.Interfaz.REGISTRAR
{
    partial class frmSUCURSAL
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
            Nombre = new TextBox();
            label3 = new Label();
            Encargado = new TextBox();
            panel2 = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            Activo = new ComboBox();
            label4 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            Telefono = new TextBox();
            Direccion = new TextBox();
            label5 = new Label();
            panel3 = new Panel();
            Label_Titulo = new Label();
            Cantidad = new Label();
            Titulo = new Panel();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
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
            label1.Size = new Size(175, 19);
            label1.TabIndex = 17;
            label1.Text = "ID DE LA SUCURSAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(26, 94);
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
            Nombre.Location = new Point(29, 115);
            Nombre.Margin = new Padding(3, 2, 3, 2);
            Nombre.MaxLength = 125;
            Nombre.Name = "Nombre";
            Nombre.RightToLeft = RightToLeft.No;
            Nombre.Size = new Size(1040, 23);
            Nombre.TabIndex = 19;
            Nombre.KeyPress += Char_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(26, 169);
            label3.Name = "label3";
            label3.Padding = new Padding(4, 0, 0, 0);
            label3.Size = new Size(175, 19);
            label3.TabIndex = 20;
            label3.Text = "ID DEL ENCARGADO";
            // 
            // Encargado
            // 
            Encargado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Encargado.Cursor = Cursors.IBeam;
            Encargado.Location = new Point(29, 189);
            Encargado.Margin = new Padding(3, 2, 3, 2);
            Encargado.MaxLength = 5;
            Encargado.Name = "Encargado";
            Encargado.RightToLeft = RightToLeft.No;
            Encargado.Size = new Size(1040, 23);
            Encargado.TabIndex = 21;
            Encargado.KeyPress += NUM_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 30, 35);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(Direccion);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(Encargado);
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
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(1097, 396);
            panel2.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(29, 291);
            panel4.Name = "panel4";
            panel4.Size = new Size(1039, 68);
            panel4.TabIndex = 27;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel7.Controls.Add(Activo);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(520, 0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(25, 0, 0, 0);
            panel7.Size = new Size(519, 68);
            panel7.TabIndex = 2;
            // 
            // Activo
            // 
            Activo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Activo.DropDownStyle = ComboBoxStyle.DropDownList;
            Activo.FormattingEnabled = true;
            Activo.Location = new Point(28, 34);
            Activo.Name = "Activo";
            Activo.Size = new Size(491, 23);
            Activo.TabIndex = 30;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(28, 12);
            label4.Name = "label4";
            label4.Padding = new Padding(4, 0, 0, 0);
            label4.Size = new Size(73, 19);
            label4.TabIndex = 29;
            label4.Text = "ACTIVO";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(Telefono);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 0, 25, 0);
            panel5.Size = new Size(520, 68);
            panel5.TabIndex = 1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(0, 12);
            label7.Name = "label7";
            label7.Padding = new Padding(4, 0, 0, 0);
            label7.Size = new Size(101, 19);
            label7.TabIndex = 29;
            label7.Text = "TELÉFONO";
            // 
            // Telefono
            // 
            Telefono.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Telefono.Cursor = Cursors.IBeam;
            Telefono.Location = new Point(0, 34);
            Telefono.Margin = new Padding(3, 2, 3, 2);
            Telefono.MaxLength = 8;
            Telefono.Name = "Telefono";
            Telefono.RightToLeft = RightToLeft.No;
            Telefono.Size = new Size(492, 23);
            Telefono.TabIndex = 28;
            // 
            // Direccion
            // 
            Direccion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Direccion.Cursor = Cursors.IBeam;
            Direccion.Location = new Point(29, 263);
            Direccion.Margin = new Padding(3, 2, 3, 2);
            Direccion.MaxLength = 150;
            Direccion.Name = "Direccion";
            Direccion.RightToLeft = RightToLeft.No;
            Direccion.Size = new Size(1040, 23);
            Direccion.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(26, 243);
            label5.Name = "label5";
            label5.Padding = new Padding(4, 0, 0, 0);
            label5.Size = new Size(104, 19);
            label5.TabIndex = 22;
            label5.Text = "DIRECCIÓN";
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
            Label_Titulo.Size = new Size(454, 43);
            Label_Titulo.TabIndex = 0;
            Label_Titulo.Text = "REGISTRAR SUCURSAL";
            Label_Titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // Cantidad
            // 
            Cantidad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Cantidad.AutoSize = true;
            Cantidad.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cantidad.Location = new Point(782, 46);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(218, 18);
            Cantidad.TabIndex = 1;
            Cantidad.Text = "Almacenamiento disponible: 5";
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
            // frmSUCURSAL
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
            Name = "frmSUCURSAL";
            Text = "CATEGORIA_PELICULA";
            SizeChanged += Form_SizeChanged;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private TextBox Nombre;
        private Label label3;
        private TextBox Encargado;
        private Panel panel2;
        private Panel panel3;
        private Label Label_Titulo;
        private Label Cantidad;
        private Panel Titulo;
        private TextBox Direccion;
        private Label label5;
        private Panel panel4;
        private Panel panel5;
        private Label label7;
        private TextBox Telefono;
        private Panel panel7;
        private ComboBox Activo;
        private Label label4;
    }
}