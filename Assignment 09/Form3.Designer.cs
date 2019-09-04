namespace FormSpace
{
    partial class Form3
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
            this.richTextBox0 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox0
            // 
            this.richTextBox0.Location = new System.Drawing.Point(12, 5);
            this.richTextBox0.Name = "richTextBox0";
            this.richTextBox0.Size = new System.Drawing.Size(323, 304);
            this.richTextBox0.TabIndex = 0;
            this.richTextBox0.Text = "";
            this.richTextBox0.TextChanged += new System.EventHandler(this.RichTextBox0_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 319);
            this.Controls.Add(this.richTextBox0);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox0;
    }
}