using Nito.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMTG.Models
{
    public class Deck
    {
        public Deque<Card> Deque { get; set; }

        public Deck()
        {
            this.Deque = new();
        }

        public List<Card> Draw(int amount = 1)
        {
            List<Card> ret = new();

            for (int i = 0; i < amount; i++)
            {
                if (Deque.Count > 0)
                {
                    ret.Add(Deque.RemoveFromFront());
                }
            }

            return ret;
        }

        public List<Card> LookTop(int amount = 1)
        {
            return Deque.Take(amount).ToList();
        }

        public void PutOnTop(Card card)
        {
            Deque.AddToFront(card);
        }

        public void PutOnBottom(Card card)
        {
            Deque.AddToBack(card);
        }

        public void Shuffle(Random rand)
        {
            for (int i = Deque.Count - 1; i > 0; i--)
            {
                int j = rand.Next(0, i + 1);

                var temp = Deque[i];
                Deque[i] = Deque[j];
                Deque[j] = temp;
            }
        }
    }
}