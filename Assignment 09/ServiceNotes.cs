using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceNoteSpace
{
    class ServiceNotes
    {
        string userServiceNotes;

        public string ServiceNoteInput
        {
            get
            {
                return userServiceNotes;
            }
            set
            {
                userServiceNotes = value;
            }
        }
    }
}
