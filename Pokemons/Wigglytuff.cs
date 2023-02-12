using Pokemon_Adventures_Simple.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Adventures_Simple.Pokemons
{
    public class Wigglytuff : PokemonCharacter
    {
        public Wigglytuff()
        {
            this.Name = "Wigglytuff";
            this.HP = this.RandomHP();
            this.Power = this.RandomPower();
            this.Image = Resources.Wigglytuff;
        }
    }
}
