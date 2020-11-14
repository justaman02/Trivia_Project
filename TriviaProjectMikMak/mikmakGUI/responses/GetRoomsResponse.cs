using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mikmakGUI
{
    class GetRoomsResponse
    {
        public int status { get; set; }
        public List<RoomData> rooms { get; set; }
    }
}
