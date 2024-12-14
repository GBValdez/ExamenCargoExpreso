namespace Examen.products
{
    partial class productsView
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_name = new TextBox();
            txt_description = new TextBox();
            txt_price = new NumericUpDown();
            combo_brand = new ComboBox();
            combo_catalog = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)txt_price).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 76);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 140);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(200, 76);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(200, 140);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(38, 202);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Catalogo";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(38, 99);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 27);
            txt_name.TabIndex = 5;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(38, 163);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(125, 27);
            txt_description.TabIndex = 6;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(200, 99);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(150, 27);
            txt_price.TabIndex = 8;
            // 
            // combo_brand
            // 
            combo_brand.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_brand.FormattingEnabled = true;
            combo_brand.Location = new Point(199, 163);
            combo_brand.Name = "combo_brand";
            combo_brand.Size = new Size(151, 28);
            combo_brand.TabIndex = 9;
            // 
            // combo_catalog
            // 
            combo_catalog.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_catalog.FormattingEnabled = true;
            combo_catalog.Location = new Point(38, 225);
            combo_catalog.Name = "combo_catalog";
            combo_catalog.Size = new Size(151, 28);
            combo_catalog.TabIndex = 10;
            // 
            // productsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(combo_catalog);
            Controls.Add(combo_brand);
            Controls.Add(txt_price);
            Controls.Add(txt_description);
            Controls.Add(txt_name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "productsView";
            Text = "Productos";
            Load += productsView_Load;
            ((System.ComponentModel.ISupportInitialize)txt_price).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_name;
        private TextBox txt_description;
        private NumericUpDown txt_price;
        private ComboBox combo_brand;
        private ComboBox combo_catalog;
    }
}