namespace Segundo_CoinsActivity
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
            menuStrip1 = new MenuStrip();
            menuItem = new ToolStripMenuItem();
            loadImageToolStripMenuItem = new ToolStripMenuItem();
            coinsPB = new PictureBox();
            calculateBtn = new Button();
            outLabel = new Label();
            coinsTextBox = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coinsPB).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuItem
            // 
            menuItem.DropDownItems.AddRange(new ToolStripItem[] { loadImageToolStripMenuItem });
            menuItem.Name = "menuItem";
            menuItem.Size = new Size(59, 24);
            menuItem.Text = "Open";
            menuItem.Click += menuItem_Click;
            // 
            // loadImageToolStripMenuItem
            // 
            loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            loadImageToolStripMenuItem.Size = new Size(171, 26);
            loadImageToolStripMenuItem.Text = "Load Image";
            // 
            // coinsPB
            // 
            coinsPB.Location = new Point(84, 48);
            coinsPB.Name = "coinsPB";
            coinsPB.Size = new Size(291, 322);
            coinsPB.SizeMode = PictureBoxSizeMode.StretchImage;
            coinsPB.TabIndex = 1;
            coinsPB.TabStop = false;
            // 
            // calculateBtn
            // 
            calculateBtn.Location = new Point(84, 381);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(291, 46);
            calculateBtn.TabIndex = 2;
            calculateBtn.Text = "Calculate";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_click;
            // 
            // outLabel
            // 
            outLabel.Font = new Font("Segoe UI", 14F);
            outLabel.Location = new Point(413, 79);
            outLabel.Name = "outLabel";
            outLabel.Size = new Size(324, 52);
            outLabel.TabIndex = 3;
            outLabel.Text = "Total Value:";
            outLabel.Click += outputLabel_Click;
            // 
            // coinsTextBox
            // 
            coinsTextBox.Location = new Point(413, 143);
            coinsTextBox.MaximumSize = new Size(0, 200);
            coinsTextBox.Multiline = true;
            coinsTextBox.Name = "coinsTextBox";
            coinsTextBox.Size = new Size(324, 159);
            coinsTextBox.TabIndex = 4;
            coinsTextBox.TextChanged += textBox1_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(coinsTextBox);
            Controls.Add(outLabel);
            Controls.Add(calculateBtn);
            Controls.Add(coinsPB);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coinsPB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuItem;
        private PictureBox coinsPB;
        private ToolStripMenuItem loadImageToolStripMenuItem;
        private Button calculateBtn;
        private Label outLabel;
        private TextBox coinsTextBox;
        private OpenFileDialog openFileDialog1;
        //private TextBox coinsTextBox;
        //private OpenFileDialog openFileDialog1;

    }
}
