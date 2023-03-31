using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Models
{
    /// <summary>
    /// A message is information sent over the communication link in ASCII format.
    /// A message consists of three parts: header, data field, and message end.
    /// The message end is a null character.
    /// </summary>
    public class MessageModel
    {
        /// <summary>
        /// Total length of the message, in bytes.
        /// The length is four ASCII digits specifying a range of 0000 to 9999.
        /// The length is the length of the header plus the data field.
        /// The message end is not included in the message length.
        /// </summary>
        public string Length { get; set; }

        /// <summary>
        /// The message Id describes how to interpret the telegram.
        /// The message Id is four digits long and ranges from 0000 to 9999.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The message revision is unique per message Id,
        /// and can be used to subscribe or ask for different versions of the same Id.
        /// The revision is three digits long and ranges from 000 to 999.
        /// </summary>
        public string Revision { get; set; }

        /// <summary>
        /// Reserved space in header for future use.
        /// Reserved space is nine digits long.
        /// </summary>
        public string Spare { get; set; }

        /// <summary>
        /// The information conveyed by the message.
        /// The data field is parsed based on Id of the message.
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// All messages are null terminated.
        /// </summary>
        public string MessageEnd { get; }
    }
}
