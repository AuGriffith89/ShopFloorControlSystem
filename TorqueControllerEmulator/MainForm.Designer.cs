namespace TorqueControllerEmulator
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
            connectionSettingsGroupBox = new GroupBox();
            ipAddressLabel = new Label();
            ipAddressValue = new TextBox();
            portNumberValue = new TextBox();
            portNumberLabel = new Label();
            connectButton = new Button();
            torqueValueGroupBox = new GroupBox();
            angleValue = new TextBox();
            angleLabel = new Label();
            torqueValue = new TextBox();
            torqueLabel = new Label();
            modeSelectionGroupBox = new GroupBox();
            torqueCheckBox = new CheckBox();
            angleCheckBox = new CheckBox();
            sendButton = new Button();
            userMessageListBox = new ListBox();
            connectionSettingsGroupBox.SuspendLayout();
            torqueValueGroupBox.SuspendLayout();
            modeSelectionGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // connectionSettingsGroupBox
            // 
            connectionSettingsGroupBox.Controls.Add(connectButton);
            connectionSettingsGroupBox.Controls.Add(portNumberValue);
            connectionSettingsGroupBox.Controls.Add(portNumberLabel);
            connectionSettingsGroupBox.Controls.Add(ipAddressValue);
            connectionSettingsGroupBox.Controls.Add(ipAddressLabel);
            connectionSettingsGroupBox.Location = new Point(12, 12);
            connectionSettingsGroupBox.Name = "connectionSettingsGroupBox";
            connectionSettingsGroupBox.Size = new Size(350, 186);
            connectionSettingsGroupBox.TabIndex = 0;
            connectionSettingsGroupBox.TabStop = false;
            // 
            // ipAddressLabel
            // 
            ipAddressLabel.AutoSize = true;
            ipAddressLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipAddressLabel.Location = new Point(6, 19);
            ipAddressLabel.Name = "ipAddressLabel";
            ipAddressLabel.Size = new Size(116, 30);
            ipAddressLabel.TabIndex = 0;
            ipAddressLabel.Text = "IP Address:";
            // 
            // ipAddressValue
            // 
            ipAddressValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipAddressValue.Location = new Point(149, 16);
            ipAddressValue.Name = "ipAddressValue";
            ipAddressValue.Size = new Size(177, 35);
            ipAddressValue.TabIndex = 1;
            // 
            // portNumberValue
            // 
            portNumberValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            portNumberValue.Location = new Point(149, 66);
            portNumberValue.Name = "portNumberValue";
            portNumberValue.Size = new Size(177, 35);
            portNumberValue.TabIndex = 3;
            // 
            // portNumberLabel
            // 
            portNumberLabel.AutoSize = true;
            portNumberLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            portNumberLabel.Location = new Point(6, 69);
            portNumberLabel.Name = "portNumberLabel";
            portNumberLabel.Size = new Size(137, 30);
            portNumberLabel.TabIndex = 2;
            portNumberLabel.Text = "Port Number:";
            // 
            // connectButton
            // 
            connectButton.FlatAppearance.BorderColor = Color.Silver;
            connectButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            connectButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            connectButton.FlatStyle = FlatStyle.Flat;
            connectButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            connectButton.ForeColor = SystemColors.MenuHighlight;
            connectButton.Location = new Point(149, 119);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(177, 47);
            connectButton.TabIndex = 11;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // torqueValueGroupBox
            // 
            torqueValueGroupBox.Controls.Add(sendButton);
            torqueValueGroupBox.Controls.Add(modeSelectionGroupBox);
            torqueValueGroupBox.Controls.Add(angleValue);
            torqueValueGroupBox.Controls.Add(angleLabel);
            torqueValueGroupBox.Controls.Add(torqueValue);
            torqueValueGroupBox.Controls.Add(torqueLabel);
            torqueValueGroupBox.Location = new Point(12, 217);
            torqueValueGroupBox.Name = "torqueValueGroupBox";
            torqueValueGroupBox.Size = new Size(428, 205);
            torqueValueGroupBox.TabIndex = 1;
            torqueValueGroupBox.TabStop = false;
            // 
            // angleValue
            // 
            angleValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            angleValue.Location = new Point(93, 66);
            angleValue.Name = "angleValue";
            angleValue.Size = new Size(177, 35);
            angleValue.TabIndex = 7;
            // 
            // angleLabel
            // 
            angleLabel.AutoSize = true;
            angleLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            angleLabel.Location = new Point(6, 71);
            angleLabel.Name = "angleLabel";
            angleLabel.Size = new Size(72, 30);
            angleLabel.TabIndex = 6;
            angleLabel.Text = "Angle:";
            // 
            // torqueValue
            // 
            torqueValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            torqueValue.Location = new Point(93, 16);
            torqueValue.Name = "torqueValue";
            torqueValue.Size = new Size(177, 35);
            torqueValue.TabIndex = 5;
            // 
            // torqueLabel
            // 
            torqueLabel.AutoSize = true;
            torqueLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            torqueLabel.Location = new Point(6, 19);
            torqueLabel.Name = "torqueLabel";
            torqueLabel.Size = new Size(81, 30);
            torqueLabel.TabIndex = 4;
            torqueLabel.Text = "Torque:";
            // 
            // modeSelectionGroupBox
            // 
            modeSelectionGroupBox.Controls.Add(angleCheckBox);
            modeSelectionGroupBox.Controls.Add(torqueCheckBox);
            modeSelectionGroupBox.Location = new Point(293, 19);
            modeSelectionGroupBox.Name = "modeSelectionGroupBox";
            modeSelectionGroupBox.Size = new Size(108, 82);
            modeSelectionGroupBox.TabIndex = 8;
            modeSelectionGroupBox.TabStop = false;
            modeSelectionGroupBox.Text = "Mode Selection";
            // 
            // torqueCheckBox
            // 
            torqueCheckBox.AutoSize = true;
            torqueCheckBox.Location = new Point(6, 22);
            torqueCheckBox.Name = "torqueCheckBox";
            torqueCheckBox.Size = new Size(62, 19);
            torqueCheckBox.TabIndex = 0;
            torqueCheckBox.Text = "Torque";
            torqueCheckBox.UseVisualStyleBackColor = true;
            // 
            // angleCheckBox
            // 
            angleCheckBox.AutoSize = true;
            angleCheckBox.Location = new Point(6, 52);
            angleCheckBox.Name = "angleCheckBox";
            angleCheckBox.Size = new Size(57, 19);
            angleCheckBox.TabIndex = 1;
            angleCheckBox.Text = "Angle";
            angleCheckBox.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            sendButton.FlatAppearance.BorderColor = Color.Silver;
            sendButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            sendButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            sendButton.FlatStyle = FlatStyle.Flat;
            sendButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            sendButton.ForeColor = SystemColors.MenuHighlight;
            sendButton.Location = new Point(93, 131);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(177, 47);
            sendButton.TabIndex = 12;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // userMessageListBox
            // 
            userMessageListBox.FormattingEnabled = true;
            userMessageListBox.ItemHeight = 15;
            userMessageListBox.Location = new Point(12, 450);
            userMessageListBox.Name = "userMessageListBox";
            userMessageListBox.SelectionMode = SelectionMode.None;
            userMessageListBox.Size = new Size(641, 154);
            userMessageListBox.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(678, 635);
            Controls.Add(userMessageListBox);
            Controls.Add(torqueValueGroupBox);
            Controls.Add(connectionSettingsGroupBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Torque Controller Emulator";
            connectionSettingsGroupBox.ResumeLayout(false);
            connectionSettingsGroupBox.PerformLayout();
            torqueValueGroupBox.ResumeLayout(false);
            torqueValueGroupBox.PerformLayout();
            modeSelectionGroupBox.ResumeLayout(false);
            modeSelectionGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox connectionSettingsGroupBox;
        private TextBox portNumberValue;
        private Label portNumberLabel;
        private TextBox ipAddressValue;
        private Label ipAddressLabel;
        private Button connectButton;
        private GroupBox torqueValueGroupBox;
        private Button sendButton;
        private GroupBox modeSelectionGroupBox;
        private CheckBox angleCheckBox;
        private CheckBox torqueCheckBox;
        private TextBox angleValue;
        private Label angleLabel;
        private TextBox torqueValue;
        private Label torqueLabel;
        private ListBox userMessageListBox;
    }
}