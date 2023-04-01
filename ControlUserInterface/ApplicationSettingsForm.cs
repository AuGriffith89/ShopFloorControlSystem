using ControlLibrary.Models;
using ControlUserInterface.Requesters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlUserInterface
{
    public partial class ApplicationSettingsForm : Form
    {
        private IControllerRequester callingForm;
        readonly ControllerModel controller = new ControllerModel();

        public ApplicationSettingsForm(IControllerRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            LoadFormData();
        }

        private void LoadFormData()
        {
            controllerIpAddressValue.Text = controller.IpAddress;
            controllerPortNumberValue.Text = controller.PortNumber.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ClearWarningLabels();

            if (!ValidateForm())
            {
                return;
            }

            callingForm.ControllerComplete(controller);

            this.Close();
        }

        private void ClearWarningLabels()
        {
            controllerIpAddressWarningLabel.Text = String.Empty;
            controllerPortNumberWarningLabel.Text = String.Empty;
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            string ipAddress = String.Empty;
            int portNumber = 0;

            try
            {
                ipAddress = IPAddress.Parse(controllerIpAddressValue.Text).ToString();
            }
            catch (FormatException)
            {
                controllerIpAddressWarningLabel.Text = "Please enter a valid IP Address.";
                isValid = false;
            }

            try
            {
                portNumber = int.Parse(controllerPortNumberValue.Text);
            }
            catch (FormatException)
            {
                controllerPortNumberWarningLabel.Text = "Please enter a valid Port Number.";
                isValid = false;
            }

            if (isValid)
            {
                controller.IpAddress = ipAddress;
                controller.PortNumber = portNumber;
            }

            return isValid;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void controllerIpAddressValue_TextChanged(object sender, EventArgs e)
        {
            // TODO - Format input in dotted-quad notation.

            // Example: string str = String.Format("{0:#,###,###.##}", ips);

            // controllerIpAddressWarningLabel.Text = String.Empty; 

            //string ipAddress = String.Empty;

            //try
            //{
            //    ipAddress = IPAddress.Parse(controllerIpAddressValue.Text).ToString();
            //    controllerIpAddressValue.Text = ipAddress;
            //} catch (FormatException)
            //{
            //    return;
            //}
        }
    }
}
