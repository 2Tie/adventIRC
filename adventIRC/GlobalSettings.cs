using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventIRC
{
    public static class GlobalSettings
    {
        public int maxPlayersInParty, maxItems, maxSpells, maxAbilities;//-1 for no cap
        public bool itemsParty;//if items are party-based instead of character based
        public int joinState;//if new players can join: 0 for no, 1 for yes, 2 for yes (reserves)

    }
}
