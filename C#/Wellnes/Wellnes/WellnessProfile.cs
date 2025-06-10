using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wellnes
{
    public class WellnessProfile
    {
        public string Name { get; set; }
        public DateTime MembershipStart { get; set; }
        public List<string> PhysicalGoals {  get; set; }
        public Dictionary<string, bool> DietPreferences {  get; set; }
        public List<string> MentalWellbeingActivities {  get; set; }

        public WellnessProfile(string name, DateTime membershipStart, List<string> physicalGoals, Dictionary<string, bool> dietPreferences, List<string> mentalWellbeingActivities)
        {
            Name = name;
            MembershipStart = membershipStart;
            PhysicalGoals = new List<string>();
            DietPreferences = new Dictionary<string, bool>();
            MentalWellbeingActivities = new List<string>();
        }
        public void AddPhysicalGoal(string goal)
        {
            PhysicalGoals.Add(goal);
        }
        public void RemovePhysicalGoal(string goal) 
        { 
            PhysicalGoals.Remove(goal); 
        }
        public void UpdateDietPreference(string diet, bool isActive)
        {
            DietPreferences[diet] = isActive;
        }
        public void AddMentalActivity(string activity)
        {
            MentalWellbeingActivities.Add(activity);
        }
        public void RemoveMentalActivity(string activity)
        {
            MentalWellbeingActivities.Remove(activity);
        }
        public string GetFullProfile()
        {
            string activity = string.Join(" ", MentalWellbeingActivities);
            return $"Name: {Name}\nMembershipStart: {MembershipStart}\nPhysicalGoals: {PhysicalGoals}\nDietPreferences: {DietPreferences}\nMentalWellbeingActivities: { MentalWellbeingActivities}";
        }
    }
}
