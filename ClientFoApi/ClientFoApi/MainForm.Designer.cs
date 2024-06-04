namespace ClientForApi
{
    partial class MainForm
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
            calculationButton = new Button();
            dividendTextBox = new TextBox();
            dividerTextBox = new TextBox();
            dividendLabel = new Label();
            dividerLabel = new Label();
            quotientTextBox = new TextBox();
            quotientLabel = new Label();
            processPictureBox = new PictureBox();
            groupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)processPictureBox).BeginInit();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // calculationButton
            // 
            calculationButton.Location = new Point(10, 289);
            calculationButton.Margin = new Padding(3, 4, 3, 4);
            calculationButton.Name = "calculationButton";
            calculationButton.Size = new Size(133, 48);
            calculationButton.TabIndex = 0;
            calculationButton.Text = "Калькулировать";
            calculationButton.UseVisualStyleBackColor = true;
            calculationButton.Click += calculationButton_Click;
            // 
            // dividendTextBox
            // 
            dividendTextBox.Anchor = AnchorStyles.Left;
            dividendTextBox.Location = new Point(10, 62);
            dividendTextBox.Name = "dividendTextBox";
            dividendTextBox.Size = new Size(132, 27);
            dividendTextBox.TabIndex = 1;
            dividendTextBox.TextChanged += TextBox_TextChanged;
            dividendTextBox.KeyPress += TextBox_KeyPress;
            // 
            // dividerTextBox
            // 
            dividerTextBox.Anchor = AnchorStyles.Left;
            dividerTextBox.Location = new Point(10, 139);
            dividerTextBox.Name = "dividerTextBox";
            dividerTextBox.Size = new Size(132, 27);
            dividerTextBox.TabIndex = 2;
            dividerTextBox.TextChanged += dividerTextBox_TextChanged;
            dividerTextBox.KeyPress += TextBox_KeyPress;
            // 
            // dividendLabel
            // 
            dividendLabel.Anchor = AnchorStyles.Left;
            dividendLabel.AutoSize = true;
            dividendLabel.Location = new Point(38, 39);
            dividendLabel.Name = "dividendLabel";
            dividendLabel.Size = new Size(72, 20);
            dividendLabel.TabIndex = 3;
            dividendLabel.Text = "Делимое";
            // 
            // dividerLabel
            // 
            dividerLabel.Anchor = AnchorStyles.Left;
            dividerLabel.AutoSize = true;
            dividerLabel.Location = new Point(38, 116);
            dividerLabel.Name = "dividerLabel";
            dividerLabel.Size = new Size(74, 20);
            dividerLabel.TabIndex = 4;
            dividerLabel.Text = "Делитель";
            // 
            // quotientTextBox
            // 
            quotientTextBox.Enabled = false;
            quotientTextBox.Location = new Point(10, 230);
            quotientTextBox.Name = "quotientTextBox";
            quotientTextBox.ReadOnly = true;
            quotientTextBox.Size = new Size(132, 27);
            quotientTextBox.TabIndex = 5;
            // 
            // quotientLabel
            // 
            quotientLabel.AutoSize = true;
            quotientLabel.Location = new Point(44, 207);
            quotientLabel.Name = "quotientLabel";
            quotientLabel.Size = new Size(66, 20);
            quotientLabel.TabIndex = 6;
            quotientLabel.Text = "Частное";
            // 
            // processPictureBox
            // 
            processPictureBox.Image = Properties.Resources.process;
            processPictureBox.Location = new Point(229, 149);
            processPictureBox.Margin = new Padding(3, 4, 3, 4);
            processPictureBox.Name = "processPictureBox";
            processPictureBox.Size = new Size(88, 88);
            processPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            processPictureBox.TabIndex = 7;
            processPictureBox.TabStop = false;
            processPictureBox.Visible = false;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(dividendLabel);
            groupBox.Controls.Add(calculationButton);
            groupBox.Controls.Add(quotientLabel);
            groupBox.Controls.Add(dividendTextBox);
            groupBox.Controls.Add(quotientTextBox);
            groupBox.Controls.Add(dividerTextBox);
            groupBox.Controls.Add(dividerLabel);
            groupBox.Location = new Point(12, 22);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(154, 358);
            groupBox.TabIndex = 8;
            groupBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 411);
            Controls.Add(groupBox);
            Controls.Add(processPictureBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор";
            ((System.ComponentModel.ISupportInitialize)processPictureBox).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button calculationButton;
        private TextBox dividendTextBox;
        private TextBox dividerTextBox;
        private Label dividendLabel;
        private Label dividerLabel;
        private TextBox quotientTextBox;
        private Label quotientLabel;
        private PictureBox processPictureBox;
        private GroupBox groupBox;
    }
}
