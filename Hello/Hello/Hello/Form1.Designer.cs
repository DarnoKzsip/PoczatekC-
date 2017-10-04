namespace Hello
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
            this.pierwszy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pierwszy
            // 
            this.pierwszy.Location = new System.Drawing.Point(106, 116);
            this.pierwszy.Name = "pierwszy";
            this.pierwszy.Size = new System.Drawing.Size(219, 83);
            this.pierwszy.TabIndex = 0;
            this.pierwszy.Text = "pierwszy przycisk";
            this.pierwszy.UseVisualStyleBackColor = true;
            this.pierwszy.Click += new System.EventHandler(this.pierwszy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 323);
            this.Controls.Add(this.pierwszy);
            this.Name = "Form1";
            this.Text = "Pierwszy w gicie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pierwszy;
    }
}

