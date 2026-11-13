namespace Zajecia_13_11_2026
{
    partial class Form1
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
            rtbDisplay = new RichTextBox();
            lbDisplay = new Label();
            btRun = new Button();
            SuspendLayout();
            // 
            // rtbDisplay
            // 
            rtbDisplay.Location = new Point(12, 196);
            rtbDisplay.Name = "rtbDisplay";
            rtbDisplay.Size = new Size(260, 198);
            rtbDisplay.TabIndex = 0;
            rtbDisplay.Text = "";
            // 
            // lbDisplay
            // 
            lbDisplay.AutoSize = true;
            lbDisplay.Location = new Point(12, 164);
            lbDisplay.Name = "lbDisplay";
            lbDisplay.Size = new Size(142, 15);
            lbDisplay.TabIndex = 1;
            lbDisplay.Text = "Wynik dziłania  programu";
            // 
            // btRun
            // 
            btRun.Location = new Point(12, 123);
            btRun.Name = "btRun";
            btRun.Size = new Size(75, 23);
            btRun.TabIndex = 2;
            btRun.Text = "Uruchom";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += btRun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btRun);
            Controls.Add(lbDisplay);
            Controls.Add(rtbDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbDisplay;
        private Label lbDisplay;
        private Button btRun;
    }
}
