using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mikmakGUI
{
    class CreateRoomRequest
    {
        public string roomName { get; set; }
        public int maxPlayers { get; set; }
        public int questionCount { get; set; }
        public int answerTimeout { get; set; }
    }
}
