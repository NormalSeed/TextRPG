using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Player
    {
        // 플레이어 정보 : 직업, 힘, 민첩, 매력, 투지
        private string job;
        public string Job { get { return job; } set { job = value; } }

        private int power;
        public int Power { get { return power; } set { power = value; } }

        private int speed;
        public int Speed { get { return speed; } set { speed = value; } }

        private int charm;
        public int Charm { get { return charm; } set { charm = value; } }

        public int hustle;
        public int Hustle { get { return hustle; } set { hustle = value; } }
    }
}
