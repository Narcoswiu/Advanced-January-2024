using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Persons> people;

        public Family()
        {
            people = new List<Persons>();
        }

        public List<Persons> People
        {
            get
            {
                return this.people;
            }
            set
            {
                this.people = value;
            }
        }

        public void AddMember(Persons person)
        {
            this.people.Add(person);
        }

        public Persons GetOldestMember()
        {
            return this.people
                .OrderByDescending(p => p.Age)
                .FirstOrDefault();
        }
    }
}
