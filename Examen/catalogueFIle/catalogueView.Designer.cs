using System.Xml.Linq;

namespace Examen.catalogueFIle
{
    partial class catalogueView
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
            txtName = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            SuspendLayout();
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
            // catalogueView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "catalogueView";
            Text = "Catalogos";
            Load += catalogueView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtDescription;
    }
}