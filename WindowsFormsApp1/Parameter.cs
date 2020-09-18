using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsForms
{
    public enum AttackKind
    { 
        magic,
        physical,
        unknown
    }

    public enum Tribe
    {
        slime,
        dragon,	
        ghost,
        beast
    }

    public enum PopPosition
    {
        grass_field,
        cave,
        forest,
    }

    public enum Attribute
    {
        fire,
        water,
        thunder,
        soil,
        wind,
    }

    public class Parameter
    {
        public string MonsterName
        {
            get { return this.monster_name; }
            set { this.monster_name = value; }
        }

        public Attribute Attribute
        {
            get { return this.attribute; }
            set { this.attribute = value; }
        }

        public int Level
        {
            get { return this.level; }
            set { this.level = value; }
        }

        public int Experience
        {
            get { return this.experience; }
            set { this.experience = value; }
        }

        public Tribe MonsterTribe
        {
            get { return this.monster_tribe; }
            set { this.monster_tribe = value; }
        }

        public PopPosition Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public string CommandFirstName
        {
            get { return this.command_first_name; }
            set { this.command_first_name = value; }
        }

        public string CommandSecondName
        {
            get { return this.command_second_name; }
            set { this.command_second_name = value; }
        }

        public string CommandThirdName
        {
            get { return this.command_third_name; }
            set { this.command_third_name = value; }
        }

        public string CommandFourthName
        {
            get { return this.command_fourth_name; }
            set { this.command_fourth_name = value; }
        }

        public int CommandFirstPower
        {
            get { return this.command_first_power; }
            set { this.command_first_power = value; }
        }

        public int CommandSecondPower
        {
            get { return this.command_second_power; }
            set { this.command_second_power = value; }
        }

        public int CommandThirdPower
        {
            get { return this.command_third_power; }
            set { this.command_third_power = value; }
        }

        public int CommandFourthPower
        {
            get { return this.command_fourth_power; }
            set { this.command_fourth_power = value; }
        }

        public AttackKind CommandFirstKind
        {
            get { return this.command_first_kind; }
            set { this.command_first_kind = value; }
        }

        public AttackKind CommandSecondKind
        {
            get { return this.command_second_kind; }
            set { this.command_second_kind = value; }
        }

        public AttackKind CommandThirdKind
        {
            get { return this.command_third_kind; }
            set { this.command_third_kind = value; }
        }

        public AttackKind CommandFourthKind
        {
            get { return this.command_fourth_kind; }
            set { this.command_fourth_kind = value; }
        }

        public int MaxAttackPower
        {
            get { return this.max_attack_power; }
            set { this.max_attack_power = value; }
        }

        private string monster_name;

        private Attribute attribute;

        private int level;

        private int experience;

        private Tribe monster_tribe;

        private PopPosition position;

        private string command_first_name;
        private int command_first_power;
        private AttackKind command_first_kind;

        private string command_second_name;
        private int command_second_power;
        private AttackKind command_second_kind;

        private string command_third_name;
        private int command_third_power;
        private AttackKind command_third_kind;

        private string command_fourth_name;
        private int command_fourth_power;
        private AttackKind command_fourth_kind;

        private int max_attack_power;
    }
}
