using ControlLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlUserInterface.Requesters
{
    public interface IControllerRequester
    {
        public void ControllerComplete(ControllerModel controller);
    }
}
