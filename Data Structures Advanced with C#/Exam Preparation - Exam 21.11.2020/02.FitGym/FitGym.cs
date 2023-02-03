namespace _02.FitGym
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FitGym : IGym
    {
        private Dictionary<int, Member> members;

        private Dictionary<int, Trainer> trainers;

        public FitGym()
        {
            this.members = new Dictionary<int, Member>();
            this.trainers = new Dictionary<int, Trainer>();
        }
        public void AddMember(Member member)
        {
            if (this.members.ContainsKey(member.Id))
            {
                throw new ArgumentException();
            }

            this.members.Add(member.Id, member);
        }

        public void HireTrainer(Trainer trainer)
        {
            if (this.trainers.ContainsKey(trainer.Id))
            {
                throw new ArgumentException();
            }

            this.trainers.Add(trainer.Id, trainer);
        }

        public void Add(Trainer trainer, Member member)
        {
            if (!this.members.ContainsKey(member.Id))
            {
                this.members.Add(member.Id, member);
            }

            if (!this.trainers.ContainsKey(trainer.Id))
            {
                throw new ArgumentException();
            }

            if (member.Trainer != null)
            {
                throw new ArgumentException();
            }

            trainer.Members.Add(member);
            member.Trainer = trainer;
        }

        public bool Contains(Member member)
        {
            return this.members.ContainsKey(member.Id);
        }

        public bool Contains(Trainer trainer)
        {
            return this.trainers.ContainsKey(trainer.Id);
        }

        public Trainer FireTrainer(int id)
        {
            if (!this.trainers.ContainsKey(id))
            {
                throw new ArgumentException();
            }

            var trainer = this.trainers[id];

            this.trainers.Remove(id);
            return trainer;
        }

        public Member RemoveMember(int id)
        {
            if (!this.members.ContainsKey(id))
            {
                throw new ArgumentException();
            }

            var member = this.members[id];

            this.members.Remove(id);

            return member;
        }

        public int MemberCount => this.members.Count;
        public int TrainerCount => this.trainers.Count;

        public IEnumerable<Member> 
            GetMembersInOrderOfRegistrationAscendingThenByNamesDescending()
        {
            return this.members.Values
                .OrderBy(m => m.RegistrationDate)
                .ThenByDescending(m => m.Name);
        }

        public IEnumerable<Trainer> GetTrainersInOrdersOfPopularity()
        {
            return this.trainers.Values.OrderBy(t => t.Popularity);
        }

        public IEnumerable<Member> 
            GetTrainerMembersSortedByRegistrationDateThenByNames(Trainer trainer)
        {
            return trainer.Members
                .OrderBy(m => m.RegistrationDate)
                .ThenBy(m => m.Name);
        }

        public IEnumerable<Member> 
            GetMembersByTrainerPopularityInRangeSortedByVisitsThenByNames(int lo, int hi)
        {
            return this.members.Values
                .Where(m => m.Trainer.Popularity >= lo && m.Trainer.Popularity <= hi)
                .OrderBy(m => m.Visits)
                .ThenBy(m => m.Name);
        }

        public Dictionary<Trainer, HashSet<Member>> 
            GetTrainersAndMemberOrderedByMembersCountThenByPopularity()
        {
            var dictionary = new Dictionary<Trainer, HashSet<Member>>();

            foreach (var trainer in this.trainers.Values)
            {
                dictionary.Add(trainer, trainer.Members);
            }

            return dictionary
                .OrderBy(kvp => kvp.Key.Members.Count)
                .ThenBy(kvp => kvp.Key.Popularity).ToDictionary(x => x.Key, y => y.Value);
        }
    }
}