using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Adventures_Simple
{
    public class PokemonCharacter
    {
        protected string ชื่อ;
        protected int เลือด;
        protected int พลังโจมตี;
        protected Bitmap รูปภาพ;

        public string getName()
        {
            return this.ชื่อ;
        }
        public int GetHP()
        {
            return this.เลือด;
        }
        public int getPower()
        {
            return this.พลังโจมตี;
        }
        public Bitmap getImage()
        {
            return this.รูปภาพ;
        }
        public int RandomHP()
        {
            return new Random().Next(300, 1000);
        }
        public int RandomPower()
        {
            return new Random().Next(10, 100);
        }
        public void SetHP(int value)
        {
            เลือด = value;
        }
    }
}
