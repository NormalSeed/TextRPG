using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Items.Equipables;

namespace TextRPG
{
    public class Player
    {
        // 플레이어 정보 : 직업, 체력, 힘, 방어력,  민첩, 매력, 투지
        private string? job;
        public string Job { get; set; }

        private int hp;
        public int HP { get; set; }

        private int power;
        public int Power { get; set; }

        private int def;
        public int Def { get; set; }

        private int speed;
        public int Speed { get; set; }

        private int charm;
        public int Charm { get; set; }

        public int hustle;
        public int Hustle { get; set; }

        public IEquipable? EquippedWeapon { get; set; }
        public IEquipable? EquippedArmor { get; set; }
        public IEquipable? EquippedShoes { get; set; }
    }
}
