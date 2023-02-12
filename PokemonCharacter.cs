using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Adventures_Simple
{
    public class PokemonCharacter
    {
        protected string Name;
        protected int HP;
        protected int Power;
        protected Bitmap Image;

        public string getName()
        {
            return this.Name;
        }
        public int GetHP()
        {
            return this.HP;
        }
        public int getPower()
        {
            return this.Power;
        }
        public Bitmap getImage()
        {
            return this.Image;
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
            HP = value;
        }
    }
}
