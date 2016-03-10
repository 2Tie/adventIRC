using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventIRC
{
    class GlobalSettings
    {
        public int maxPlayersInParty, maxItems, maxSpells, maxAbilities;//-1 for no cap
        public bool itemsParty;//if items are party-based instead of character based
    }
}
