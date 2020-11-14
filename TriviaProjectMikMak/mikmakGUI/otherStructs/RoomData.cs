using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mikmakGUI
{
    public class RoomData
    {
        public RoomData(int id, string name, int maxPlayers, int timePerQuestion, bool isActive)
        {
            this.id = id;
            this.name = name;
            this.maxPlayers = maxPlayers;
            this.timePerQuestion = timePerQuestion;
            this.isActive = isActive;
        }
        public RoomData() { }
        public int id { get; set; }
        public string name { get; set; }
        public int maxPlayers { get; set; }
        public int timePerQuestion { get; set; }
        public bool isActive { get; set; }
    }
}
