namespace ScreenshotDemo
{
    partial class ScreenshotDemo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoad = new System.Windows.Forms.Button();
            this.dropWindows = new System.Windows.Forms.ComboBox();
            this.btnScreenshot = new System.Windows.Forms.Button();
            this.pictureScreenshot = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScreenshot)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Location = new System.Drawing.Point(12, 46);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 43);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dropWindows
            // 
            this.dropWindows.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropWindows.FormattingEnabled = true;
            this.dropWindows.Location = new System.Drawing.Point(12, 12);
            this.dropWindows.Name = "dropWindows";
            this.dropWindows.Size = new System.Drawing.Size(156, 28);
            this.dropWindows.TabIndex = 1;
            this.dropWindows.Text = "Choose a window";
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnScreenshot.Location = new System.Drawing.Point(93, 46);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Size = new System.Drawing.Size(75, 43);
            this.btnScreenshot.TabIndex = 2;
            this.btnScreenshot.Text = "Capture";
            this.btnScreenshot.UseVisualStyleBackColor = true;
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // pictureScreenshot
            // 
            this.pictureScreenshot.Location = new System.Drawing.Point(174, 12);
            this.pictureScreenshot.Name = "pictureScreenshot";
            this.pictureScreenshot.Size = new System.Drawing.Size(946, 619);
            this.pictureScreenshot.TabIndex = 3;
            this.pictureScreenshot.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Screenshot";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrent
            // 
            this.txtCurrent.AutoSize = true;
            this.txtCurrent.Location = new System.Drawing.Point(65, 124);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(36, 15);
            this.txtCurrent.TabIndex = 5;
            this.txtCurrent.Text = "None";
            this.txtCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScreenshotDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 643);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureScreenshot);
            this.Controls.Add(this.btnScreenshot);
            this.Controls.Add(this.dropWindows);
            this.Controls.Add(this.btnLoad);
            this.Name = "ScreenshotDemo";
            this.Text = "ScreenshotDemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureScreenshot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLoad;
        private ComboBox dropWindows;
        private Button btnScreenshot;
        private PictureBox pictureScreenshot;
        private Label label1;
        private Label txtCurrent;
    }
}