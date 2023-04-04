using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Models
{
    public class ParameterModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int BatchCount = 0;
        public string Units { get; set; } = String.Empty;
    }
}
