using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study1010
{
    class SuperHero
    {
        //fields
        private string secretIdentity;
        private bool hasCape;
        private int strengthLevel;
        private string archnemesis;
        //planetOfOrigin under invisibility cloak

        //Properties
        public string SecretIdentity { get; set; }
        public bool HasCape { get; set; }
        public int StrengthLevel { get; set; }
        public string PlanetOfOrigin { get; set; }

        //Constructors
        public SuperHero()
        {

        }

        public SuperHero(string secretIdentity, bool hasCape)
        {
            this.secretIdentity = secretIdentity;
            this.hasCape = hasCape;
            strengthLevel = 16;
            archnemesis = "Lex Luther";
        }


    }
}
