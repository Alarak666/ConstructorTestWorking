using Data.Data.InformationData;
using Data.Data.TestCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class UserAnswerTests
    {
        [Fact]
        public void UserAnswer_Constructor_SetsProperties()
        {
            // Arrange
            string question = "What is your favorite color?";
            List<string> answer = new List<string> { "Red", "Green", "Blue" };
            List<bool> isSelected = new List<bool> { true, false, true };

            // Act
            var userAnswer = new UserAnswer()
            {
                Answer = answer, 
                IsSelected = isSelected,
                Question = question
            };

            // Assert
            Assert.Equal(question, userAnswer.Question);
            Assert.Equal(answer, userAnswer.Answer);
            Assert.Equal(isSelected, userAnswer.IsSelected);
        }

        [Fact]
        public void UserAnswer_DefaultConstructor_SetsEmptyLists()
        {
            // Arrange

            // Act
            var userAnswer = new UserAnswer();

            // Assert
            Assert.Empty(userAnswer.Question);
            Assert.Empty(userAnswer.Answer);
            Assert.Empty(userAnswer.IsSelected);
        }
    }
}