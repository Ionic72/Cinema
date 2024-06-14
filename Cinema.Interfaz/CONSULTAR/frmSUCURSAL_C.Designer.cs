namespace Cinema.Interfaz.CONSULTAR
{
    partial class frmSUCURSAL_C
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
            SUCURSALDGV = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            ENCARGADO = new DataGridViewTextBoxColumn();
            DIRECCIÓN = new DataGridViewTextBoxColumn();
            TELÉFONO = new DataGridViewTextBoxColumn();
            ACTIVO = new DataGridViewTextBoxColumn();
            Titulo.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SUCURSALDGV).BeginInit();
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
            Label_Titulo.Size = new Size(463, 43);
            Label_Titulo.TabIndex = 0;
            Label_Titulo.Text = "CONSULTAR PELICULAS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 30, 35);
            panel2.Controls.Add(SUCURSALDGV);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 99);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(50, 26, 50, 26);
            panel2.Size = new Size(1097, 450);
            panel2.TabIndex = 7;
            // 
            // SUCURSALDGV
            // 
            SUCURSALDGV.AllowUserToAddRows = false;
            SUCURSALDGV.AllowUserToDeleteRows = false;
            SUCURSALDGV.AllowUserToResizeColumns = false;
            SUCURSALDGV.AllowUserToResizeRows = false;
            SUCURSALDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SUCURSALDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SUCURSALDGV.BackgroundColor = Color.FromArgb(27, 30, 35);
            SUCURSALDGV.BorderStyle = BorderStyle.None;
            SUCURSALDGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            SUCURSALDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            SUCURSALDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SUCURSALDGV.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, ENCARGADO, DIRECCIÓN, TELÉFONO, ACTIVO });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(25, 40, 76);
            dataGridViewCellStyle4.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            SUCURSALDGV.DefaultCellStyle = dataGridViewCellStyle4;
            SUCURSALDGV.EnableHeadersVisualStyles = false;
            SUCURSALDGV.GridColor = Color.Tomato;
            SUCURSALDGV.ImeMode = ImeMode.NoControl;
            SUCURSALDGV.Location = new Point(53, 29);
            SUCURSALDGV.MultiSelect = false;
            SUCURSALDGV.Name = "SUCURSALDGV";
            SUCURSALDGV.ReadOnly = true;
            SUCURSALDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            SUCURSALDGV.RowHeadersVisible = false;
            SUCURSALDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            SUCURSALDGV.RowTemplate.Height = 25;
            SUCURSALDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SUCURSALDGV.ShowCellToolTips = false;
            SUCURSALDGV.ShowEditingIcon = false;
            SUCURSALDGV.Size = new Size(991, 392);
            SUCURSALDGV.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            // 
            // ENCARGADO
            // 
            ENCARGADO.HeaderText = "ENCARGADO";
            ENCARGADO.Name = "ENCARGADO";
            ENCARGADO.ReadOnly = true;
            // 
            // DIRECCIÓN
            // 
            DIRECCIÓN.HeaderText = "DIRECCIÓN";
            DIRECCIÓN.Name = "DIRECCIÓN";
            DIRECCIÓN.ReadOnly = true;
            // 
            // TELÉFONO
            // 
            TELÉFONO.HeaderText = "TELÉFONO";
            TELÉFONO.Name = "TELÉFONO";
            TELÉFONO.ReadOnly = true;
            // 
            // ACTIVO
            // 
            ACTIVO.HeaderText = "ACTIVO";
            ACTIVO.Name = "ACTIVO";
            ACTIVO.ReadOnly = true;
            // 
            // frmSUCURSAL_C
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
            Name = "frmSUCURSAL_C";
            Text = "CATEGORIA_PELICULA";
            SizeChanged += Form_SizeChanged;
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SUCURSALDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Titulo;
        private Label Label_Titulo;
        private Panel panel2;
        private DataGridView SUCURSALDGV;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn ENCARGADO;
        private DataGridViewTextBoxColumn DIRECCIÓN;
        private DataGridViewTextBoxColumn TELÉFONO;
        private DataGridViewTextBoxColumn ACTIVO;
    }
}