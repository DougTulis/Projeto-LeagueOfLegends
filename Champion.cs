using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Combate {
    internal class Champion {

        public string Name { get; private set; }
        public int Life { get; set; }
        public int Attack { get; private set; }
        public int Armor { get; private set; }

        public Champion(string name, int life, int attack, int armor) {
            Name = name;
            Life = life;
            Attack = attack;
            Armor = armor;
        }

        public void takeDamage(Champion other) {
            Life -= other.Attack;
        }

        public string status() {
            if (Life == 0) {
                return Name + ": " + Life + " de vida (morreu)";
            }
            return Name + ": " + Life + " de vida";

        }
    }
}
