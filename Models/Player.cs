using Nito.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMTG.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Life { get; set; }

        public List<Card> Hand { get; set; }
        public Deck Library { get; set; }
        public List<Card> Graveyard { get; set; }
        public List<Card> Exile { get; set; }

        public Player()
        {
            this.Hand = new();
            this.Library = new();
            this.Graveyard = new();
            this.Exile = new();
        }
    }
}
