using Microsoft.VisualStudio.TestPlatform.CoreUtilities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kickboxing.Test
{
    public class FighterProfileTest
    {
        private FighterProfile fighterProfile;

        [SetUp]
        public void Setup()
        {
            this.fighterProfile = new FighterProfile("Alper Wick", "Lightweight");
        }
        [Test]

        public void ShouldAddTecniqueCorrectly()
        {
            //Arrange
            string technique = "Middle Kick";
            int expectedTechniqueCount = 1;
            //Act
            fighterProfile.AddTechnique(technique);
            int techniqueCount = fighterProfile.Techniques.Count();
            //Assert
            Assert.AreEqual(expectedTechniqueCount, techniqueCount, "Technique added correctly");


        }
        [Test]

        public void ShouldRemoveTecniqueCorrectly()
        {
            //Arrange
            string technique = "High Kick";
            int expectedTechniqueCount = 0;
            //Act
            fighterProfile.RemoveTechnique(technique); // nqma tazi tehnika - nishto nqma da stnae
            int removedTechnique = fighterProfile.Techniques.Count();
            //Assert
            Assert.AreEqual(expectedTechniqueCount, removedTechnique, "Technique was not changed");


        }
        [Test]

        public void ShouldNotRemoveTechniqueCorrectly()
        {
            //Arrange
            string technique = "Low kick";
            int removedTechniqueCount = 0;
            //Act
            
            fighterProfile.RemoveTechnique(technique);
            int removedTechnique = fighterProfile.Techniques.Count();
            //Assert
            Assert.AreEqual(removedTechniqueCount, removedTechnique, "Technique removed correctly");


        }
        [Test]
        public void ShouldCompareFightersCorrectly()
        {
            //Arrange
            string firstTechnique = "High Kick";
            string secondTechnique = "High Kick";
            var firstKickBoxer = new FighterProfile("Alper", "Lightweight");
            var secondKickBoxer = new FighterProfile("Ivan", "Lightweight");
            firstKickBoxer.Techniques.Add(firstTechnique);
            secondKickBoxer.Techniques.Add(secondTechnique);
            bool expectedResult = true;
            //Act
            var comparison = firstKickBoxer.HasCommonTechnique(secondKickBoxer);
            //Assert
            Assert.AreEqual(expectedResult, comparison, "Technique was not changed");

        }
        [Test]
        public void ShouldNotCompareFightersCorrectly()
        {
            //Arrange
            string firstTechnique = "High Kick";
            string secondTechnique = "Low Kick";
            var firstKickBoxer = new FighterProfile("Alper", "Lightweight");
            var secondKickBoxer = new FighterProfile("Ivan", "Lightweight");
            firstKickBoxer.Techniques.Add(firstTechnique);
            secondKickBoxer.Techniques.Add(secondTechnique);
            bool expectedResult = false;
            //Act
            var comparison = firstKickBoxer.HasCommonTechnique(secondKickBoxer);
            //Assert
            Assert.AreEqual(expectedResult, comparison, "Technique was not changed");

        }
        [Test]

        public void ShouldCheckWeightClassCorrectly()
        {
            //Arrange
            var firstKickBoxer = new FighterProfile("Alper", "Light weight");
            string weightClass = "Light weight";
            bool checkingClass = true;
            //Act

            var checkingWeightClass = firstKickBoxer.IsEligibleForFight(weightClass);
            
            //Assert
            Assert.AreEqual(checkingClass, checkingWeightClass, "Fighter can fight on this category");


        }
        [Test]
        public void ShouldNotCheckWeightClassCorrectly()
        {
            //Arrange
            var firstKickBoxer = new FighterProfile("Alper", "Light weight");
            string weightClass = "Middle weight";
            bool checkingClass = false;
            //Act

            var checkingWeightClass = firstKickBoxer.IsEligibleForFight(weightClass);

            //Assert
            Assert.AreEqual(checkingClass, checkingWeightClass, "Fighter can fight on this category");


        }
    }
}
