using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mikmakGUI.Requests
{
    public class GetQuestionResponse
    {
        
        public SortedDictionary<string, string> answers { get; set; }
        public string question { get; set; }
        public int status { get; set; }

    }
}
