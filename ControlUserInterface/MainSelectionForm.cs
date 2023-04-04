using ControlLibrary.Models;
using ControlUserInterface.Requesters;

namespace ControlUserInterface
{
    public partial class MainSelectionForm : Form, IControllerRequester
    {
        private JobModel Job = new JobModel();
        private ControllerModel Controller = new ControllerModel();
        private UserModel User = new UserModel();

        public MainSelectionForm()
        {
            InitializeComponent();
        }

        public void ControllerComplete(ControllerModel controller)
        {
            this.Controller = controller;
        }

        private void applicationSettingsButton_Click(object sender, EventArgs e)
        {
            ApplicationSettingsForm frm = new ApplicationSettingsForm(this);
            frm.ShowDialog();
        }

        private void freeFormButton_Click(object sender, EventArgs e)
        {
            LoadDemoJobData();
            LoadDemoUserData();

            WorkDisplayForm frm = new WorkDisplayForm(Job, Controller, User);
            frm.ShowDialog();
        }

        private void LoadDemoJobData()
        {
            Job.Name = "Demo Job";
            Job.Parameters.Add(new ParameterModel { Name = "Demo Parameter", BatchCount = 10, Units = "Nm" });
        }

        private void LoadDemoUserData()
        {
            User.FirstName = "John";
            User.LastName = "Doe";
        }
    }
}