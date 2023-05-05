using ControlLibrary.Models;
using ControlLibrary.Models.Messages;
using ControlLibrary.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Controllers
{
    public class WorkController
    {
        /*
         * Needs:
         *  Current Job
         *  Controller Settings
         *  User
         *  Client
         */
        private JobModel _job;
        private ControllerModel _controller;
        private UserModel _user;

        private Client _client = new Client();

        public WorkController(JobModel job, ControllerModel controller, UserModel user)
        {
            _job = job;
            _controller = controller;
            _user = user;

            _client.ReceviedTighteningEvent += Client_ReceivedTightening();
        }

        /*
         * Actions:
         *  Start client and connect to controller
         *  Send communication start MID
         *  Start keep alive timer => Later implementation
         *  Subscribe to tightening result data
         *  Assign parameter from job => Later implementation
         */
        public async Task StartCommunication()
        {
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(_controller.IpAddress), _controller.PortNumber);
            await _client.ConnectToController(remoteEP);

            // TODO - Better way of doing this
            MessageModel startCommunication = new MessageModel();
            startCommunication.Length = "0020";
            startCommunication.Id = "0001";
            startCommunication.Revision = "001";
            startCommunication.Spare = "000000000";
            startCommunication.Data = String.Empty;
            await _client.SendAsync(startCommunication);

            MessageModel subscribeTightenings = new MessageModel();
            subscribeTightenings.Length = "0020";
            subscribeTightenings.Id = "0060";
            subscribeTightenings.Revision = "004";
            subscribeTightenings.Spare = "000000000";
            subscribeTightenings.Data = String.Empty;
            await _client.SendAsync(subscribeTightenings);
        }

        private EventHandler<MessageModel>? Client_ReceivedTightening()
        {
            throw new NotImplementedException();
        }

    }
}
