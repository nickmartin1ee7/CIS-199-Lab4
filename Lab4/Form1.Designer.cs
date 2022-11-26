namespace Lab4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.submitButton = new System.Windows.Forms.Button();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.gpaTextBox = new System.Windows.Forms.TextBox();
            this.admissionBannerPictureBox = new System.Windows.Forms.PictureBox();
            this.testScoreLabel = new System.Windows.Forms.Label();
            this.testScoreTextBox = new System.Windows.Forms.TextBox();
            this.acceptPictureBox = new System.Windows.Forms.PictureBox();
            this.rejectPictureBox = new System.Windows.Forms.PictureBox();
            this.acceptCountLabel = new System.Windows.Forms.Label();
            this.rejectCountLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.iconCreditLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.admissionBannerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rejectPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.submitButton.Location = new System.Drawing.Point(248, 198);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(146, 123);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(32, 13);
            this.gpaLabel.TabIndex = 1;
            this.gpaLabel.Text = "GPA:";
            // 
            // gpaTextBox
            // 
            this.gpaTextBox.Location = new System.Drawing.Point(184, 120);
            this.gpaTextBox.Name = "gpaTextBox";
            this.gpaTextBox.Size = new System.Drawing.Size(100, 20);
            this.gpaTextBox.TabIndex = 0;
            // 
            // admissionBannerPictureBox
            // 
            this.admissionBannerPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(176)))), ((int)(((byte)(244)))));
            this.admissionBannerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.admissionBannerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("admissionBannerPictureBox.Image")));
            this.admissionBannerPictureBox.Location = new System.Drawing.Point(9, 9);
            this.admissionBannerPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.admissionBannerPictureBox.Name = "admissionBannerPictureBox";
            this.admissionBannerPictureBox.Size = new System.Drawing.Size(451, 72);
            this.admissionBannerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.admissionBannerPictureBox.TabIndex = 3;
            this.admissionBannerPictureBox.TabStop = false;
            // 
            // testScoreLabel
            // 
            this.testScoreLabel.AutoSize = true;
            this.testScoreLabel.Location = new System.Drawing.Point(118, 162);
            this.testScoreLabel.Name = "testScoreLabel";
            this.testScoreLabel.Size = new System.Drawing.Size(60, 13);
            this.testScoreLabel.TabIndex = 4;
            this.testScoreLabel.Text = "Test score:";
            // 
            // testScoreTextBox
            // 
            this.testScoreTextBox.Location = new System.Drawing.Point(184, 159);
            this.testScoreTextBox.Name = "testScoreTextBox";
            this.testScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.testScoreTextBox.TabIndex = 1;
            // 
            // acceptPictureBox
            // 
            this.acceptPictureBox.BackColor = System.Drawing.Color.Green;
            this.acceptPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.acceptPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acceptPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("acceptPictureBox.Image")));
            this.acceptPictureBox.Location = new System.Drawing.Point(9, 101);
            this.acceptPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.acceptPictureBox.Name = "acceptPictureBox";
            this.acceptPictureBox.Size = new System.Drawing.Size(100, 100);
            this.acceptPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.acceptPictureBox.TabIndex = 6;
            this.acceptPictureBox.TabStop = false;
            // 
            // rejectPictureBox
            // 
            this.rejectPictureBox.BackColor = System.Drawing.Color.Red;
            this.rejectPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rejectPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rejectPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("rejectPictureBox.Image")));
            this.rejectPictureBox.Location = new System.Drawing.Point(360, 101);
            this.rejectPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.rejectPictureBox.Name = "rejectPictureBox";
            this.rejectPictureBox.Size = new System.Drawing.Size(100, 100);
            this.rejectPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rejectPictureBox.TabIndex = 7;
            this.rejectPictureBox.TabStop = false;
            // 
            // acceptCountLabel
            // 
            this.acceptCountLabel.AutoEllipsis = true;
            this.acceptCountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptCountLabel.Location = new System.Drawing.Point(12, 233);
            this.acceptCountLabel.Name = "acceptCountLabel";
            this.acceptCountLabel.Size = new System.Drawing.Size(97, 25);
            this.acceptCountLabel.TabIndex = 8;
            this.acceptCountLabel.Text = "0";
            this.acceptCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rejectCountLabel
            // 
            this.rejectCountLabel.AutoEllipsis = true;
            this.rejectCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.rejectCountLabel.Location = new System.Drawing.Point(360, 233);
            this.rejectCountLabel.Name = "rejectCountLabel";
            this.rejectCountLabel.Size = new System.Drawing.Size(97, 25);
            this.rejectCountLabel.TabIndex = 9;
            this.rejectCountLabel.Text = "0";
            this.rejectCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(127, 233);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(215, 25);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(146, 198);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // iconCreditLinkLabel
            // 
            this.iconCreditLinkLabel.AutoSize = true;
            this.iconCreditLinkLabel.Location = new System.Drawing.Point(177, 265);
            this.iconCreditLinkLabel.Name = "iconCreditLinkLabel";
            this.iconCreditLinkLabel.Size = new System.Drawing.Size(115, 13);
            this.iconCreditLinkLabel.TabIndex = 11;
            this.iconCreditLinkLabel.TabStop = true;
            this.iconCreditLinkLabel.Text = "Icon credit: Smashicon";
            this.iconCreditLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.iconCreditLinkLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(469, 281);
            this.Controls.Add(this.iconCreditLinkLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.rejectCountLabel);
            this.Controls.Add(this.acceptCountLabel);
            this.Controls.Add(this.rejectPictureBox);
            this.Controls.Add(this.acceptPictureBox);
            this.Controls.Add(this.testScoreTextBox);
            this.Controls.Add(this.testScoreLabel);
            this.Controls.Add(this.admissionBannerPictureBox);
            this.Controls.Add(this.gpaTextBox);
            this.Controls.Add(this.gpaLabel);
            this.Controls.Add(this.submitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lab 4";
            ((System.ComponentModel.ISupportInitialize)(this.admissionBannerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rejectPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.TextBox gpaTextBox;
        private System.Windows.Forms.PictureBox admissionBannerPictureBox;
        private System.Windows.Forms.Label testScoreLabel;
        private System.Windows.Forms.TextBox testScoreTextBox;
        private System.Windows.Forms.PictureBox acceptPictureBox;
        private System.Windows.Forms.PictureBox rejectPictureBox;
        private System.Windows.Forms.Label acceptCountLabel;
        private System.Windows.Forms.Label rejectCountLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.LinkLabel iconCreditLinkLabel;
    }
}

