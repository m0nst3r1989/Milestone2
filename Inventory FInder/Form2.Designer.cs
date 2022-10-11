namespace Inventory_FInder
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityNumBox = new System.Windows.Forms.TextBox();
            this.shelfNumBox = new System.Windows.Forms.TextBox();
            this.aisleNumBox = new System.Windows.Forms.TextBox();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aisle Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shelf Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // quantityNumBox
            // 
            this.quantityNumBox.Location = new System.Drawing.Point(494, 188);
            this.quantityNumBox.Name = "quantityNumBox";
            this.quantityNumBox.Size = new System.Drawing.Size(100, 22);
            this.quantityNumBox.TabIndex = 3;
            // 
            // shelfNumBox
            // 
            this.shelfNumBox.Location = new System.Drawing.Point(494, 121);
            this.shelfNumBox.Name = "shelfNumBox";
            this.shelfNumBox.Size = new System.Drawing.Size(100, 22);
            this.shelfNumBox.TabIndex = 4;
            // 
            // aisleNumBox
            // 
            this.aisleNumBox.Location = new System.Drawing.Point(494, 59);
            this.aisleNumBox.Name = "aisleNumBox";
            this.aisleNumBox.Size = new System.Drawing.Size(100, 22);
            this.aisleNumBox.TabIndex = 5;
            this.aisleNumBox.TextChanged += new System.EventHandler(this.aisleNumBox_TextChanged);
            // 
            // goBackBtn
            // 
            this.goBackBtn.Location = new System.Drawing.Point(468, 261);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(126, 23);
            this.goBackBtn.TabIndex = 6;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.GoBackBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goBackBtn);
            this.Controls.Add(this.aisleNumBox);
            this.Controls.Add(this.shelfNumBox);
            this.Controls.Add(this.quantityNumBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Warehouse Aisle Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityNumBox;
        private System.Windows.Forms.TextBox shelfNumBox;
        private System.Windows.Forms.TextBox aisleNumBox;
        private System.Windows.Forms.Button goBackBtn;
    }
}