using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventIRC
{
    class PlayerCharacter
    {
        public string name;
        public string owner;
        public Class data;

        //items list goes here

        public PlayerCharacter(string towner, string nam, int race, int clas)
        {
            name = nam;
            owner = towner;
            data = new Class(clas, race);
        }
    }
}
