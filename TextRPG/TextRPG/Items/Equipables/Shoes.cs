using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items.Equipables
{
    public class Shoes : IEquipable
    {
        public string Name { get; set; }
        public int spd { get; set; }

        public void Equip(Player player)
        {
            player.EquipItem(this);
            player.Speed += spd;
        }

        public void Unequip(Player player)
        {
            if (player.EquippedWeapon == this)
            {
                player.EquippedWeapon = null;
                player.Speed -= spd;
            }
        }
    }
}
