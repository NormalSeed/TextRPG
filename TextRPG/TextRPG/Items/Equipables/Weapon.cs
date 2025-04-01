using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items.Equipables
{
    public class Weapon : IEquipable
    {
        public string Name { get; set; }
        public int atk { get; set; }

        public void Equip(Player player)
        {
            player.EquippedWeapon = this;
            player.Power += atk;
        }

        public void Unequip(Player player) 
        {
            if (player.EquippedWeapon == this)
            {
                player.EquippedWeapon = null;
                player.Power -= atk;
            }
        }
    }
}
