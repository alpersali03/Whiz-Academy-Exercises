using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kickboxing
{
    public class FighterProfile
    {
        public string Name { get; set; }
        public string WeightClass { get; set; }
        public List<string> Techniques { get; set; }

        public FighterProfile(string name, string weightClass)
        {
            this.Name = name;
            this.WeightClass = weightClass;
            Techniques = new List<string>();
        }
        public void AddTechnique(string technique)
        {
            Techniques.Add(technique);
        }

        public void RemoveTechnique(string technique) 
        { 
            if (Techniques.Contains(technique))
            {
                Techniques.Remove(technique);
            }
            
        }

        public bool HasCommonTechnique(FighterProfile otherFighter) 
        {
            foreach (string technique in Techniques)
            {
                if (otherFighter.Techniques.Contains(technique))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsEligibleForFight(string requiredWeightClass)
        {
            if(WeightClass == requiredWeightClass)
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
            string interests = string.Join(" ", Techniques);
            return $"Name: {Name}\nAge: {WeightClass}\nInterests: {Techniques}";
        }
    }
    
}
