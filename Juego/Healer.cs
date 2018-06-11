using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class Healer : Character
    {
        public new float Damage { get => base.Damage / 10; }
        public new float Heal { get => base.Damage; }
        public new float Hp { get => base.Hp; }
        public new float Mp { get => base.Mp; }
        public new int Level { get => base.Level; }
        public new float Exp { get => base.Exp; }
        public new float Range { get => base.Range; }
        public new float Life { get => base.Life; }
        public new float Armor { get => base.Armor; }
        public new float Speed { get => base.Speed; }
        public new float Mana { get => base.Mana; }
        public new float GExp { get => base.GExp; }


        public Healer()
        {
            base.Hp = 200;
            base.Life = base.Hp;

            base.Mp = 250;
            base.Mana = base.Mp;

            base.Exp = 0;
            base.Level = 1;

            base.Range = 2;
            base.Damage = 35;
            base.Armor = 3;

            base.Speed = 4;

            base.GExp = 30;
        }

        public Healer(int level)
        {
            base.Hp = 200 + (level - 1) * 50;
            base.Life = base.Hp;

            base.Mp = 250 + (level - 1) * 60;
            base.Mana = base.Mp;

            base.Exp = 0;
            base.Level = level;

            base.Range = 2;
            base.Damage = 38 + (level - 1) * 5;
            base.Armor = 0.8f + (level - 1) * 0.2f;

            base.Speed = 2;

            base.GExp = 20 + (level - 1) * 7.2f;
        }

        protected override void NextLvl()
        {
            base.Hp = 200 + (base.Level - 1) * 50;
            base.Life += base.Hp / 3;
            if (base.Life > base.Hp)
            {
                base.Life = base.Hp;
            }

            base.Mp = 250 + (base.Level - 1) * 40;
            base.Mana = base.Mp / 3;
            if (base.Mana > base.Mp)
            {
                base.Mana = base.Mp;
            }

            base.Damage = 38 + (base.Level - 1) * 8;
            base.Armor = 3 + (base.Level - 1) * 0.8f;

            base.GExp = 30 + (base.Level - 1) * 10;
        }
    }
}
