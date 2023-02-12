namespace Pokemon_Adventures_Simple
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VS_Image = new System.Windows.Forms.PictureBox();
            this.Pokemon_Image = new System.Windows.Forms.PictureBox();
            this.Monster_Image = new System.Windows.Forms.PictureBox();
            this.VS_Button = new System.Windows.Forms.Button();
            this.PokemonHP_TextBox = new System.Windows.Forms.TextBox();
            this.PokemonHP_Label = new System.Windows.Forms.Label();
            this.PokemonAttack_Label = new System.Windows.Forms.Label();
            this.PokemonAttack_TextBox = new System.Windows.Forms.TextBox();
            this.MonsterAttack_Label = new System.Windows.Forms.Label();
            this.MonsterAttack_TextBox = new System.Windows.Forms.TextBox();
            this.MonsterHP_Label = new System.Windows.Forms.Label();
            this.MonsterHP_TextBox = new System.Windows.Forms.TextBox();
            this.Pokemon1_Selecter = new System.Windows.Forms.Button();
            this.Pokemon2Selecter = new System.Windows.Forms.Button();
            this.Pokemon3_Selecter = new System.Windows.Forms.Button();
            this.Pokemon4_Selecter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VS_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pokemon_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monster_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // VS_Image
            // 
            this.VS_Image.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VS_Image.BackColor = System.Drawing.Color.Transparent;
            this.VS_Image.Image = global::Pokemon_Adventures_Simple.Properties.Resources.Street_Fighter_VS_logo;
            this.VS_Image.Location = new System.Drawing.Point(246, 30);
            this.VS_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VS_Image.Name = "VS_Image";
            this.VS_Image.Size = new System.Drawing.Size(96, 96);
            this.VS_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VS_Image.TabIndex = 0;
            this.VS_Image.TabStop = false;
            // 
            // Pokemon_Image
            // 
            this.Pokemon_Image.BackColor = System.Drawing.Color.Transparent;
            this.Pokemon_Image.Location = new System.Drawing.Point(70, 30);
            this.Pokemon_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pokemon_Image.Name = "Pokemon_Image";
            this.Pokemon_Image.Size = new System.Drawing.Size(131, 112);
            this.Pokemon_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pokemon_Image.TabIndex = 1;
            this.Pokemon_Image.TabStop = false;
            // 
            // Monster_Image
            // 
            this.Monster_Image.BackColor = System.Drawing.Color.Transparent;
            this.Monster_Image.Location = new System.Drawing.Point(399, 30);
            this.Monster_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Monster_Image.Name = "Monster_Image";
            this.Monster_Image.Size = new System.Drawing.Size(131, 112);
            this.Monster_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Monster_Image.TabIndex = 2;
            this.Monster_Image.TabStop = false;
            // 
            // VS_Button
            // 
            this.VS_Button.Location = new System.Drawing.Point(252, 138);
            this.VS_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VS_Button.Name = "VS_Button";
            this.VS_Button.Size = new System.Drawing.Size(82, 38);
            this.VS_Button.TabIndex = 3;
            this.VS_Button.Text = "Battle";
            this.VS_Button.UseVisualStyleBackColor = true;
            this.VS_Button.Click += new System.EventHandler(this.VS_Button_Click);
            // 
            // PokemonHP_TextBox
            // 
            this.PokemonHP_TextBox.Location = new System.Drawing.Point(91, 170);
            this.PokemonHP_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PokemonHP_TextBox.Name = "PokemonHP_TextBox";
            this.PokemonHP_TextBox.ReadOnly = true;
            this.PokemonHP_TextBox.Size = new System.Drawing.Size(110, 23);
            this.PokemonHP_TextBox.TabIndex = 4;
            // 
            // PokemonHP_Label
            // 
            this.PokemonHP_Label.AutoSize = true;
            this.PokemonHP_Label.Location = new System.Drawing.Point(61, 172);
            this.PokemonHP_Label.Name = "PokemonHP_Label";
            this.PokemonHP_Label.Size = new System.Drawing.Size(23, 15);
            this.PokemonHP_Label.TabIndex = 6;
            this.PokemonHP_Label.Text = "HP";
            // 
            // PokemonAttack_Label
            // 
            this.PokemonAttack_Label.AutoSize = true;
            this.PokemonAttack_Label.Location = new System.Drawing.Point(41, 148);
            this.PokemonAttack_Label.Name = "PokemonAttack_Label";
            this.PokemonAttack_Label.Size = new System.Drawing.Size(41, 15);
            this.PokemonAttack_Label.TabIndex = 8;
            this.PokemonAttack_Label.Text = "Attack";
            // 
            // PokemonAttack_TextBox
            // 
            this.PokemonAttack_TextBox.Location = new System.Drawing.Point(91, 146);
            this.PokemonAttack_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PokemonAttack_TextBox.Name = "PokemonAttack_TextBox";
            this.PokemonAttack_TextBox.ReadOnly = true;
            this.PokemonAttack_TextBox.Size = new System.Drawing.Size(110, 23);
            this.PokemonAttack_TextBox.TabIndex = 7;
            // 
            // MonsterAttack_Label
            // 
            this.MonsterAttack_Label.AutoSize = true;
            this.MonsterAttack_Label.Location = new System.Drawing.Point(370, 148);
            this.MonsterAttack_Label.Name = "MonsterAttack_Label";
            this.MonsterAttack_Label.Size = new System.Drawing.Size(41, 15);
            this.MonsterAttack_Label.TabIndex = 12;
            this.MonsterAttack_Label.Text = "Attack";
            // 
            // MonsterAttack_TextBox
            // 
            this.MonsterAttack_TextBox.Location = new System.Drawing.Point(420, 146);
            this.MonsterAttack_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MonsterAttack_TextBox.Name = "MonsterAttack_TextBox";
            this.MonsterAttack_TextBox.ReadOnly = true;
            this.MonsterAttack_TextBox.Size = new System.Drawing.Size(110, 23);
            this.MonsterAttack_TextBox.TabIndex = 11;
            // 
            // MonsterHP_Label
            // 
            this.MonsterHP_Label.AutoSize = true;
            this.MonsterHP_Label.Location = new System.Drawing.Point(391, 173);
            this.MonsterHP_Label.Name = "MonsterHP_Label";
            this.MonsterHP_Label.Size = new System.Drawing.Size(23, 15);
            this.MonsterHP_Label.TabIndex = 10;
            this.MonsterHP_Label.Text = "HP";
            // 
            // MonsterHP_TextBox
            // 
            this.MonsterHP_TextBox.Location = new System.Drawing.Point(420, 170);
            this.MonsterHP_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MonsterHP_TextBox.Name = "MonsterHP_TextBox";
            this.MonsterHP_TextBox.ReadOnly = true;
            this.MonsterHP_TextBox.Size = new System.Drawing.Size(110, 23);
            this.MonsterHP_TextBox.TabIndex = 9;
            // 
            // Pokemon1_Selecter
            // 
            this.Pokemon1_Selecter.Location = new System.Drawing.Point(70, 205);
            this.Pokemon1_Selecter.Name = "Pokemon1_Selecter";
            this.Pokemon1_Selecter.Size = new System.Drawing.Size(131, 23);
            this.Pokemon1_Selecter.TabIndex = 13;
            this.Pokemon1_Selecter.Text = "Ivysaur";
            this.Pokemon1_Selecter.UseVisualStyleBackColor = true;
            this.Pokemon1_Selecter.Click += new System.EventHandler(this.Pokemon1_Selecter_Click);
            // 
            // Pokemon2Selecter
            // 
            this.Pokemon2Selecter.Location = new System.Drawing.Point(70, 234);
            this.Pokemon2Selecter.Name = "Pokemon2Selecter";
            this.Pokemon2Selecter.Size = new System.Drawing.Size(131, 23);
            this.Pokemon2Selecter.TabIndex = 14;
            this.Pokemon2Selecter.Text = "Pidgeot";
            this.Pokemon2Selecter.UseVisualStyleBackColor = true;
            this.Pokemon2Selecter.Click += new System.EventHandler(this.Pokemon2Selecter_Click);
            // 
            // Pokemon3_Selecter
            // 
            this.Pokemon3_Selecter.Location = new System.Drawing.Point(70, 263);
            this.Pokemon3_Selecter.Name = "Pokemon3_Selecter";
            this.Pokemon3_Selecter.Size = new System.Drawing.Size(131, 23);
            this.Pokemon3_Selecter.TabIndex = 16;
            this.Pokemon3_Selecter.Text = "Wigglytuff";
            this.Pokemon3_Selecter.UseVisualStyleBackColor = true;
            this.Pokemon3_Selecter.Click += new System.EventHandler(this.Pokemon3_Selecter_Click);
            // 
            // Pokemon4_Selecter
            // 
            this.Pokemon4_Selecter.Location = new System.Drawing.Point(70, 292);
            this.Pokemon4_Selecter.Name = "Pokemon4_Selecter";
            this.Pokemon4_Selecter.Size = new System.Drawing.Size(131, 23);
            this.Pokemon4_Selecter.TabIndex = 17;
            this.Pokemon4_Selecter.Text = "Drowzee";
            this.Pokemon4_Selecter.UseVisualStyleBackColor = true;
            this.Pokemon4_Selecter.Click += new System.EventHandler(this.Pokemon4_Selecter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pokemon_Adventures_Simple.Properties.Resources.d83m36e_3b58ca48_fe8a_456e_9ffc_a5a84eca6613;
            this.ClientSize = new System.Drawing.Size(593, 325);
            this.Controls.Add(this.Pokemon4_Selecter);
            this.Controls.Add(this.Pokemon3_Selecter);
            this.Controls.Add(this.Pokemon2Selecter);
            this.Controls.Add(this.Pokemon1_Selecter);
            this.Controls.Add(this.MonsterAttack_Label);
            this.Controls.Add(this.MonsterAttack_TextBox);
            this.Controls.Add(this.MonsterHP_Label);
            this.Controls.Add(this.MonsterHP_TextBox);
            this.Controls.Add(this.PokemonAttack_Label);
            this.Controls.Add(this.PokemonAttack_TextBox);
            this.Controls.Add(this.PokemonHP_Label);
            this.Controls.Add(this.PokemonHP_TextBox);
            this.Controls.Add(this.VS_Button);
            this.Controls.Add(this.Monster_Image);
            this.Controls.Add(this.Pokemon_Image);
            this.Controls.Add(this.VS_Image);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(609, 364);
            this.MinimumSize = new System.Drawing.Size(609, 364);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VS_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pokemon_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monster_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox VS_Image;
        private PictureBox Pokemon_Image;
        private PictureBox Monster_Image;
        private Button VS_Button;
        private TextBox PokemonHP_TextBox;
        private Label PokemonHP_Label;
        private Label PokemonAttack_Label;
        private TextBox PokemonAttack_TextBox;
        private Label MonsterAttack_Label;
        private TextBox MonsterAttack_TextBox;
        private Label MonsterHP_Label;
        private TextBox MonsterHP_TextBox;
        private Button Pokemon1_Selecter;
        private Button Pokemon2Selecter;
        private Button Pokemon3_Selecter;
        private Button Pokemon4_Selecter;
    }
}