using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventIRC
{
    class Class //HOLDS ALL BASE DATA FOR CLASSES
    {
        //example data

        public List<string> names = new List<string> {"class1", "class2"};

        public int str, dex, con, intel, wis, cha;

        public int race, clas;

        public int speed;

        public Class(int clNum, int clRac)
        {
            clas = clNum;

            for (int i = 0; i < 6; i++ )//for each stat
            {
                List<int> rolls = new List<int>();
                Random r = new Random();

                for (int j = 0; j < 4; j++) //roll four times
                {
                    rolls.Add(r.Next(6));
                }

                //sort and take the top three
                rolls.Sort();
                 int stat = rolls[3] + rolls[2] + rolls[1];
                switch(i)
                {
                    case 0:
                        str = stat;
                        break;
                    case 1:
                        dex = stat;
                        break;
                    case 2:
                        con = stat;
                        break;
                    case 3:
                        intel = stat;
                        break;
                    case 4:
                        wis = stat;
                        break;
                    case 5:
                        cha = stat;
                        break;
                }

            }

            switch(clRac) //add stuff based on race
            {

            }

            switch (clNum) //add stuff based on class
            {

            }
        }
    }
}
