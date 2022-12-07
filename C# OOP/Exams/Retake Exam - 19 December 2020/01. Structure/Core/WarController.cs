namespace WarCroft.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Constants;
    using Entities.Characters;
    using Entities.Characters.Contracts;
    using Entities.Items;

    public class WarController
    {
        private readonly List<Character> characters;
        private readonly List<Item> items;

        public WarController()
        {
            this.characters = new List<Character>();
            this.items = new List<Item>();
        }

        public string JoinParty(string[] args)
        {
            var characterType = args[0];
            var name = args[1];

            Character character = null;

            if (characterType == "Warrior")
            {
                character = new Warrior(name);
            }
            else if (characterType == "Priest")
            {
                character = new Priest(name);
            }
            else
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InvalidCharacterType, characterType));
            }

            this.characters.Add(character);

            return String.Format(SuccessMessages.JoinParty, name);
        }

        public string AddItemToPool(string[] args)
        {
            var itemName = args[0];

            Item item;

            if (itemName == nameof(FirePotion))
            {
                item = new FirePotion();
            }
            else if (itemName == nameof(HealthPotion))
            {
                item = new HealthPotion();
            }
            else
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InvalidItem, itemName));
            }

            this.items.Add(item);

            return String.Format(SuccessMessages.AddItemToPool, itemName);
        }

        public string PickUpItem(string[] args)
        {
            var characterName = args[0];
            var character = this.characters.FirstOrDefault(c => c.Name == characterName);

            if (character == null)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.CharacterNotInParty, characterName));
            }

            if (!this.items.Any())
            {
                throw new InvalidOperationException(ExceptionMessages.ItemPoolEmpty);
            }

            Item item = this.items.Last();
            this.items.Remove(item);

            character.Bag.AddItem(item);

            return String.Format(SuccessMessages.PickUpItem, characterName, item.GetType().Name);
        }

        public string UseItem(string[] args)
        {
            var characterName = args[0];
            var itemName = args[1];

            var character = this.characters.FirstOrDefault(c => c.Name == characterName);

            if (character == null)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.CharacterNotInParty, characterName));
            }

            var item = character.Bag.GetItem(itemName);
            character.UseItem(item);

            return String.Format(SuccessMessages.UsedItem, characterName, itemName);
        }

        public string GetStats()
        {
            var sortedCharacters = this.characters
                .OrderByDescending(c => c.IsAlive)
                .ThenByDescending(c => c.Health);

            return String.Join(Environment.NewLine, sortedCharacters);
        }

        public string Attack(string[] args)
        {
            var attackerName = args[0];
            var receiverName = args[1];

            var attacker = this.characters.FirstOrDefault(c => c.Name == attackerName);
            var receiver = this.characters.FirstOrDefault(c => c.Name == receiverName);

            if (attacker == null)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.CharacterNotInParty, attackerName));
            }

            if (receiver == null)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.CharacterNotInParty, receiverName));
            }

            if (attacker.GetType().Name == nameof(Priest))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.AttackFail, attackerName));
            }   

            Warrior warrior = (Warrior)this.characters.FirstOrDefault(c => c.Name == attackerName);

            warrior.Attack(receiver);

            var sb = new StringBuilder();

            sb.AppendLine(String.Format(SuccessMessages.AttackCharacter, 
                    attacker.Name, 
                    receiver.Name, 
                    attacker.AbilityPoints, 
                    receiver.Name, 
                    receiver.Health, 
                    receiver.BaseHealth,
                    receiver.Armor, 
                    receiver.BaseArmor));

            if (!receiver.IsAlive)
            {
                sb.AppendLine(String.Format(SuccessMessages.AttackKillsCharacter, receiver.Name));
            }

            return sb.ToString().TrimEnd();
        }

        public string Heal(string[] args)
        {
            var healerName = args[0];
            var healerReceiverName = args[1];

            var healer = this.characters.FirstOrDefault(h => h.Name == healerName);
            var healerReceiver = this.characters.FirstOrDefault(c => c.Name == healerReceiverName);

            if (healer == null)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.CharacterNotInParty, healerName));
            }

            if (healerReceiver == null)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.CharacterNotInParty, healerReceiverName));
            }

            if (healer.GetType().Name != nameof(Priest))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.HealerCannotHeal, healerName));
            }

            Priest priest = (Priest)this.characters.FirstOrDefault(h => h.Name == healerName);

            priest.Heal(healerReceiver);

            return String.Format(SuccessMessages.HealCharacter, 
                healer.Name, 
                healerReceiver.Name, 
                healer.AbilityPoints, 
                healerReceiver.Name, 
                healerReceiver.Health);
        }
    }
}
