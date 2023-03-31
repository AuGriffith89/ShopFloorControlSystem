namespace ControlUserInterface
{
    partial class MainSelectionForm
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
            freeFormButton = new Button();
            userSettingsButton = new Button();
            applicationSettingsButton = new Button();
            SuspendLayout();
            // 
            // freeFormButton
            // 
            freeFormButton.FlatAppearance.BorderColor = Color.Silver;
            freeFormButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            freeFormButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            freeFormButton.FlatStyle = FlatStyle.Flat;
            freeFormButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            freeFormButton.ForeColor = SystemColors.MenuHighlight;
            freeFormButton.Location = new Point(69, 53);
            freeFormButton.Name = "freeFormButton";
            freeFormButton.Size = new Size(304, 70);
            freeFormButton.TabIndex = 0;
            freeFormButton.Text = "Free Form";
            freeFormButton.UseVisualStyleBackColor = true;
            // 
            // userSettingsButton
            // 
            userSettingsButton.FlatAppearance.BorderColor = Color.Silver;
            userSettingsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            userSettingsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            userSettingsButton.FlatStyle = FlatStyle.Flat;
            userSettingsButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            userSettingsButton.ForeColor = SystemColors.MenuHighlight;
            userSettingsButton.Location = new Point(69, 183);
            userSettingsButton.Name = "userSettingsButton";
            userSettingsButton.Size = new Size(304, 70);
            userSettingsButton.TabIndex = 1;
            userSettingsButton.Text = "User Settings";
            userSettingsButton.UseVisualStyleBackColor = true;
            // 
            // applicationSettingsButton
            // 
            applicationSettingsButton.FlatAppearance.BorderColor = Color.Silver;
            applicationSettingsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            applicationSettingsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            applicationSettingsButton.FlatStyle = FlatStyle.Flat;
            applicationSettingsButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            applicationSettingsButton.ForeColor = SystemColors.MenuHighlight;
            applicationSettingsButton.Location = new Point(69, 313);
            applicationSettingsButton.Name = "applicationSettingsButton";
            applicationSettingsButton.Size = new Size(304, 70);
            applicationSettingsButton.TabIndex = 2;
            applicationSettingsButton.Text = "Application Settings";
            applicationSettingsButton.UseVisualStyleBackColor = true;
            // 
            // MainSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(443, 453);
            Controls.Add(applicationSettingsButton);
            Controls.Add(userSettingsButton);
            Controls.Add(freeFormButton);
            Name = "MainSelectionForm";
            Text = "Main Selection";
            ResumeLayout(false);
        }

        #endregion

        private Button freeFormButton;
        private Button userSettingsButton;
        private Button applicationSettingsButton;
    }
}