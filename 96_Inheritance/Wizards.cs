using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly:InternalsVisibleTo("96_Inheritance.Tests")]

namespace _96_Inheritance
{
    internal class Wizards
    {
    }
    

    abstract class Character
    {
        private string _characterType = "";
        protected Character(string characterType)
        {
            _characterType = characterType;
        }

        public abstract int DamagePoints(Character target);

        public virtual bool Vulnerable() => false;

        public override string ToString() => "Character is a " + _characterType;
    }

    class Warrior : Character
    {
        public Warrior() : base("Warrior")
        {
        }

        public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
    }

    class Wizard : Character
    {
        public Wizard() : base("Wizard")
        {
        }

        bool _isSpellPrepared = false;

        public override int DamagePoints(Character target) => _isSpellPrepared ? 12: 3;

        public void PrepareSpell() => _isSpellPrepared = true;
        
        public override bool Vulnerable() => _isSpellPrepared ? false : true;
    }

}
