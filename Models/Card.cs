using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMTG.Models
{
    public class Card
    {
        public string Name { get; set; }
        public CardType Type { get; set; }
        public string CastingCost { get; set; }
        public Player Owner { get; set; }
    }

    [Flags]
    public enum CardType
    {
        Artifact = 0b_0000_0001,
        Creature = 0b_0000_0010,
        Enchantment = 0b_0000_0100,
        Instant = 0b_0000_1000,
        Land = 0b_0001_0000,
        Planeswalker = 0b_0010_0000,
        Sorcery = 0b_0100_0000,
        Tribal = 0b_1000_0000,
        Permanent = Artifact | Creature | Enchantment | Land | Planeswalker
    }
}
