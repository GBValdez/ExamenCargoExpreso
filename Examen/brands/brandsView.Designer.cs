namespace Examen.brands
{
    partial class brandsView
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
            components = new System.ComponentModel.Container();
            dataGriwList = new DataGridView();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btn_save = new Button();
            btn_delete = new Button();
            btn_clean = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGriwList).BeginInit();
            SuspendLayout();
            // 
            // dataGriwList
            // 
            dataGriwList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGriwList.Location = new Point(397, 95);
            dataGriwList.Name = "dataGriwList";
            dataGriwList.ReadOnly = true;
            dataGriwList.RowHeadersWidth = 51;
            dataGriwList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGriwList.Size = new Size(562, 417);
            dataGriwList.TabIndex = 0;
            dataGriwList.Click += dataGriwList_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 95);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(42, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(257, 27);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 163);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 3;
            label2.Text = "Descripcion";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(42, 197);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(257, 60);
            txtDescription.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btn_save
            // 
            btn_save.Location = new Point(42, 282);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(257, 29);
            btn_save.TabIndex = 6;
            btn_save.Text = "Guardar";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(255, 128, 128);
            btn_delete.Location = new Point(42, 353);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(257, 29);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Eliminar";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_clean
            // 
            btn_clean.BackColor = SystemColors.ActiveCaption;
            btn_clean.Location = new Point(42, 318);
            btn_clean.Name = "btn_clean";
            btn_clean.Size = new Size(257, 29);
            btn_clean.TabIndex = 8;
            btn_clean.Text = "Limpiar";
            btn_clean.UseVisualStyleBackColor = false;
            btn_clean.Click += btn_clean_Click;
            // 
            // brandsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 542);
            Controls.Add(btn_clean);
            Controls.Add(btn_delete);
            Controls.Add(btn_save);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(dataGriwList);
            Name = "brandsView";
            Text = "Marca";
            Load += brandsView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGriwList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGriwList;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtDescription;
        private ContextMenuStrip contextMenuStrip1;
        private Button btn_save;
        private Button btn_delete;
        private Button btn_clean;
    }
}