using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Models
{
    public class JobModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public List<ParameterModel> Parameters { get; set; } = new List<ParameterModel>();
    }
}
