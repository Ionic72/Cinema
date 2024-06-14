namespace Cinema.Interfaz.CONSULTAR
{
    partial class frmCATEGORIA_PELICULA_C
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
            CATEGORIA_PELICULADGV = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CATEGORÍA = new DataGridViewTextBoxColumn();
            DESCRIPCIÓN = new DataGridViewTextBoxColumn();
            Titulo.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CATEGORIA_PELICULADGV).BeginInit();
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
            Label_Titulo.Size = new Size(730, 43);
            Label_Titulo.TabIndex = 0;
            Label_Titulo.Text = "CONSULTAR CATEGORÍA DE PELICULA";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 30, 35);
            panel2.Controls.Add(CATEGORIA_PELICULADGV);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 99);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(25);
            panel2.Size = new Size(1097, 450);
            panel2.TabIndex = 7;
            // 
            // CATEGORIA_PELICULADGV
            // 
            CATEGORIA_PELICULADGV.AllowUserToAddRows = false;
            CATEGORIA_PELICULADGV.AllowUserToDeleteRows = false;
            CATEGORIA_PELICULADGV.AllowUserToResizeColumns = false;
            CATEGORIA_PELICULADGV.AllowUserToResizeRows = false;
            CATEGORIA_PELICULADGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CATEGORIA_PELICULADGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CATEGORIA_PELICULADGV.BackgroundColor = Color.FromArgb(27, 30, 35);
            CATEGORIA_PELICULADGV.BorderStyle = BorderStyle.None;
            CATEGORIA_PELICULADGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CATEGORIA_PELICULADGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CATEGORIA_PELICULADGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CATEGORIA_PELICULADGV.Columns.AddRange(new DataGridViewColumn[] { ID, CATEGORÍA, DESCRIPCIÓN });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 40, 76);
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CATEGORIA_PELICULADGV.DefaultCellStyle = dataGridViewCellStyle2;
            CATEGORIA_PELICULADGV.EnableHeadersVisualStyles = false;
            CATEGORIA_PELICULADGV.GridColor = Color.Tomato;
            CATEGORIA_PELICULADGV.ImeMode = ImeMode.NoControl;
            CATEGORIA_PELICULADGV.Location = new Point(28, 28);
            CATEGORIA_PELICULADGV.MultiSelect = false;
            CATEGORIA_PELICULADGV.Name = "CATEGORIA_PELICULADGV";
            CATEGORIA_PELICULADGV.ReadOnly = true;
            CATEGORIA_PELICULADGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            CATEGORIA_PELICULADGV.RowHeadersVisible = false;
            CATEGORIA_PELICULADGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            CATEGORIA_PELICULADGV.RowTemplate.Height = 25;
            CATEGORIA_PELICULADGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CATEGORIA_PELICULADGV.ShowCellErrors = false;
            CATEGORIA_PELICULADGV.ShowEditingIcon = false;
            CATEGORIA_PELICULADGV.ShowRowErrors = false;
            CATEGORIA_PELICULADGV.Size = new Size(1041, 394);
            CATEGORIA_PELICULADGV.TabIndex = 0;
            CATEGORIA_PELICULADGV.Tag = "";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // CATEGORÍA
            // 
            CATEGORÍA.HeaderText = "CATEGORÍA";
            CATEGORÍA.Name = "CATEGORÍA";
            CATEGORÍA.ReadOnly = true;
            // 
            // DESCRIPCIÓN
            // 
            DESCRIPCIÓN.HeaderText = "DESCRIPCIÓN";
            DESCRIPCIÓN.Name = "DESCRIPCIÓN";
            DESCRIPCIÓN.ReadOnly = true;
            // 
            // frmCATEGORIA_PELICULA_C
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
            Name = "frmCATEGORIA_PELICULA_C";
            Text = "CATEGORIA_PELICULA";
            SizeChanged += Form_SizeChanged;
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CATEGORIA_PELICULADGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Titulo;
        private Label Label_Titulo;
        private Panel panel2;
        private DataGridView CATEGORIA_PELICULADGV;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CATEGORÍA;
        private DataGridViewTextBoxColumn DESCRIPCIÓN;
    }
}