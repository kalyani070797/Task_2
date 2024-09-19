using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Model.Response
{
    public class GetDetailsRequestModel
    {
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public string ContactNumber { get; set; }
        public int Age { get; set; }

    }
}
