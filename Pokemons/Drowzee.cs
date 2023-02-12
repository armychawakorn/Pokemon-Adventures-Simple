using Pokemon_Adventures_Simple.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Adventures_Simple.Pokemons
{
    public class Drowzee : PokemonCharacter
    {
        public Drowzee()
        {
            this.Name = "Drowzee";
            this.HP = this.RandomHP();
            this.Power = this.RandomPower();
            this.Image = Resources.Drowzee;
        }
    }
}
