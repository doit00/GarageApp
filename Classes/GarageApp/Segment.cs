using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    struct SegmentType
    {
        public SegmentClass Class { get; set; }
        public string Description { get; set; }

    }
    public enum SegmentClass
    {
        A
       ,B
       ,C
       ,D
       ,E
       ,F
       ,S
       ,M
       ,J
    }
}
