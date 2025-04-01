using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items.Equipables
{
    public class Armor : IEquipable
    {
        public string Name { get; set; }
        public int def { get; set; }

        public void Equip(Player player)
        {
            player.EquippedArmor = this;
            player.Def += def;
        }

        public void Unequip(Player player)
        {
            if (player.EquippedWeapon == this)
            {
                player.EquippedWeapon = null;
                player.Def -= def;
            }
        }
    }
}
