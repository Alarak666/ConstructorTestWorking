using Data.Data.TestCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class ListTestTests
    {
        [Fact]
        public void Constructor_ShouldInitializeLists()
        {
            // Arrange
            // No additional arrangements needed

            // Act
            var listTest = new ListTest();

            // Assert
            Assert.NotNull(listTest.Answers);
            Assert.NotNull(listTest.CorectAnswers);
            Assert.Equal(0, listTest.Answers.Count);
            Assert.Equal(0, listTest.CorectAnswers.Count);
        }

        [Fact]
        public void Constructor_ShouldSetQuestionAndPoint()
        {
            // Arrange
            var question = "What is the capital of France?";
            var point = 10;

            // Act
            var listTest = new ListTest
            {
                Question = question,
                Point = point
            };

            // Assert
            Assert.Equal(question, listTest.Question);
            Assert.Equal(point, listTest.Point);
        }

        [Fact]
        public void AddAnswer_ShouldAddAnswerToList()
        {
            // Arrange
            var listTest = new ListTest();
            var answer = "Paris";

            // Act
            listTest.Answers.Add(answer);

            // Assert
            Assert.Equal(1, listTest.Answers.Count);
            Assert.Equal(answer, listTest.Answers[0]);
        }

        [Fact]
        public void AddCorrectAnswer_ShouldAddCorrectAnswerToList()
        {
            // Arrange
            var listTest = new ListTest();
            var correctAnswer = "Paris";

            // Act
            listTest.CorectAnswers.Add(correctAnswer);

            // Assert
            Assert.Equal(1, listTest.CorectAnswers.Count);
            Assert.Equal(correctAnswer, listTest.CorectAnswers[0]);
        }
    }
}
