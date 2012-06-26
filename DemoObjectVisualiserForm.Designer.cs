namespace VisualiserDemo
{
    partial class DemoObjectVisualiserForm
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
            this.arrayContents = new System.Windows.Forms.TextBox();
            this.colourBox = new System.Windows.Forms.PictureBox();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.colourBox)).BeginInit();
            this.SuspendLayout();
            // 
            // arrayContents
            // 
            this.arrayContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arrayContents.Location = new System.Drawing.Point(0, 0);
            this.arrayContents.Multiline = true;
            this.arrayContents.Name = "arrayContents";
            this.arrayContents.Size = new System.Drawing.Size(524, 277);
            this.arrayContents.TabIndex = 0;
            // 
            // colourBox
            // 
            this.colourBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.colourBox.Location = new System.Drawing.Point(54, 300);
            this.colourBox.Name = "colourBox";
            this.colourBox.Size = new System.Drawing.Size(349, 68);
            this.colourBox.TabIndex = 1;
            this.colourBox.TabStop = false;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(436, 345);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // DemoObjectVisualiserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 380);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.colourBox);
            this.Controls.Add(this.arrayContents);
            this.Name = "DemoObjectVisualiserForm";
            this.Text = "DemoObject Visualiser";
            ((System.ComponentModel.ISupportInitialize)(this.colourBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arrayContents;
        public System.Windows.Forms.PictureBox colourBox;
        private System.Windows.Forms.Button updateButton;
    }
}