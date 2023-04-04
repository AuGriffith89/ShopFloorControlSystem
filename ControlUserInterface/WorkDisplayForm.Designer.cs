namespace ControlUserInterface
{
    partial class WorkDisplayForm
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
            jobNameLabel = new Label();
            parameterNameLabel = new Label();
            measurementValueLabel = new Label();
            unitsLabel = new Label();
            userDisplayNameLabel = new Label();
            userMessageListBox = new ListBox();
            batchCountLabel = new Label();
            batchSeparatorLabel = new Label();
            batchTotalLabel = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // jobNameLabel
            // 
            jobNameLabel.AutoSize = true;
            jobNameLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            jobNameLabel.ForeColor = SystemColors.MenuHighlight;
            jobNameLabel.Location = new Point(12, 9);
            jobNameLabel.Name = "jobNameLabel";
            jobNameLabel.Size = new Size(186, 40);
            jobNameLabel.TabIndex = 1;
            jobNameLabel.Text = "<Job Name>";
            // 
            // parameterNameLabel
            // 
            parameterNameLabel.AutoSize = true;
            parameterNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            parameterNameLabel.ForeColor = SystemColors.MenuHighlight;
            parameterNameLabel.Location = new Point(38, 65);
            parameterNameLabel.Name = "parameterNameLabel";
            parameterNameLabel.Size = new Size(251, 37);
            parameterNameLabel.TabIndex = 2;
            parameterNameLabel.Text = "<Parameter Name>";
            // 
            // measurementValueLabel
            // 
            measurementValueLabel.Font = new Font("Segoe UI", 125.25F, FontStyle.Regular, GraphicsUnit.Point);
            measurementValueLabel.ForeColor = SystemColors.MenuHighlight;
            measurementValueLabel.Location = new Point(83, 140);
            measurementValueLabel.Name = "measurementValueLabel";
            measurementValueLabel.Size = new Size(489, 221);
            measurementValueLabel.TabIndex = 3;
            measurementValueLabel.Text = "88.88";
            measurementValueLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // unitsLabel
            // 
            unitsLabel.AutoSize = true;
            unitsLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            unitsLabel.ForeColor = SystemColors.MenuHighlight;
            unitsLabel.Location = new Point(578, 287);
            unitsLabel.Name = "unitsLabel";
            unitsLabel.Size = new Size(64, 40);
            unitsLabel.TabIndex = 4;
            unitsLabel.Text = "Nm";
            // 
            // userDisplayNameLabel
            // 
            userDisplayNameLabel.AutoSize = true;
            userDisplayNameLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            userDisplayNameLabel.ForeColor = SystemColors.MenuHighlight;
            userDisplayNameLabel.Location = new Point(685, 9);
            userDisplayNameLabel.Name = "userDisplayNameLabel";
            userDisplayNameLabel.Size = new Size(299, 40);
            userDisplayNameLabel.TabIndex = 5;
            userDisplayNameLabel.Text = "<User Display Name>";
            // 
            // userMessageListBox
            // 
            userMessageListBox.FormattingEnabled = true;
            userMessageListBox.ItemHeight = 15;
            userMessageListBox.Location = new Point(38, 457);
            userMessageListBox.Name = "userMessageListBox";
            userMessageListBox.SelectionMode = SelectionMode.None;
            userMessageListBox.Size = new Size(946, 154);
            userMessageListBox.TabIndex = 6;
            // 
            // batchCountLabel
            // 
            batchCountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            batchCountLabel.ForeColor = SystemColors.MenuHighlight;
            batchCountLabel.Location = new Point(83, 390);
            batchCountLabel.Name = "batchCountLabel";
            batchCountLabel.Size = new Size(77, 37);
            batchCountLabel.TabIndex = 7;
            batchCountLabel.Text = "9999";
            batchCountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // batchSeparatorLabel
            // 
            batchSeparatorLabel.AutoSize = true;
            batchSeparatorLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            batchSeparatorLabel.ForeColor = SystemColors.MenuHighlight;
            batchSeparatorLabel.Location = new Point(166, 390);
            batchSeparatorLabel.Name = "batchSeparatorLabel";
            batchSeparatorLabel.Size = new Size(23, 37);
            batchSeparatorLabel.TabIndex = 8;
            batchSeparatorLabel.Text = ":";
            // 
            // batchTotalLabel
            // 
            batchTotalLabel.AutoSize = true;
            batchTotalLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            batchTotalLabel.ForeColor = SystemColors.MenuHighlight;
            batchTotalLabel.Location = new Point(195, 390);
            batchTotalLabel.Name = "batchTotalLabel";
            batchTotalLabel.Size = new Size(77, 37);
            batchTotalLabel.TabIndex = 9;
            batchTotalLabel.Text = "9999";
            // 
            // exitButton
            // 
            exitButton.FlatAppearance.BorderColor = Color.Silver;
            exitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            exitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = SystemColors.MenuHighlight;
            exitButton.Location = new Point(796, 357);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(188, 70);
            exitButton.TabIndex = 10;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // WorkDisplayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1022, 648);
            Controls.Add(exitButton);
            Controls.Add(batchTotalLabel);
            Controls.Add(batchSeparatorLabel);
            Controls.Add(batchCountLabel);
            Controls.Add(userMessageListBox);
            Controls.Add(userDisplayNameLabel);
            Controls.Add(unitsLabel);
            Controls.Add(measurementValueLabel);
            Controls.Add(parameterNameLabel);
            Controls.Add(jobNameLabel);
            Name = "WorkDisplayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Work Display";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label jobNameLabel;
        private Label parameterNameLabel;
        private Label measurementValueLabel;
        private Label unitsLabel;
        private Label userDisplayNameLabel;
        private ListBox userMessageListBox;
        private Label batchCountLabel;
        private Label batchSeparatorLabel;
        private Label batchTotalLabel;
        private Button exitButton;
    }
}