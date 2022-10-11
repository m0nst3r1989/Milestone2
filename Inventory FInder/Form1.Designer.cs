namespace Inventory_FInder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.searchBtn = new System.Windows.Forms.Button();
            this.productNamBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productNumBox = new System.Windows.Forms.ComboBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(292, 217);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(121, 23);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // productNamBox
            // 
            this.productNamBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productNamBox.FormattingEnabled = true;
            this.productNamBox.Location = new System.Drawing.Point(292, 93);
            this.productNamBox.Name = "productNamBox";
            this.productNamBox.Size = new System.Drawing.Size(121, 24);
            this.productNamBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Name";
            // 
            // productNumBox
            // 
            this.productNumBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productNumBox.FormattingEnabled = true;
            this.productNumBox.Location = new System.Drawing.Point(292, 161);
            this.productNumBox.Name = "productNumBox";
            this.productNumBox.Size = new System.Drawing.Size(121, 24);
            this.productNumBox.TabIndex = 2;
            this.productNumBox.SelectedIndexChanged += new System.EventHandler(this.productNumBox_SelectedIndexChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(458, 217);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(105, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productNumBox);
            this.Controls.Add(this.productNamBox);
            this.Controls.Add(this.searchBtn);
            this.Name = "Form1";
            this.Text = "Invetory Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox productNamBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productNumBox;
        private System.Windows.Forms.Button exitBtn;
    }
}

