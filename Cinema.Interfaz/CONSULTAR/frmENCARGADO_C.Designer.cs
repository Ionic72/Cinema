namespace Cinema.Interfaz.CONSULTAR
{
    partial class frmENCARGADO_C
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            Titulo = new Panel();
            Label_Titulo = new Label();
            panel2 = new Panel();
            PELICULADGV = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            IDENTIFICACIÓN = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            P_APELLIDO = new DataGridViewTextBoxColumn();
            S_APELLIDO = new DataGridViewTextBoxColumn();
            NACIMIENTO = new DataGridViewTextBoxColumn();
            INGRESO = new DataGridViewTextBoxColumn();
            Titulo.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PELICULADGV).BeginInit();
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
            Label_Titulo.Size = new Size(524, 43);
            Label_Titulo.TabIndex = 0;
            Label_Titulo.Text = "CONSULTAR ENCARGADOS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 30, 35);
            panel2.Controls.Add(PELICULADGV);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 99);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(25);
            panel2.Size = new Size(1097, 450);
            panel2.TabIndex = 7;
            // 
            // PELICULADGV
            // 
            PELICULADGV.AllowUserToAddRows = false;
            PELICULADGV.AllowUserToDeleteRows = false;
            PELICULADGV.AllowUserToResizeColumns = false;
            PELICULADGV.AllowUserToResizeRows = false;
            PELICULADGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PELICULADGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PELICULADGV.BackgroundColor = Color.FromArgb(27, 30, 35);
            PELICULADGV.BorderStyle = BorderStyle.None;
            PELICULADGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            PELICULADGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            PELICULADGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PELICULADGV.Columns.AddRange(new DataGridViewColumn[] { ID, IDENTIFICACIÓN, NOMBRE, P_APELLIDO, S_APELLIDO, NACIMIENTO, INGRESO });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 40, 76);
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            PELICULADGV.DefaultCellStyle = dataGridViewCellStyle2;
            PELICULADGV.EnableHeadersVisualStyles = false;
            PELICULADGV.GridColor = Color.Tomato;
            PELICULADGV.ImeMode = ImeMode.NoControl;
            PELICULADGV.Location = new Point(28, 28);
            PELICULADGV.MultiSelect = false;
            PELICULADGV.Name = "PELICULADGV";
            PELICULADGV.ReadOnly = true;
            PELICULADGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            PELICULADGV.RowHeadersVisible = false;
            PELICULADGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            PELICULADGV.RowTemplate.Height = 25;
            PELICULADGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PELICULADGV.ShowCellErrors = false;
            PELICULADGV.ShowEditingIcon = false;
            PELICULADGV.Size = new Size(1041, 394);
            PELICULADGV.TabIndex = 0;
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
            // INGRESO
            // 
            INGRESO.HeaderText = "INGRESO";
            INGRESO.Name = "INGRESO";
            INGRESO.ReadOnly = true;
            // 
            // frmENCARGADO_C
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
            Name = "frmENCARGADO_C";
            Text = "CATEGORIA_PELICULA";
            SizeChanged += Form_SizeChanged;
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PELICULADGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Titulo;
        private Label Label_Titulo;
        private Panel panel2;
        private DataGridView PELICULADGV;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn IDENTIFICACIÓN;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn P_APELLIDO;
        private DataGridViewTextBoxColumn S_APELLIDO;
        private DataGridViewTextBoxColumn NACIMIENTO;
        private DataGridViewTextBoxColumn INGRESO;
    }
}