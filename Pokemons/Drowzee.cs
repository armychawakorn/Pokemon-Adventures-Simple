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
            this.ชื่อ = "Drowzee";
            this.เลือด = this.RandomHP();
            this.พลังโจมตี = this.RandomPower();
            this.รูปภาพ = Resources.Drowzee;
        }
    }
}
