using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class Warrior : Character
    {
        public new float Hp { get => base.Hp;}
        public new float Mp { get => base.Mp;}
        public new int Level { get => base.Level;}
        public new float Exp { get => base.Exp;}
        public new float Range { get => base.Range;}
        public new float Life { get => base.Life;}
        public new float Armor { get => base.Armor;}
        public new float Speed { get => base.Speed; }
        public new float Damage { get => base.Damage;}
        public new float Mana { get => base.Mana;}
        public new float GExp { get => base.GExp;}

        public Warrior()
        {
            base.Hp = 600;
            base.Life = base.Hp;

            base.Mp = 200;
            base.Mana = base.Mp;

            base.Exp = 0;
            base.Level = 1;

            base.Range = 1;
            base.Damage = 55;
            base.Armor = 3;

            base.Speed = 4;

            base.GExp = 30;
        }

        public Warrior(int level)
        {
            base.Hp = 600 + (level - 1) * 85;
            base.Life = base.Hp;

            base.Mp = 200 + (level - 1) * 40;
            base.Mana = base.Mp;

            base.Exp = 0;
            base.Level = level;

            base.Range = 1;
            base.Damage = 55 + (level - 1) * 8;
            base.Armor = 3 + (level - 1) * 0.8f;

            base.Speed = 4;

            base.GExp = 30 + (level - 1) * 10;
        }

        protected override void NextLvl()
        {
            base.Hp = 600 + (base.Level - 1) * 85;
            base.Life += base.Hp / 3;
            if(base.Life > base.Hp)
            {
                base.Life = base.Hp;
            }

            base.Mp = 200 + (base.Level - 1) * 40;
            base.Mana = base.Mp / 3;
            if (base.Mana > base.Mp)
            {
                base.Mana = base.Mp;
            }

            base.Damage = 55 + (base.Level - 1) * 8;
            base.Armor = 3 + (base.Level - 1) * 0.8f;

            base.GExp = 30 + (base.Level - 1) * 10;
        }
    }
}
