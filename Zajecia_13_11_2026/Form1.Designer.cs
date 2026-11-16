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
            btAddTree = new Button();
            lbAddTree = new Label();
            tbAddTree = new TextBox();
            btDispTrees = new Button();
            cbChooseTree = new ComboBox();
            lbChooseTree = new Label();
            SuspendLayout();
            // 
            // rtbDisplay
            // 
            rtbDisplay.Location = new Point(14, 261);
            rtbDisplay.Margin = new Padding(3, 4, 3, 4);
            rtbDisplay.Name = "rtbDisplay";
            rtbDisplay.Size = new Size(297, 263);
            rtbDisplay.TabIndex = 0;
            rtbDisplay.Text = "";
            // 
            // lbDisplay
            // 
            lbDisplay.AutoSize = true;
            lbDisplay.Location = new Point(14, 219);
            lbDisplay.Name = "lbDisplay";
            lbDisplay.Size = new Size(179, 20);
            lbDisplay.TabIndex = 1;
            lbDisplay.Text = "Wynik dziłania  programu";
            // 
            // btRun
            // 
            btRun.Location = new Point(12, 532);
            btRun.Margin = new Padding(3, 4, 3, 4);
            btRun.Name = "btRun";
            btRun.Size = new Size(86, 31);
            btRun.TabIndex = 2;
            btRun.Text = "Testuj";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += btRun_Click;
            // 
            // btAddTree
            // 
            btAddTree.Location = new Point(694, 78);
            btAddTree.Name = "btAddTree";
            btAddTree.Size = new Size(111, 31);
            btAddTree.TabIndex = 3;
            btAddTree.Text = "Nowe drzewo";
            btAddTree.UseVisualStyleBackColor = true;
            btAddTree.Click += btAddTree_Click;
            // 
            // lbAddTree
            // 
            lbAddTree.AutoSize = true;
            lbAddTree.Location = new Point(694, 13);
            lbAddTree.Name = "lbAddTree";
            lbAddTree.Size = new Size(147, 20);
            lbAddTree.TabIndex = 4;
            lbAddTree.Text = "Wpisz nazwę drzewa";
            // 
            // tbAddTree
            // 
            tbAddTree.Location = new Point(694, 45);
            tbAddTree.Name = "tbAddTree";
            tbAddTree.Size = new Size(147, 27);
            tbAddTree.TabIndex = 5;
            // 
            // btDispTrees
            // 
            btDispTrees.Location = new Point(14, 13);
            btDispTrees.Name = "btDispTrees";
            btDispTrees.Size = new Size(129, 29);
            btDispTrees.TabIndex = 6;
            btDispTrees.Text = "Wyświetl drzewa";
            btDispTrees.UseVisualStyleBackColor = true;
            btDispTrees.Click += btDispTrees_Click;
            // 
            // cbChooseTree
            // 
            cbChooseTree.FormattingEnabled = true;
            cbChooseTree.Location = new Point(694, 211);
            cbChooseTree.Name = "cbChooseTree";
            cbChooseTree.Size = new Size(208, 28);
            cbChooseTree.TabIndex = 7;
            // 
            // lbChooseTree
            // 
            lbChooseTree.AutoSize = true;
            lbChooseTree.Location = new Point(694, 188);
            lbChooseTree.Name = "lbChooseTree";
            lbChooseTree.Size = new Size(181, 20);
            lbChooseTree.TabIndex = 8;
            lbChooseTree.Text = "Wybierz drzewo do edycji";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lbChooseTree);
            Controls.Add(cbChooseTree);
            Controls.Add(btDispTrees);
            Controls.Add(tbAddTree);
            Controls.Add(lbAddTree);
            Controls.Add(btAddTree);
            Controls.Add(btRun);
            Controls.Add(lbDisplay);
            Controls.Add(rtbDisplay);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbDisplay;
        private Label lbDisplay;
        private Button btRun;
        private Button btAddTree;
        private Label lbAddTree;
        private TextBox tbAddTree;
        private Button btDispTrees;
        private ComboBox cbChooseTree;
        private Label lbChooseTree;
    }
}
