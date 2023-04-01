using ControlLibrary.Models;
using ControlUserInterface.Requesters;

namespace ControlUserInterface
{
    public partial class MainSelectionForm : Form, IControllerRequester
    {
        private ControllerModel controller = new ControllerModel();

        public MainSelectionForm()
        {
            InitializeComponent();
        }

        public void ControllerComplete(ControllerModel controller)
        {
            this.controller = controller;

            MessageBox.Show($"IP Address: {controller.IpAddress}\nPort Number: {controller.PortNumber}");
        }

        private void applicationSettingsButton_Click(object sender, EventArgs e)
        {
            ApplicationSettingsForm frm = new ApplicationSettingsForm(this);
            frm.ShowDialog();
        }
    }
}