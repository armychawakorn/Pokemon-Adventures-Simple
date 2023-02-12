using Pokemon_Adventures_Simple.Pokemons;

namespace Pokemon_Adventures_Simple
{
    public partial class Form1 : Form
    {
        private PokemonCharacter Pokemon;
        private PokemonCharacter Monster;
        private List<PokemonCharacter> ListOfPokemons = new List<PokemonCharacter>();
        public Form1()
        {
            InitializeComponent();
            //Generate Monster
            Monster = new Nidorino();
            Monster_Image.Image = Monster.getImage();
            MonsterHP_TextBox.Text = Monster.GetHP().ToString();
            MonsterAttack_TextBox.Text = Monster.getPower().ToString();
            //End of Generate Monster

            //Add pokemon to list
            ListOfPokemons.Add(new Ivysaur());
            ListOfPokemons.Add(new Pidgeot());
            ListOfPokemons.Add(new Wigglytuff());
            ListOfPokemons.Add(new Drowzee());
            // End

            //Init first pokemon to Game
            Pokemon = ListOfPokemons[0];
            Pokemon_Image.Image = Pokemon.getImage();
            PokemonAttack_TextBox.Text = Pokemon.getPower().ToString();
            PokemonHP_TextBox.Text = Pokemon.GetHP().ToString();
            //End
        }

        private void Pokemon1_Selecter_Click(object sender, EventArgs e)
        {
            Pokemon = ListOfPokemons[0];
            Pokemon_Image.Image = Pokemon.getImage();
            PokemonAttack_TextBox.Text = Pokemon.getPower().ToString();
            PokemonHP_TextBox.Text = Pokemon.GetHP().ToString();
        }

        private void Pokemon2Selecter_Click(object sender, EventArgs e)
        {
            Pokemon = ListOfPokemons[1];
            Pokemon_Image.Image = Pokemon.getImage();
            PokemonAttack_TextBox.Text = Pokemon.getPower().ToString();
            PokemonHP_TextBox.Text = Pokemon.GetHP().ToString();
        }

        private void Pokemon3_Selecter_Click(object sender, EventArgs e)
        {
            Pokemon = ListOfPokemons[2];
            Pokemon_Image.Image = Pokemon.getImage();
            PokemonAttack_TextBox.Text = Pokemon.getPower().ToString();
            PokemonHP_TextBox.Text = Pokemon.GetHP().ToString();
        }

        private void Pokemon4_Selecter_Click(object sender, EventArgs e)
        {
            Pokemon = ListOfPokemons[3];
            Pokemon_Image.Image = Pokemon.getImage();
            PokemonAttack_TextBox.Text = Pokemon.getPower().ToString();
            PokemonHP_TextBox.Text = Pokemon.GetHP().ToString();
        }

        private void VS_Button_Click(object sender, EventArgs e)
        {
            Start_Battle();
            if (Monster.GetHP() < 0)
            {
                MonsterHP_TextBox.Text = "0";
                MessageBox.Show("คุณชนะแล้ว");
            }else if(Pokemon.GetHP() < 0)
            {
                PokemonHP_TextBox.Text = "0";
                MessageBox.Show(Pokemon.getName() + " ของคุณตายแล้ว");
                Pokemon.SetHP(0);
                return;
            }
        }

        void Start_Battle()
        {
            if(Pokemon.GetHP() > 0 && Monster.GetHP() > 0)
            {
                Pokemon.SetHP(Pokemon.GetHP() - Monster.getPower());
                PokemonHP_TextBox.Text = Pokemon.GetHP().ToString();

                Monster.SetHP(Monster.GetHP() - Pokemon.getPower());
                MonsterHP_TextBox.Text = Monster.GetHP().ToString();
            }
        }
    }
}