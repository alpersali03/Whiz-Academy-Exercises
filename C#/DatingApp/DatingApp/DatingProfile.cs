using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp
{
    public class DatingProfile
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Interests { get; set; }

        public DatingProfile(string name, int age)
        {
            Name = name;
            Age = age;
            Interests = new List<string>();
        }
        public void AddInterest(string interest)
        {
            Interests.Add(interest);
        
        }
        public void RemoveInterest(string interest)
        {
            if (Interests.Contains(interest))
            {
                Interests.Remove(interest);
            }
            else
            {
                throw new FileNotFoundException("Cannot find interest");
            }
        }
        public bool Matches(DatingProfile otherProfile)
        {
            foreach(string interest in  Interests)
            {
                if (otherProfile.Interests.Contains(interest))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsEligibleForDating(int minAge, int maxAge)
        {
            if (Age >= minAge && Age <= maxAge)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetProfileSummary()
        {
            string interests = string.Join(" ", Interests);
            return $"Name: {Name}\nAge: {Age}\nInterests: {interests}";
        }
    }
}
