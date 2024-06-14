namespace Cinema.Interfaz.CONSULTAR
{
    partial class frmPELICULAxSUCURSAL_C
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
            PELICULAxSUCURSALDGV = new DataGridView();
            SUCURSAL = new DataGridViewTextBoxColumn();
            PELÍCULA = new DataGridViewTextBoxColumn();
            CANTIDAD = new DataGridViewTextBoxColumn();
            Titulo.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PELICULAxSUCURSALDGV).BeginInit();
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
            Label_Titulo.Size = new Size(821, 43);
            Label_Titulo.TabIndex = 0;
            Label_Titulo.Text = "CONSULTAR PELICULAS POR SUCURSALES";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 30, 35);
            panel2.Controls.Add(PELICULAxSUCURSALDGV);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 99);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(50, 26, 50, 26);
            panel2.Size = new Size(1097, 450);
            panel2.TabIndex = 7;
            // 
            // PELICULAxSUCURSALDGV
            // 
            PELICULAxSUCURSALDGV.AllowUserToAddRows = false;
            PELICULAxSUCURSALDGV.AllowUserToDeleteRows = false;
            PELICULAxSUCURSALDGV.AllowUserToResizeColumns = false;
            PELICULAxSUCURSALDGV.AllowUserToResizeRows = false;
            PELICULAxSUCURSALDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PELICULAxSUCURSALDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PELICULAxSUCURSALDGV.BackgroundColor = Color.FromArgb(27, 30, 35);
            PELICULAxSUCURSALDGV.BorderStyle = BorderStyle.None;
            PELICULAxSUCURSALDGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            PELICULAxSUCURSALDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            PELICULAxSUCURSALDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PELICULAxSUCURSALDGV.Columns.AddRange(new DataGridViewColumn[] { SUCURSAL, PELÍCULA, CANTIDAD });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(25, 40, 76);
            dataGridViewCellStyle4.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            PELICULAxSUCURSALDGV.DefaultCellStyle = dataGridViewCellStyle4;
            PELICULAxSUCURSALDGV.EnableHeadersVisualStyles = false;
            PELICULAxSUCURSALDGV.GridColor = Color.Tomato;
            PELICULAxSUCURSALDGV.ImeMode = ImeMode.NoControl;
            PELICULAxSUCURSALDGV.Location = new Point(53, 29);
            PELICULAxSUCURSALDGV.MultiSelect = false;
            PELICULAxSUCURSALDGV.Name = "PELICULAxSUCURSALDGV";
            PELICULAxSUCURSALDGV.ReadOnly = true;
            PELICULAxSUCURSALDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            PELICULAxSUCURSALDGV.RowHeadersVisible = false;
            PELICULAxSUCURSALDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            PELICULAxSUCURSALDGV.RowTemplate.Height = 25;
            PELICULAxSUCURSALDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PELICULAxSUCURSALDGV.ShowCellToolTips = false;
            PELICULAxSUCURSALDGV.ShowEditingIcon = false;
            PELICULAxSUCURSALDGV.Size = new Size(991, 392);
            PELICULAxSUCURSALDGV.TabIndex = 0;
            // 
            // SUCURSAL
            // 
            SUCURSAL.HeaderText = "SUCURSAL";
            SUCURSAL.Name = "SUCURSAL";
            SUCURSAL.ReadOnly = true;
            // 
            // PELÍCULA
            // 
            PELÍCULA.HeaderText = "PELÍCULA";
            PELÍCULA.Name = "PELÍCULA";
            PELÍCULA.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            CANTIDAD.HeaderText = "CANTIDAD";
            CANTIDAD.Name = "CANTIDAD";
            CANTIDAD.ReadOnly = true;
            // 
            // frmPELICULAxSUCURSAL_C
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
            Name = "frmPELICULAxSUCURSAL_C";
            Text = "CATEGORIA_PELICULA";
            SizeChanged += Form_SizeChanged;
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PELICULAxSUCURSALDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Titulo;
        private Label Label_Titulo;
        private Panel panel2;
        private DataGridView PELICULAxSUCURSALDGV;
        private DataGridViewTextBoxColumn SUCURSAL;
        private DataGridViewTextBoxColumn PELÍCULA;
        private DataGridViewTextBoxColumn CANTIDAD;
    }
}