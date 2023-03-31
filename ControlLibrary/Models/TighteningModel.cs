using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Models
{
    /// <summary>
    /// A tightening represents one measurement, sent to the controller.
    /// </summary>
    public class TighteningModel
    {
        /// <summary>
        /// The job number that is currently being run.
        /// Specified by two digits ranging from 00 to 99.
        /// </summary>
        public string JobId { get; set; }

        /// <summary>
        /// The parameter number that is currently being run.
        /// Specified by three digits ranging from 000 to 999.
        /// </summary>
        public string ParameterId { get; set; }

        /// <summary>
        /// The total number of tightenings set for the batch.
        /// Specified by four digits ranging from 0000 to 9999.
        /// </summary>
        public string BatchSize { get; set; }

        /// <summary>
        /// The current batch count for the given tightening.
        /// Specified by four digits ranging from 0000 to 9999.
        /// </summary>
        public string  BatchCount { get; set; }

        /// <summary>
        /// The tightening status specifies if the tightening is unaccepted (0) or accepted (1).
        /// </summary>
        public string TighteningStatus { get; set; }

        /// <summary>
        /// The torque status specifies if the torque measurement is low (0), ok (1), or high (2).
        /// </summary>
        public string TorqueStatus { get; set; }

        /// <summary>
        /// The angle status specifies if the angle measurement is low (0), ok (1), or high (2).
        /// </summary>
        public string AngleStatus { get; set; }

        /// <summary>
        /// The torque value for the specific tightening.
        /// The torque value is multiplied by 100 and set as an integer (2 decimals truncated).
        /// The torque is six digits ranging from 000000 to 999999.
        /// </summary>
        public string Torque { get; set; }

        /// <summary>
        /// The turning angle for the specific tightening, in degrees.
        /// Each turn represents 360 degrees.
        /// The angle is five digits ranging from 00000 to 99999.
        /// </summary>
        public string Angle { get; set; }

        /// <summary>
        /// Time stamp for each tightening sent to the control station.
        /// The time stamp is specified by 19 ASCII characters (YYYY-MM-DD:HH:MM:SS).
        /// </summary>
        public string TimeStamp { get; set; }

        /// <summary>
        /// The batch status specifes if batch has not been completed (0),
        /// batch completed (1), or batch not used (2).
        /// </summary>
        public string BatchStatus { get; set; }

        /// <summary>
        /// A unique Id for each tightening result.
        /// </summary>
        public string TighteningId { get; set; }
    }
}
