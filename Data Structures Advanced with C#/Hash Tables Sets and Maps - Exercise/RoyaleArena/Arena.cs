namespace RoyaleArena
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Arena : IArena
    {
        private Dictionary<int, BattleCard> cards;

        public Arena()
        {
            this.cards = new Dictionary<int, BattleCard>();
        }

        public int Count => this.cards.Count;

        public void Add(BattleCard card)
        {
            if (!this.cards.ContainsKey(card.Id))
            {
                this.cards.Add(card.Id, card);
            }
        }

        public void ChangeCardType(int id, CardType type)
        {
            if (!this.cards.ContainsKey(id))
            {
                throw new InvalidOperationException();
            }

            this.cards[id].Type = type;
        }

        public bool Contains(BattleCard card)
        {
            return this.cards.ContainsKey(card.Id);
        }

        public IEnumerable<BattleCard> FindFirstLeastSwag(int n)
        {
            if (n > this.Count)
            {
                throw new InvalidOperationException();
            }

            return this.cards
                .Select(kvp => kvp.Value)
                .OrderBy(bc => bc.Swag)
                .ThenBy(bc => bc.Id)
                .Take(n);
        }

        public IEnumerable<BattleCard> GetAllInSwagRange(double lo, double hi)
        {
            return this.cards
                .Where(kvp => kvp.Value.Swag >= lo && kvp.Value.Swag <= hi)
                .Select(kvp => kvp.Value)
                .OrderBy(bc => bc.Swag);
        }

        public IEnumerable<BattleCard> GetByCardType(CardType type)
        {
            var battleCards = this.cards.Where(kvp => kvp.Value.Type.Equals(type))
                .Select(kvp => kvp.Value);
                
            if (!battleCards.Any())
            {
                throw new InvalidOperationException();
            }

            return battleCards.OrderByDescending(bc => bc.Damage)
                .ThenBy(bc => bc.Id);

        }

        public IEnumerable<BattleCard> GetByCardTypeAndMaximumDamage(CardType type, double damage)
        {
            var result = cards.Values
                .Where(bc => bc.Type.Equals(type) && bc.Damage <= damage)
                .OrderByDescending(c => c.Damage)
                .ThenBy(c => c.Id);

            if (!result.Any())
                throw new InvalidOperationException();

            return result;
        }

        public BattleCard GetById(int id)
        {
            var card = this.cards.Values
                .FirstOrDefault(bc => bc.Id == id);

            if (card == null)
            {
                throw new InvalidOperationException();
            }

            return card;
        }

        public IEnumerable<BattleCard> GetByNameAndSwagRange(string name, double lo, double hi)
        {
            var battleCards = this.cards
                .Values
                .Where(bc => bc.Name == name && bc.Swag >= lo && bc.Swag < hi)
                .OrderByDescending(bc => bc.Swag)
                .ThenBy(bc => bc.Id);

            if (!battleCards.Any())
            {
                throw new InvalidOperationException();
            }

            return battleCards;
        }

        public IEnumerable<BattleCard> GetByNameOrderedBySwagDescending(string name)
        {
            var battleCards = this.cards
                .Values
                .Where(bc => bc.Name == name)
                .OrderByDescending(bc => bc.Damage)
                .ThenBy(bc => bc.Id);

            if (!battleCards.Any())
            {
                throw new InvalidOperationException();
            }

            return battleCards;
        }

        public IEnumerable<BattleCard> GetByTypeAndDamageRangeOrderedByDamageThenById(CardType type, int lo, int hi)
        {
            var battleCards = this.cards
                .Where(kvp => kvp.Value.Type.Equals(type) && kvp.Value.Damage >= lo && kvp.Value.Damage <= hi)
                .Select(kvp => kvp.Value)
                .ToArray();

            if (!battleCards.Any())
            {
                throw new InvalidOperationException();
            }

            return battleCards.OrderByDescending(bc => bc.Damage)
               .ThenBy(bc => bc.Id);
        }

        public IEnumerator<BattleCard> GetEnumerator()
        {
            foreach (var card in cards)
            {
                yield return card.Value;
            }
        }

        public void RemoveById(int id)
        {
            if (!this.cards.ContainsKey(id))
            {
                throw new InvalidOperationException();
            }

            this.cards.Remove(id);
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}