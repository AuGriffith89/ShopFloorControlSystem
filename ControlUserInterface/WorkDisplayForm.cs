using ControlLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlUserInterface
{
    public partial class WorkDisplayForm : Form
    {
        private JobModel Job;
        private ControllerModel Controller;
        private UserModel User;

        public WorkDisplayForm(JobModel job, ControllerModel controller, UserModel user)
        {
            InitializeComponent();

            this.Job = job;
            this.Controller = controller;
            this.User = user;

            SetupDisplay();
        }

        private void SetupDisplay()
        {
            jobNameLabel.Text = Job.Name;

            userDisplayNameLabel.Text = User.DisplayName;

            DisplayNewParameter(Job.Parameters.First());
        }

        private void DisplayNewParameter(ParameterModel parameter)
        {
            parameterNameLabel.Text = parameter.Name;
            batchCountLabel.Text = "0";
            batchTotalLabel.Text = parameter.BatchCount.ToString();
            unitsLabel.Text = parameter.Units;
            measurementValueLabel.Text = "0.0";
        }

        private void UpdateUserMessage(string message)
        {
            userMessageListBox.Items.Add(message);

            // Displays the last item in the ListBox
            userMessageListBox.SelectionMode = SelectionMode.One;
            userMessageListBox.SelectedIndex = userMessageListBox.Items.Count - 1;
            userMessageListBox.ClearSelected();
            userMessageListBox.SelectionMode = SelectionMode.None;
        }
    }
}
