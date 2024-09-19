using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Model.Response
{
    public class MappingResponseModel
    {
        public int CustomerId { get; set; }
        public List<int> ProductIds { get; set; }
    }
}
