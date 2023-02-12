using Pokemon_Adventures_Simple.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Adventures_Simple.Pokemons
{
    public class Nidorino : PokemonCharacter
    {
        public Nidorino()
        {
            this.ชื่อ = "Nidorino";
            this.เลือด = this.RandomHP() * 3;
            this.พลังโจมตี = this.RandomPower();
            this.รูปภาพ = Resources.Nidorino;
        }
    }
}
