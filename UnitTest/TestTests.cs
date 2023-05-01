using Data.Data.TestCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class TestTests
    {
        [Fact]
        public void TestConstructor_InitializesProperties()
        {
            // Arrange
            var id = Guid.NewGuid();
            var author = "John Smith";
            var title = "Test Title";
            var infoTestTaker = "Test Taker Info";
            var testName = "Test Name";
            var createdName = "Created Name";
            var description = "Test Description";
            var maxPoint = 100.0m;
            var countQuestion = 10;
            var percent = 80.0m;

            // Act
            var test = new Test
            {
                id = id,
                Author = author,
                Title = title,
                InfoTestTaker = infoTestTaker,
                TestName = testName,
                CreatedName = createdName,
                Description = description,
                MaxPoint = maxPoint,
                CountQuestion = countQuestion,
                Percent = percent
            };

            // Assert
            Assert.Equal(id, test.id);
            Assert.Equal(author, test.Author);
            Assert.Equal(title, test.Title);
            Assert.Equal(infoTestTaker, test.InfoTestTaker);
            Assert.Equal(testName, test.TestName);
            Assert.Equal(createdName, test.CreatedName);
            Assert.Equal(description, test.Description);
            Assert.Equal(maxPoint, test.MaxPoint);
            Assert.Equal(countQuestion, test.CountQuestion);
            Assert.Equal(percent, test.Percent);
            Assert.NotNull(test.listTests);
        }
    }
}
