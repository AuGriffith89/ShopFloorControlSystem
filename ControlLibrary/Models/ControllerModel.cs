using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Models
{
    public class ControllerModel
    {
        private const string DefaultIpAddress = "255.255.255.255";
        private const int DefaultPortNumber = 4545;

        public string IpAddress { get; set; }
        public int PortNumber { get; set; }

        public ControllerModel()
        {
            IpAddress = ConfigurationManager.AppSettings["controllerIpAddress"] ?? DefaultIpAddress;

            PortNumber = DefaultPortNumber;
            if (int.TryParse(ConfigurationManager.AppSettings["controllerPortNumber"] ?? DefaultPortNumber.ToString(), out int portNumber))
            {
                PortNumber = portNumber;
            }
        }
    }
}
