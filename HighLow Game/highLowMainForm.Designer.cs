namespace HighLow_Game
{
    partial class highLowMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(highLowMainForm));
            this.rollButton = new System.Windows.Forms.Button();
            this.powerLabel = new System.Windows.Forms.Label();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.playerRoll1TextBox = new System.Windows.Forms.TextBox();
            this.enemyRoll1TextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.playerRoll2TextBox = new System.Windows.Forms.TextBox();
            this.enemyRoll2TextBox = new System.Windows.Forms.TextBox();
            this.playerRollTotalTextBox = new System.Windows.Forms.TextBox();
            this.enemyRollTotalTextBox = new System.Windows.Forms.TextBox();
            this.playerHealth = new System.Windows.Forms.ProgressBar();
            this.actionListBox = new System.Windows.Forms.ListBox();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.enemyHealth = new System.Windows.Forms.ProgressBar();
            this.enemyNameLabel = new System.Windows.Forms.Label();
            this.enemyHealthLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.outputTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rollButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rollButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.rollButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rollButton.Location = new System.Drawing.Point(172, 119);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(77, 25);
            this.rollButton.TabIndex = 23;
            this.rollButton.Text = "Go!";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.powerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.powerLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.powerLabel.Location = new System.Drawing.Point(153, 86);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(59, 16);
            this.powerLabel.TabIndex = 5;
            this.powerLabel.Text = "Power:";
            // 
            // powerTextBox
            // 
            this.powerTextBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.powerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerTextBox.Location = new System.Drawing.Point(218, 82);
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.Size = new System.Drawing.Size(50, 22);
            this.powerTextBox.TabIndex = 6;
            this.powerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerRoll1TextBox
            // 
            this.playerRoll1TextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.playerRoll1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerRoll1TextBox.Location = new System.Drawing.Point(58, 80);
            this.playerRoll1TextBox.Name = "playerRoll1TextBox";
            this.playerRoll1TextBox.ReadOnly = true;
            this.playerRoll1TextBox.Size = new System.Drawing.Size(22, 20);
            this.playerRoll1TextBox.TabIndex = 12;
            this.playerRoll1TextBox.TabStop = false;
            this.playerRoll1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enemyRoll1TextBox
            // 
            this.enemyRoll1TextBox.BackColor = System.Drawing.Color.IndianRed;
            this.enemyRoll1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyRoll1TextBox.Location = new System.Drawing.Point(336, 80);
            this.enemyRoll1TextBox.Name = "enemyRoll1TextBox";
            this.enemyRoll1TextBox.ReadOnly = true;
            this.enemyRoll1TextBox.Size = new System.Drawing.Size(22, 20);
            this.enemyRoll1TextBox.TabIndex = 13;
            this.enemyRoll1TextBox.TabStop = false;
            this.enemyRoll1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.DarkKhaki;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(51, 166);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Padding = new System.Windows.Forms.Padding(25, 11, 25, 0);
            this.outputLabel.Size = new System.Drawing.Size(318, 69);
            this.outputLabel.TabIndex = 14;
            this.outputLabel.Text = "(output)";
            // 
            // playerRoll2TextBox
            // 
            this.playerRoll2TextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.playerRoll2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerRoll2TextBox.Location = new System.Drawing.Point(58, 106);
            this.playerRoll2TextBox.Name = "playerRoll2TextBox";
            this.playerRoll2TextBox.ReadOnly = true;
            this.playerRoll2TextBox.Size = new System.Drawing.Size(22, 20);
            this.playerRoll2TextBox.TabIndex = 15;
            this.playerRoll2TextBox.TabStop = false;
            this.playerRoll2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enemyRoll2TextBox
            // 
            this.enemyRoll2TextBox.BackColor = System.Drawing.Color.IndianRed;
            this.enemyRoll2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyRoll2TextBox.Location = new System.Drawing.Point(336, 106);
            this.enemyRoll2TextBox.Name = "enemyRoll2TextBox";
            this.enemyRoll2TextBox.ReadOnly = true;
            this.enemyRoll2TextBox.Size = new System.Drawing.Size(22, 20);
            this.enemyRoll2TextBox.TabIndex = 16;
            this.enemyRoll2TextBox.TabStop = false;
            this.enemyRoll2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerRollTotalTextBox
            // 
            this.playerRollTotalTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.playerRollTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerRollTotalTextBox.Location = new System.Drawing.Point(51, 134);
            this.playerRollTotalTextBox.Name = "playerRollTotalTextBox";
            this.playerRollTotalTextBox.ReadOnly = true;
            this.playerRollTotalTextBox.Size = new System.Drawing.Size(36, 22);
            this.playerRollTotalTextBox.TabIndex = 17;
            this.playerRollTotalTextBox.TabStop = false;
            this.playerRollTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enemyRollTotalTextBox
            // 
            this.enemyRollTotalTextBox.BackColor = System.Drawing.Color.IndianRed;
            this.enemyRollTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyRollTotalTextBox.Location = new System.Drawing.Point(329, 134);
            this.enemyRollTotalTextBox.Name = "enemyRollTotalTextBox";
            this.enemyRollTotalTextBox.ReadOnly = true;
            this.enemyRollTotalTextBox.Size = new System.Drawing.Size(36, 22);
            this.enemyRollTotalTextBox.TabIndex = 18;
            this.enemyRollTotalTextBox.TabStop = false;
            this.enemyRollTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerHealth
            // 
            this.playerHealth.BackColor = System.Drawing.SystemColors.Control;
            this.playerHealth.Location = new System.Drawing.Point(20, 28);
            this.playerHealth.Name = "playerHealth";
            this.playerHealth.Size = new System.Drawing.Size(121, 23);
            this.playerHealth.Step = -10;
            this.playerHealth.TabIndex = 20;
            this.playerHealth.Value = 100;
            // 
            // actionListBox
            // 
            this.actionListBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.actionListBox.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionListBox.FormattingEnabled = true;
            this.actionListBox.ItemHeight = 15;
            this.actionListBox.Items.AddRange(new object[] {
            "Attack",
            "Critical",
            "Heal"});
            this.actionListBox.Location = new System.Drawing.Point(172, 13);
            this.actionListBox.Name = "actionListBox";
            this.actionListBox.Size = new System.Drawing.Size(77, 49);
            this.actionListBox.TabIndex = 2;
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerHealthLabel.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHealthLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.playerHealthLabel.Location = new System.Drawing.Point(79, 13);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerHealthLabel.Size = new System.Drawing.Size(62, 13);
            this.playerHealthLabel.TabIndex = 21;
            this.playerHealthLabel.Text = "100 HP";
            this.playerHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerNameLabel.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.Location = new System.Drawing.Point(19, 13);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerNameLabel.Size = new System.Drawing.Size(67, 15);
            this.playerNameLabel.TabIndex = 24;
            this.playerNameLabel.Text = "(Player):";
            this.playerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // enemyHealth
            // 
            this.enemyHealth.BackColor = System.Drawing.SystemColors.Control;
            this.enemyHealth.Location = new System.Drawing.Point(287, 28);
            this.enemyHealth.Name = "enemyHealth";
            this.enemyHealth.Size = new System.Drawing.Size(121, 23);
            this.enemyHealth.Step = -10;
            this.enemyHealth.TabIndex = 25;
            this.enemyHealth.Value = 100;
            // 
            // enemyNameLabel
            // 
            this.enemyNameLabel.AutoSize = true;
            this.enemyNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.enemyNameLabel.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyNameLabel.Location = new System.Drawing.Point(286, 12);
            this.enemyNameLabel.Name = "enemyNameLabel";
            this.enemyNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enemyNameLabel.Size = new System.Drawing.Size(57, 15);
            this.enemyNameLabel.TabIndex = 27;
            this.enemyNameLabel.Text = "Enemy:";
            this.enemyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // enemyHealthLabel
            // 
            this.enemyHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.enemyHealthLabel.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyHealthLabel.Location = new System.Drawing.Point(337, 13);
            this.enemyHealthLabel.Name = "enemyHealthLabel";
            this.enemyHealthLabel.Size = new System.Drawing.Size(68, 13);
            this.enemyHealthLabel.TabIndex = 26;
            this.enemyHealthLabel.Text = "***HP";
            this.enemyHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roundLabel
            // 
            this.roundLabel.BackColor = System.Drawing.Color.DarkKhaki;
            this.roundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundLabel.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.Location = new System.Drawing.Point(249, 220);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.roundLabel.Size = new System.Drawing.Size(93, 15);
            this.roundLabel.TabIndex = 28;
            this.roundLabel.Text = "Round 1";
            this.roundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputTimer
            // 
            this.outputTimer.Interval = 10;
            this.outputTimer.Tick += new System.EventHandler(this.outputTimer_Tick);
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.backgroundPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("backgroundPictureBox.Image")));
            this.backgroundPictureBox.Location = new System.Drawing.Point(-1, -4);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(424, 252);
            this.backgroundPictureBox.TabIndex = 29;
            this.backgroundPictureBox.TabStop = false;
            // 
            // highLowMainForm
            // 
            this.AcceptButton = this.rollButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(423, 246);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.enemyNameLabel);
            this.Controls.Add(this.enemyHealthLabel);
            this.Controls.Add(this.enemyHealth);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.actionListBox);
            this.Controls.Add(this.playerHealthLabel);
            this.Controls.Add(this.playerHealth);
            this.Controls.Add(this.enemyRollTotalTextBox);
            this.Controls.Add(this.playerRollTotalTextBox);
            this.Controls.Add(this.enemyRoll2TextBox);
            this.Controls.Add(this.playerRoll2TextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.enemyRoll1TextBox);
            this.Controls.Add(this.playerRoll1TextBox);
            this.Controls.Add(this.powerTextBox);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.backgroundPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "highLowMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "High Low RPG";
            this.Load += new System.EventHandler(this.highLowMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.TextBox powerTextBox;
        private System.Windows.Forms.TextBox playerRoll1TextBox;
        private System.Windows.Forms.TextBox enemyRoll1TextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox playerRoll2TextBox;
        private System.Windows.Forms.TextBox enemyRoll2TextBox;
        private System.Windows.Forms.TextBox playerRollTotalTextBox;
        private System.Windows.Forms.TextBox enemyRollTotalTextBox;
        private System.Windows.Forms.ProgressBar playerHealth;
        private System.Windows.Forms.ListBox actionListBox;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.ProgressBar enemyHealth;
        private System.Windows.Forms.Label enemyNameLabel;
        private System.Windows.Forms.Label enemyHealthLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Timer outputTimer;
        private System.Windows.Forms.PictureBox backgroundPictureBox;
    }
}

