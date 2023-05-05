using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Models.Messages
{
    public class MID0001
    {
        private const string _length = "0020";
        private const string _id = "0001";
        private const string _revision = "001";
        private const string _spare = "000000000";
        private const string _data = "";
        private const char _end = '\0';

        public byte[] Build()
        {
            string package = $"{_length}{_id}{_revision}{_spare}{_data}{_end}";

            return Encoding.ASCII.GetBytes(package);
        }
    }
}
