namespace KindleImageResizer
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
            this.loadImageButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.PictureBox();
            this.kindleRadio = new System.Windows.Forms.RadioButton();
            this.dxRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(12, 441);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(147, 32);
            this.loadImageButton.TabIndex = 0;
            this.loadImageButton.Text = "Load Image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(165, 441);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(147, 32);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Convert Image";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.Color.White;
            this.displayBox.Location = new System.Drawing.Point(12, 12);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(300, 400);
            this.displayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.displayBox.TabIndex = 3;
            this.displayBox.TabStop = false;
            // 
            // kindleRadio
            // 
            this.kindleRadio.AutoSize = true;
            this.kindleRadio.Location = new System.Drawing.Point(39, 418);
            this.kindleRadio.Name = "kindleRadio";
            this.kindleRadio.Size = new System.Drawing.Size(104, 17);
            this.kindleRadio.TabIndex = 4;
            this.kindleRadio.TabStop = true;
            this.kindleRadio.Text = "Kindle (600x800)";
            this.kindleRadio.UseVisualStyleBackColor = true;
            this.kindleRadio.CheckedChanged += new System.EventHandler(this.kindleRadio_CheckedChanged);
            // 
            // dxRadio
            // 
            this.dxRadio.AutoSize = true;
            this.dxRadio.Location = new System.Drawing.Point(149, 418);
            this.dxRadio.Name = "dxRadio";
            this.dxRadio.Size = new System.Drawing.Size(128, 17);
            this.dxRadio.TabIndex = 5;
            this.dxRadio.TabStop = true;
            this.dxRadio.Text = "Kindle DX (824x1200)";
            this.dxRadio.UseVisualStyleBackColor = true;
            this.dxRadio.CheckedChanged += new System.EventHandler(this.dxRadio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 479);
            this.Controls.Add(this.kindleRadio);
            this.Controls.Add(this.dxRadio);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadImageButton);
            this.Name = "Form1";
            this.Text = "Kindle Screensaver Resizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox displayBox;
        private System.Windows.Forms.RadioButton kindleRadio;
        private System.Windows.Forms.RadioButton dxRadio;
    }
}

