using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Test
{
    public class DatingProfileTests
    {
        private DatingProfile profile;
        [SetUp]
        public void Setup()
        {
            string hobby = "Kickboxing";
            this.profile = new DatingProfile("Alper Sali", 21);
            this.profile.AddInterest(hobby);
        }
        [Test] 
        public void AddInterestsShouldAddCorrectly()
        {
            //Arrange
            string interest = "Dating";
            int expectedInterestCount = 2;

            //Act
            profile.AddInterest(interest);
            int interestCount = profile.Interests.Count();

            //Assert
            Assert.AreEqual(interestCount, expectedInterestCount, "Interest, added correctly");
            
        }
        [Test]  
        public void RemoveInterestsShouldRemoveCorrectly()
        {
            //Arrange
            string interest = "Kickboxing";
            int expectedInterestCount = 0;

            //Act
            profile.RemoveInterest(interest);
            int interestCount = profile.Interests.Count();

            //Assert
            Assert.AreEqual(interestCount, expectedInterestCount, "Interest, removed correctly");

        }
        [Test]
   public void RemoveInterestsShouldThrowExceptionNotFound()
        {
            //Arrange
            string fakeInterest = "test";
            string excpectionText = "Cannot find interest";
            //Assert
            var ex = Assert.Throws<FileNotFoundException>(() => profile.RemoveInterest(fakeInterest));
            Assert.AreEqual(excpectionText, ex.Message);
        }
    }
}
