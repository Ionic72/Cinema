namespace Cinema.Interfaz.REGISTRAR
{
    partial class frmPELICULAxSUCURSAL
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Enviar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            Cifras = new TextBox();
            PELICULADGV = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TÍTULO = new DataGridViewTextBoxColumn();
            CATEGORÍA = new DataGridViewTextBoxColumn();
            LANZAMIENTO = new DataGridViewTextBoxColumn();
            IDIOMA = new DataGridViewTextBoxColumn();
            label1 = new Label();
            SucursalCBox = new ComboBox();
            panel3 = new Panel();
            Label_Titulo = new Label();
            Cantidad = new Label();
            Titulo = new Panel();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PELICULADGV).BeginInit();
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
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Cifras);
            panel2.Controls.Add(PELICULADGV);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(SucursalCBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 99);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(26, 0, 26, 0);
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(1097, 396);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(29, 75);
            label2.Name = "label2";
            label2.Padding = new Padding(4, 0, 0, 0);
            label2.Size = new Size(97, 19);
            label2.TabIndex = 21;
            label2.Text = "CANTIDAD";
            // 
            // Cifras
            // 
            Cifras.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Cifras.Cursor = Cursors.IBeam;
            Cifras.Location = new Point(29, 97);
            Cifras.Name = "Cifras";
            Cifras.Size = new Size(1039, 23);
            Cifras.TabIndex = 20;
            Cifras.KeyPress += NUM_KeyPress;
            // 
            // PELICULADGV
            // 
            PELICULADGV.AllowUserToAddRows = false;
            PELICULADGV.AllowUserToDeleteRows = false;
            PELICULADGV.AllowUserToResizeColumns = false;
            PELICULADGV.AllowUserToResizeRows = false;
            PELICULADGV.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PELICULADGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PELICULADGV.BackgroundColor = Color.DimGray;
            PELICULADGV.BorderStyle = BorderStyle.None;
            PELICULADGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PELICULADGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Brown;
            dataGridViewCellStyle4.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            PELICULADGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            PELICULADGV.ColumnHeadersHeight = 25;
            PELICULADGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            PELICULADGV.Columns.AddRange(new DataGridViewColumn[] { ID, TÍTULO, CATEGORÍA, LANZAMIENTO, IDIOMA });
            PELICULADGV.Cursor = Cursors.Hand;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(27, 30, 35);
            dataGridViewCellStyle5.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkGoldenrod;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            PELICULADGV.DefaultCellStyle = dataGridViewCellStyle5;
            PELICULADGV.EnableHeadersVisualStyles = false;
            PELICULADGV.GridColor = Color.Gainsboro;
            PELICULADGV.Location = new Point(29, 146);
            PELICULADGV.Name = "PELICULADGV";
            PELICULADGV.ReadOnly = true;
            PELICULADGV.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            PELICULADGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            PELICULADGV.RowHeadersVisible = false;
            PELICULADGV.RowTemplate.Height = 25;
            PELICULADGV.RowTemplate.ReadOnly = true;
            PELICULADGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PELICULADGV.Size = new Size(1039, 244);
            PELICULADGV.TabIndex = 19;
            PELICULADGV.CellDoubleClick += PELICULADGV_CellDoubleClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 100;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.False;
            // 
            // TÍTULO
            // 
            TÍTULO.HeaderText = "TÍTULO";
            TÍTULO.MinimumWidth = 100;
            TÍTULO.Name = "TÍTULO";
            TÍTULO.ReadOnly = true;
            TÍTULO.Resizable = DataGridViewTriState.False;
            // 
            // CATEGORÍA
            // 
            CATEGORÍA.HeaderText = "CATEGORÍA";
            CATEGORÍA.MinimumWidth = 100;
            CATEGORÍA.Name = "CATEGORÍA";
            CATEGORÍA.ReadOnly = true;
            CATEGORÍA.Resizable = DataGridViewTriState.False;
            // 
            // LANZAMIENTO
            // 
            LANZAMIENTO.HeaderText = "LANZAMIENTO";
            LANZAMIENTO.MinimumWidth = 100;
            LANZAMIENTO.Name = "LANZAMIENTO";
            LANZAMIENTO.ReadOnly = true;
            LANZAMIENTO.Resizable = DataGridViewTriState.False;
            // 
            // IDIOMA
            // 
            IDIOMA.HeaderText = "IDIOMA";
            IDIOMA.MinimumWidth = 100;
            IDIOMA.Name = "IDIOMA";
            IDIOMA.ReadOnly = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(29, 14);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 0, 0, 0);
            label1.Size = new Size(104, 19);
            label1.TabIndex = 18;
            label1.Text = "SUCURSAL";
            // 
            // SucursalCBox
            // 
            SucursalCBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SucursalCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SucursalCBox.FormattingEnabled = true;
            SucursalCBox.Location = new Point(29, 36);
            SucursalCBox.Name = "SucursalCBox";
            SucursalCBox.Size = new Size(1039, 23);
            SucursalCBox.TabIndex = 0;
            SucursalCBox.SelectedIndexChanged += SucursalCBox_SelectedIndexChanged;
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
            Label_Titulo.Size = new Size(765, 43);
            Label_Titulo.TabIndex = 0;
            Label_Titulo.Text = "REGISTRAR PELÍCULAS POR SUCURSAL";
            Label_Titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // Cantidad
            // 
            Cantidad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Cantidad.AutoSize = true;
            Cantidad.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cantidad.Location = new Point(782, 46);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(236, 18);
            Cantidad.TabIndex = 1;
            Cantidad.Text = "Almacenamiento disponible: 100";
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
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(29, 124);
            label3.Name = "label3";
            label3.Padding = new Padding(4, 0, 0, 0);
            label3.Size = new Size(293, 19);
            label3.TabIndex = 22;
            label3.Text = "DOBLE CLICK PARA SELECCIONAR";
            // 
            // frmPELICULAxSUCURSAL
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
            Name = "frmPELICULAxSUCURSAL";
            Text = "CATEGORIA_PELICULA";
            SizeChanged += Form_SizeChanged;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PELICULADGV).EndInit();
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
        private ComboBox SucursalCBox;
        private Label label1;
        private Label label2;
        private TextBox Cifras;
        private DataGridView PELICULADGV;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TÍTULO;
        private DataGridViewTextBoxColumn CATEGORÍA;
        private DataGridViewTextBoxColumn LANZAMIENTO;
        private DataGridViewTextBoxColumn IDIOMA;
        private Label label3;
    }
}