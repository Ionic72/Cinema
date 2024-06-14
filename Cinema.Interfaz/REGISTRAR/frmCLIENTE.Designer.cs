namespace Cinema.Interfaz.REGISTRAR
{
    partial class frmCLIENTE
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
            panel2 = new Panel();
            panel14 = new Panel();
            label8 = new Label();
            Activo = new ComboBox();
            panel11 = new Panel();
            panel12 = new Panel();
            F_Registro = new DateTimePicker();
            label6 = new Label();
            panel13 = new Panel();
            F_Nacimiento = new DateTimePicker();
            label7 = new Label();
            panel7 = new Panel();
            panel10 = new Panel();
            label5 = new Label();
            S_Apellido = new TextBox();
            panel8 = new Panel();
            label4 = new Label();
            P_Apellido = new TextBox();
            panel9 = new Panel();
            label3 = new Label();
            Nombre = new TextBox();
            panel4 = new Panel();
            panel6 = new Panel();
            label2 = new Label();
            Cedula = new TextBox();
            panel5 = new Panel();
            label1 = new Label();
            ID = new TextBox();
            panel3 = new Panel();
            Label_Titulo = new Label();
            Cantidad = new Label();
            Titulo = new Panel();
            panel2.SuspendLayout();
            panel14.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 30, 35);
            panel2.Controls.Add(panel14);
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 99);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 0, 20, 0);
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(1097, 396);
            panel2.TabIndex = 7;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel14.Controls.Add(label8);
            panel14.Controls.Add(Activo);
            panel14.Location = new Point(20, 300);
            panel14.Name = "panel14";
            panel14.Padding = new Padding(150, 0, 150, 0);
            panel14.Size = new Size(1057, 66);
            panel14.TabIndex = 29;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(153, 15);
            label8.Name = "label8";
            label8.Padding = new Padding(4, 0, 0, 0);
            label8.Size = new Size(73, 19);
            label8.TabIndex = 31;
            label8.Text = "ACTIVO";
            // 
            // Activo
            // 
            Activo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Activo.DropDownStyle = ComboBoxStyle.DropDownList;
            Activo.FormattingEnabled = true;
            Activo.Location = new Point(153, 37);
            Activo.Name = "Activo";
            Activo.Size = new Size(751, 23);
            Activo.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(panel13);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(20, 200);
            panel11.Name = "panel11";
            panel11.Size = new Size(1057, 100);
            panel11.TabIndex = 28;
            // 
            // panel12
            // 
            panel12.Controls.Add(F_Registro);
            panel12.Controls.Add(label6);
            panel12.Dock = DockStyle.Right;
            panel12.Location = new Point(535, 0);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(25, 0, 0, 0);
            panel12.Size = new Size(522, 100);
            panel12.TabIndex = 1;
            // 
            // F_Registro
            // 
            F_Registro.Location = new Point(28, 55);
            F_Registro.Name = "F_Registro";
            F_Registro.Size = new Size(494, 23);
            F_Registro.TabIndex = 31;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(24, 37);
            label6.Name = "label6";
            label6.Padding = new Padding(4, 0, 0, 0);
            label6.Size = new Size(183, 19);
            label6.TabIndex = 30;
            label6.Text = "FECHA DE REGISTRO";
            // 
            // panel13
            // 
            panel13.Controls.Add(F_Nacimiento);
            panel13.Controls.Add(label7);
            panel13.Dock = DockStyle.Left;
            panel13.Location = new Point(0, 0);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(0, 0, 25, 0);
            panel13.Size = new Size(522, 100);
            panel13.TabIndex = 0;
            // 
            // F_Nacimiento
            // 
            F_Nacimiento.Location = new Point(-1, 55);
            F_Nacimiento.Name = "F_Nacimiento";
            F_Nacimiento.Size = new Size(495, 23);
            F_Nacimiento.TabIndex = 29;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(3, 37);
            label7.Name = "label7";
            label7.Padding = new Padding(4, 0, 0, 0);
            label7.Size = new Size(200, 19);
            label7.TabIndex = 29;
            label7.Text = "FECHA DE NACIMIENTO";
            // 
            // panel7
            // 
            panel7.Controls.Add(panel10);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel9);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(20, 100);
            panel7.Name = "panel7";
            panel7.Size = new Size(1057, 100);
            panel7.TabIndex = 27;
            // 
            // panel10
            // 
            panel10.Controls.Add(label5);
            panel10.Controls.Add(S_Apellido);
            panel10.Dock = DockStyle.Right;
            panel10.Location = new Point(705, 0);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(25, 0, 0, 0);
            panel10.Size = new Size(352, 100);
            panel10.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(28, 37);
            label5.Name = "label5";
            label5.Padding = new Padding(4, 0, 0, 0);
            label5.Size = new Size(179, 19);
            label5.TabIndex = 32;
            label5.Text = "SEGUNDO APELLIDO";
            // 
            // S_Apellido
            // 
            S_Apellido.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            S_Apellido.Cursor = Cursors.IBeam;
            S_Apellido.Location = new Point(28, 58);
            S_Apellido.Margin = new Padding(3, 2, 3, 2);
            S_Apellido.Name = "S_Apellido";
            S_Apellido.RightToLeft = RightToLeft.No;
            S_Apellido.Size = new Size(321, 23);
            S_Apellido.TabIndex = 31;
            S_Apellido.KeyPress += Char_KeyPress;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel8.Controls.Add(label4);
            panel8.Controls.Add(P_Apellido);
            panel8.Location = new Point(350, 0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(25, 0, 25, 0);
            panel8.Size = new Size(352, 100);
            panel8.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(28, 37);
            label4.Name = "label4";
            label4.Padding = new Padding(4, 0, 0, 0);
            label4.Size = new Size(160, 19);
            label4.TabIndex = 32;
            label4.Text = "PRIMER APELLIDO";
            // 
            // P_Apellido
            // 
            P_Apellido.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            P_Apellido.Cursor = Cursors.IBeam;
            P_Apellido.Location = new Point(28, 58);
            P_Apellido.Margin = new Padding(3, 2, 3, 2);
            P_Apellido.Name = "P_Apellido";
            P_Apellido.RightToLeft = RightToLeft.No;
            P_Apellido.Size = new Size(296, 23);
            P_Apellido.TabIndex = 29;
            P_Apellido.KeyPress += Char_KeyPress;
            // 
            // panel9
            // 
            panel9.Controls.Add(label3);
            panel9.Controls.Add(Nombre);
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(0, 0, 25, 0);
            panel9.Size = new Size(352, 100);
            panel9.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(3, 37);
            label3.Name = "label3";
            label3.Padding = new Padding(4, 0, 0, 0);
            label3.Size = new Size(85, 19);
            label3.TabIndex = 31;
            label3.Text = "NOMBRE";
            // 
            // Nombre
            // 
            Nombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Nombre.Cursor = Cursors.IBeam;
            Nombre.Location = new Point(0, 58);
            Nombre.Margin = new Padding(3, 2, 3, 2);
            Nombre.Name = "Nombre";
            Nombre.RightToLeft = RightToLeft.No;
            Nombre.Size = new Size(324, 23);
            Nombre.TabIndex = 31;
            Nombre.KeyPress += Char_KeyPress;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(20, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1057, 100);
            panel4.TabIndex = 26;
            // 
            // panel6
            // 
            panel6.Controls.Add(label2);
            panel6.Controls.Add(Cedula);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(535, 0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(25, 0, 0, 0);
            panel6.Size = new Size(522, 100);
            panel6.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(24, 37);
            label2.Name = "label2";
            label2.Padding = new Padding(4, 0, 0, 0);
            label2.Size = new Size(143, 19);
            label2.TabIndex = 30;
            label2.Text = "IDENTIFICACIÓN";
            // 
            // Cedula
            // 
            Cedula.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Cedula.Cursor = Cursors.IBeam;
            Cedula.Location = new Point(28, 58);
            Cedula.Margin = new Padding(3, 2, 3, 2);
            Cedula.MaxLength = 9;
            Cedula.Name = "Cedula";
            Cedula.RightToLeft = RightToLeft.No;
            Cedula.Size = new Size(491, 23);
            Cedula.TabIndex = 29;
            Cedula.KeyPress += NUM_KeyPress;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(ID);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 0, 25, 0);
            panel5.Size = new Size(522, 100);
            panel5.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 37);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 0, 0, 0);
            label1.Size = new Size(140, 19);
            label1.TabIndex = 29;
            label1.Text = "ID DEL CLIENTE";
            // 
            // ID
            // 
            ID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ID.Cursor = Cursors.IBeam;
            ID.Location = new Point(-1, 58);
            ID.Margin = new Padding(3, 2, 3, 2);
            ID.MaxLength = 5;
            ID.Name = "ID";
            ID.RightToLeft = RightToLeft.No;
            ID.Size = new Size(495, 23);
            ID.TabIndex = 28;
            ID.KeyPress += NUM_KeyPress;
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
            Label_Titulo.Size = new Size(409, 43);
            Label_Titulo.TabIndex = 0;
            Label_Titulo.Text = "REGISTRAR CLIENTE";
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
            // frmCLIENTE
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
            Name = "frmCLIENTE";
            Text = "CATEGORIA_PELICULA";
            SizeChanged += Form_SizeChanged;
            panel2.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel7.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private Panel panel2;
        private Panel panel3;
        private Label Label_Titulo;
        private Label Cantidad;
        private Panel Titulo;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private TextBox Cedula;
        private TextBox ID;
        private Label label1;
        private Label label2;
        private Panel panel7;
        private Panel panel8;
        private TextBox P_Apellido;
        private Panel panel9;
        private Panel panel10;
        private TextBox S_Apellido;
        private Label label3;
        private TextBox Nombre;
        private Label label5;
        private Label label4;
        private Panel panel11;
        private Panel panel12;
        private Label label6;
        private Panel panel13;
        private Label label7;
        private DateTimePicker F_Registro;
        private DateTimePicker F_Nacimiento;
        private Panel panel14;
        private Label label8;
        private ComboBox Activo;
    }
}