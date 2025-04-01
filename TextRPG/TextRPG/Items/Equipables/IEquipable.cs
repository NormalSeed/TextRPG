using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items.Equipables
{
    public interface IEquipable
    {
        string Name { get; set; }
        void Equip(Player player);
        void Unequip(Player player);
    }
}
