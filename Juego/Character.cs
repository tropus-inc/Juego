using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public abstract class Character
    {
        public delegate void nextLevelReached(Character character);
        public event nextLevelReached NextLevelReached;

        public delegate void dead(Character character, float gExp);
        public event dead Dead;

        private static float[] NextLevel =
        {
            200,
            400,
            480,
            600,
            620,
            640,
            660,
            680,
            800,
            820,
            840,
            900,
            1225,
            1250,
            1275,
            1300,
            1325,
            1400,
            1490,
            1500,
            1750,
            2000,
            2250,
            2500
        }; 

        private float mana;
        private float mp; //Mana máximo
        private float life;
        private float hp; //Vida máxima
        private float armor;
        private float speed;
        private float damage;
        private float range;
        private int level;
        private float exp;
        private float gExp; //Exp dada al morir

        protected float Hp { get => hp; set => hp = value; }
        protected float Mp { get => mp; set => mp = value; }
        protected int Level { get => level; set => level = value; }
        protected float Exp { get => exp; set => exp = value; }
        protected float Range { get => range; set => range = value; }
        protected float Life { get => life; set => life = value; }
        protected float Armor { get => armor; set => armor = value; }
        protected float Speed { get => speed; set => speed = value; }
        protected float Damage { get => damage; set => damage = value; }
        protected float Mana { get => mana; set => mana = value; }
        protected float GExp { get => gExp; set => gExp = value; }

        public void Defense(float damage)
        {
            life -= (float)((100 - (200 / Math.PI) * Math.Atan(armor / 22)) / 100) * damage;

            if(life <= 0)
            {
                Dead(this, gExp);
            }
        }

        public void Heal(float heal)
        {
            life += heal;
            if(life > hp)
            {
                life = hp;
            }
        }

        public void GainExp(float exp)
        {
            exp += exp;

            if(exp >= NextLevel[level - 1])
            {
                exp -= NextLevel[level - 1];
                level++;
                NextLvl();
                NextLevelReached(this);
            }
        }

        abstract protected void NextLvl();
    }
}
