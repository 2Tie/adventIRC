using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventIRC
{
    class Caravan //Party manager
    {
        public List<PlayerCharacter> activeParty = new List<PlayerCharacter>();
        public List<PlayerCharacter> reserveParty = new List<PlayerCharacter>();

        //items list goes here

        public int getCharacterIndex(string nam)
        {
            return activeParty.FindIndex(x => x.name == nam);
        }
    }
}
