namespace ControlUserInterface
{
    partial class ApplicationSettingsForm
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
            headerLabel = new Label();
            controllerIpAddressLabel = new Label();
            controllerPortNumberLabel = new Label();
            useHeartbeatCheckBox = new CheckBox();
            heartbeatIntervalLabel = new Label();
            controllerPortNumberValue = new TextBox();
            controllerIpAddressValue = new TextBox();
            heartbeatIntervalValue = new TextBox();
            updateButton = new Button();
            cancelButton = new Button();
            controllerIpAddressWarningLabel = new Label();
            controllerPortNumberWarningLabel = new Label();
            heartbeatIntervalWarningLabel = new Label();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(272, 40);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Application Settings";
            // 
            // controllerIpAddressLabel
            // 
            controllerIpAddressLabel.AutoSize = true;
            controllerIpAddressLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            controllerIpAddressLabel.ForeColor = SystemColors.MenuHighlight;
            controllerIpAddressLabel.Location = new Point(30, 70);
            controllerIpAddressLabel.Name = "controllerIpAddressLabel";
            controllerIpAddressLabel.Size = new Size(208, 30);
            controllerIpAddressLabel.TabIndex = 1;
            controllerIpAddressLabel.Text = "Controller IP Address";
            // 
            // controllerPortNumberLabel
            // 
            controllerPortNumberLabel.AutoSize = true;
            controllerPortNumberLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            controllerPortNumberLabel.ForeColor = SystemColors.MenuHighlight;
            controllerPortNumberLabel.Location = new Point(30, 140);
            controllerPortNumberLabel.Name = "controllerPortNumberLabel";
            controllerPortNumberLabel.Size = new Size(229, 30);
            controllerPortNumberLabel.TabIndex = 2;
            controllerPortNumberLabel.Text = "Controller Port Number";
            // 
            // useHeartbeatCheckBox
            // 
            useHeartbeatCheckBox.AutoSize = true;
            useHeartbeatCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            useHeartbeatCheckBox.FlatStyle = FlatStyle.Flat;
            useHeartbeatCheckBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            useHeartbeatCheckBox.ForeColor = SystemColors.MenuHighlight;
            useHeartbeatCheckBox.Location = new Point(30, 205);
            useHeartbeatCheckBox.Name = "useHeartbeatCheckBox";
            useHeartbeatCheckBox.Size = new Size(161, 34);
            useHeartbeatCheckBox.TabIndex = 2;
            useHeartbeatCheckBox.Text = "Use Heartbeat";
            useHeartbeatCheckBox.UseVisualStyleBackColor = true;
            // 
            // heartbeatIntervalLabel
            // 
            heartbeatIntervalLabel.AutoSize = true;
            heartbeatIntervalLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            heartbeatIntervalLabel.ForeColor = SystemColors.MenuHighlight;
            heartbeatIntervalLabel.Location = new Point(30, 276);
            heartbeatIntervalLabel.Name = "heartbeatIntervalLabel";
            heartbeatIntervalLabel.Size = new Size(173, 30);
            heartbeatIntervalLabel.TabIndex = 4;
            heartbeatIntervalLabel.Text = "Hearbeat Interval";
            // 
            // controllerPortNumberValue
            // 
            controllerPortNumberValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            controllerPortNumberValue.Location = new Point(265, 135);
            controllerPortNumberValue.Name = "controllerPortNumberValue";
            controllerPortNumberValue.Size = new Size(171, 35);
            controllerPortNumberValue.TabIndex = 1;
            // 
            // controllerIpAddressValue
            // 
            controllerIpAddressValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            controllerIpAddressValue.Location = new Point(265, 65);
            controllerIpAddressValue.Name = "controllerIpAddressValue";
            controllerIpAddressValue.Size = new Size(171, 35);
            controllerIpAddressValue.TabIndex = 0;
            controllerIpAddressValue.TextChanged += controllerIpAddressValue_TextChanged;
            // 
            // heartbeatIntervalValue
            // 
            heartbeatIntervalValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            heartbeatIntervalValue.Location = new Point(265, 271);
            heartbeatIntervalValue.Name = "heartbeatIntervalValue";
            heartbeatIntervalValue.Size = new Size(171, 35);
            heartbeatIntervalValue.TabIndex = 3;
            // 
            // updateButton
            // 
            updateButton.FlatAppearance.BorderColor = Color.Silver;
            updateButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            updateButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            updateButton.ForeColor = SystemColors.MenuHighlight;
            updateButton.Location = new Point(30, 370);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(188, 70);
            updateButton.TabIndex = 4;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.FlatAppearance.BorderColor = Color.Silver;
            cancelButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            cancelButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.ForeColor = SystemColors.MenuHighlight;
            cancelButton.Location = new Point(248, 370);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(188, 70);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // controllerIpAddressWarningLabel
            // 
            controllerIpAddressWarningLabel.AutoSize = true;
            controllerIpAddressWarningLabel.ForeColor = Color.Red;
            controllerIpAddressWarningLabel.Location = new Point(265, 103);
            controllerIpAddressWarningLabel.Name = "controllerIpAddressWarningLabel";
            controllerIpAddressWarningLabel.Size = new Size(0, 15);
            controllerIpAddressWarningLabel.TabIndex = 6;
            // 
            // controllerPortNumberWarningLabel
            // 
            controllerPortNumberWarningLabel.AutoSize = true;
            controllerPortNumberWarningLabel.ForeColor = Color.Red;
            controllerPortNumberWarningLabel.Location = new Point(265, 173);
            controllerPortNumberWarningLabel.Name = "controllerPortNumberWarningLabel";
            controllerPortNumberWarningLabel.Size = new Size(0, 15);
            controllerPortNumberWarningLabel.TabIndex = 7;
            // 
            // heartbeatIntervalWarningLabel
            // 
            heartbeatIntervalWarningLabel.AutoSize = true;
            heartbeatIntervalWarningLabel.ForeColor = Color.Red;
            heartbeatIntervalWarningLabel.Location = new Point(265, 309);
            heartbeatIntervalWarningLabel.Name = "heartbeatIntervalWarningLabel";
            heartbeatIntervalWarningLabel.Size = new Size(0, 15);
            heartbeatIntervalWarningLabel.TabIndex = 8;
            // 
            // ApplicationSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(486, 482);
            Controls.Add(heartbeatIntervalWarningLabel);
            Controls.Add(controllerPortNumberWarningLabel);
            Controls.Add(controllerIpAddressWarningLabel);
            Controls.Add(cancelButton);
            Controls.Add(updateButton);
            Controls.Add(heartbeatIntervalValue);
            Controls.Add(controllerIpAddressValue);
            Controls.Add(controllerPortNumberValue);
            Controls.Add(heartbeatIntervalLabel);
            Controls.Add(useHeartbeatCheckBox);
            Controls.Add(controllerPortNumberLabel);
            Controls.Add(controllerIpAddressLabel);
            Controls.Add(headerLabel);
            Name = "ApplicationSettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label controllerIpAddressLabel;
        private Label controllerPortNumberLabel;
        private CheckBox useHeartbeatCheckBox;
        private Label heartbeatIntervalLabel;
        private TextBox controllerPortNumberValue;
        private TextBox controllerIpAddressValue;
        private TextBox heartbeatIntervalValue;
        private Button updateButton;
        private Button cancelButton;
        private Label controllerIpAddressWarningLabel;
        private Label controllerPortNumberWarningLabel;
        private Label heartbeatIntervalWarningLabel;
    }
}