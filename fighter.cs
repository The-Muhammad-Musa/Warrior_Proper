using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warrior_Proper
{
    public class fighter
    {
        // Variables!
        string name;
        int health,
            power;
        // Main class
        public fighter(string pName, int pHealth, int pPower)
        {
            // Defining basics
            name = pName;
            health = pHealth;
            power = pPower;
        }

        // Properties
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }
        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
