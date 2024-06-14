namespace Cinema.Interfaz.CONSULTAR
{
    partial class frmCLIENTE_C
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            Titulo = new Panel();
            Label_Titulo = new Label();
            panel2 = new Panel();
            CLIENTEDGV = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            IDENTIFICACIÓN = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            P_APELLIDO = new DataGridViewTextBoxColumn();
            S_APELLIDO = new DataGridViewTextBoxColumn();
            NACIMIENTO = new DataGridViewTextBoxColumn();
            REGISTRO = new DataGridViewTextBoxColumn();
            ACTIVO = new DataGridViewTextBoxColumn();
            Titulo.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CLIENTEDGV).BeginInit();
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
            // Titulo
            // 
            Titulo.BackColor = Color.Brown;
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
            // Label_Titulo
            // 
            Label_Titulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Label_Titulo.AutoSize = true;
            Label_Titulo.Font = new Font("Arial", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Titulo.Location = new Point(170, 13);
            Label_Titulo.Name = "Label_Titulo";
            Label_Titulo.Size = new Size(440, 43);
            Label_Titulo.TabIndex = 0;
            Label_Titulo.Text = "CONSULTAR CLIENTES";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 30, 35);
            panel2.Controls.Add(CLIENTEDGV);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 99);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(50, 26, 50, 26);
            panel2.Size = new Size(1097, 450);
            panel2.TabIndex = 7;
            // 
            // CLIENTEDGV
            // 
            CLIENTEDGV.AllowUserToAddRows = false;
            CLIENTEDGV.AllowUserToDeleteRows = false;
            CLIENTEDGV.AllowUserToResizeColumns = false;
            CLIENTEDGV.AllowUserToResizeRows = false;
            CLIENTEDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CLIENTEDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CLIENTEDGV.BackgroundColor = Color.FromArgb(27, 30, 35);
            CLIENTEDGV.BorderStyle = BorderStyle.None;
            CLIENTEDGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CLIENTEDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            CLIENTEDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CLIENTEDGV.Columns.AddRange(new DataGridViewColumn[] { ID, IDENTIFICACIÓN, NOMBRE, P_APELLIDO, S_APELLIDO, NACIMIENTO, REGISTRO, ACTIVO });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(25, 40, 76);
            dataGridViewCellStyle4.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            CLIENTEDGV.DefaultCellStyle = dataGridViewCellStyle4;
            CLIENTEDGV.EnableHeadersVisualStyles = false;
            CLIENTEDGV.GridColor = Color.Tomato;
            CLIENTEDGV.ImeMode = ImeMode.NoControl;
            CLIENTEDGV.Location = new Point(53, 29);
            CLIENTEDGV.MultiSelect = false;
            CLIENTEDGV.Name = "CLIENTEDGV";
            CLIENTEDGV.ReadOnly = true;
            CLIENTEDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            CLIENTEDGV.RowHeadersVisible = false;
            CLIENTEDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            CLIENTEDGV.RowTemplate.Height = 25;
            CLIENTEDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CLIENTEDGV.ShowCellToolTips = false;
            CLIENTEDGV.ShowEditingIcon = false;
            CLIENTEDGV.Size = new Size(991, 392);
            CLIENTEDGV.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // IDENTIFICACIÓN
            // 
            IDENTIFICACIÓN.HeaderText = "IDENTIFICACIÓN";
            IDENTIFICACIÓN.Name = "IDENTIFICACIÓN";
            IDENTIFICACIÓN.ReadOnly = true;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            // 
            // P_APELLIDO
            // 
            P_APELLIDO.HeaderText = "P. APELLIDO";
            P_APELLIDO.Name = "P_APELLIDO";
            P_APELLIDO.ReadOnly = true;
            // 
            // S_APELLIDO
            // 
            S_APELLIDO.HeaderText = "S. APELLIDO";
            S_APELLIDO.Name = "S_APELLIDO";
            S_APELLIDO.ReadOnly = true;
            // 
            // NACIMIENTO
            // 
            NACIMIENTO.HeaderText = "NACIMIENTO";
            NACIMIENTO.Name = "NACIMIENTO";
            NACIMIENTO.ReadOnly = true;
            // 
            // REGISTRO
            // 
            REGISTRO.HeaderText = "REGISTRO";
            REGISTRO.Name = "REGISTRO";
            REGISTRO.ReadOnly = true;
            // 
            // ACTIVO
            // 
            ACTIVO.HeaderText = "ACTIVO";
            ACTIVO.Name = "ACTIVO";
            ACTIVO.ReadOnly = true;
            // 
            // frmCLIENTE_C
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 30, 35);
            ClientSize = new Size(1097, 549);
            Controls.Add(panel2);
            Controls.Add(Titulo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCLIENTE_C";
            Text = "CATEGORIA_PELICULA";
            SizeChanged += Form_SizeChanged;
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CLIENTEDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Titulo;
        private Label Label_Titulo;
        private Panel panel2;
        private DataGridView CLIENTEDGV;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn IDENTIFICACIÓN;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn P_APELLIDO;
        private DataGridViewTextBoxColumn S_APELLIDO;
        private DataGridViewTextBoxColumn NACIMIENTO;
        private DataGridViewTextBoxColumn REGISTRO;
        private DataGridViewTextBoxColumn ACTIVO;
    }
}