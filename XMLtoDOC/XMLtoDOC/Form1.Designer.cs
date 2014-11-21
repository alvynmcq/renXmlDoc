namespace WindowsFormsApplication1
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
            this.dirPathBox = new System.Windows.Forms.TextBox();
            this.instrLabel = new System.Windows.Forms.Label();
            this.conButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dirPathBox
            // 
            this.dirPathBox.Location = new System.Drawing.Point(13, 33);
            this.dirPathBox.Name = "dirPathBox";
            this.dirPathBox.Size = new System.Drawing.Size(259, 20);
            this.dirPathBox.TabIndex = 0;
            // 
            // instrLabel
            // 
            this.instrLabel.AutoSize = true;
            this.instrLabel.Location = new System.Drawing.Point(12, 17);
            this.instrLabel.Name = "instrLabel";
            this.instrLabel.Size = new System.Drawing.Size(80, 13);
            this.instrLabel.TabIndex = 1;
            this.instrLabel.Text = "Path to xml files";
            // 
            // conButton
            // 
            this.conButton.Location = new System.Drawing.Point(12, 59);
            this.conButton.Name = "conButton";
            this.conButton.Size = new System.Drawing.Size(75, 23);
            this.conButton.TabIndex = 2;
            this.conButton.Text = "Convert";
            this.conButton.UseVisualStyleBackColor = true;
            this.conButton.Click += new System.EventHandler(this.conButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.conButton);
            this.Controls.Add(this.instrLabel);
            this.Controls.Add(this.dirPathBox);
            this.Name = "Form1";
            this.Text = "XML to DOC Report Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dirPathBox;
        private System.Windows.Forms.Label instrLabel;
        private System.Windows.Forms.Button conButton;
    }
}

