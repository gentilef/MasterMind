using MasterMind;
using Xunit;

namespace MasterMindTest
{
    public class SolutionWithDynamicListTests
    {
        [Fact]
        public void No_Correct_Guessed_Color_ShouldReturn_0_0()
        {
            // Arrange
            var secretSequence = new[] { Color.Blue, Color.Blue, Color.Pink };
            var guessedSequence = new[] { Color.Green, Color.Green, Color.Green };

            // Act
            var score = SolutionWithDynamicListOfIndex.PlayMastermindRound(secretSequence, guessedSequence);

            // Assert
            Assert.Equal(0, score.positionAndColorCorrect);
            Assert.Equal(0, score.colorCorrect);
        }

        [Fact]
        public void One_Correct_Guessed_Color_ShouldReturn_0_1()
        {
            // Arrange
            var secretSequence = new[] { Color.Blue, Color.Blue, Color.Pink };
            var guessedSequence = new[] { Color.Green, Color.Green, Color.Blue };

            // Act
            var score = SolutionWithDynamicListOfIndex.PlayMastermindRound(secretSequence, guessedSequence);

            // Assert
            Assert.Equal(0, score.positionAndColorCorrect);
            Assert.Equal(1, score.colorCorrect);
        }

        [Fact]
        public void One_Correct_Guessed_Color_With_Position_ShouldReturn_1_0()
        {
            // Arrange
            var secretSequence = new[] { Color.Blue, Color.Blue, Color.Pink };
            var guessedSequence = new[] { Color.Blue, Color.Green, Color.Green };

            // Act
            var score = SolutionWithDynamicListOfIndex.PlayMastermindRound(secretSequence, guessedSequence);

            // Assert
            Assert.Equal(1, score.positionAndColorCorrect);
            Assert.Equal(0, score.colorCorrect);
        }

        [Fact]
        public void One_Correct_Guessed_Color_With_Position_And_One_Guessed_Color_ShouldReturn_1_1()
        {
            // Arrange
            var secretSequence = new[] { Color.Blue, Color.Blue, Color.Pink };
            var guessedSequence = new[] { Color.Blue, Color.Green, Color.Blue };

            // Act
            var score = SolutionWithDynamicListOfIndex.PlayMastermindRound(secretSequence, guessedSequence);

            // Assert
            Assert.Equal(1, score.positionAndColorCorrect);
            Assert.Equal(1, score.colorCorrect);
        }

        [Fact]
        public void Two_Correct_Guessed_Color_With_Position_And_Two_Guessed_Color_ShouldReturn_2_2()
        {
            // Arrange
            var secretSequence = new[] { Color.Blue, Color.Blue, Color.Pink, Color.Blue };
            var guessedSequence = new[] { Color.Blue, Color.Blue, Color.Blue, Color.Pink };

            // Act
            var score = SolutionWithDynamicListOfIndex.PlayMastermindRound(secretSequence, guessedSequence);

            // Assert
            Assert.Equal(2, score.positionAndColorCorrect);
            Assert.Equal(2, score.colorCorrect);
        }
    }
}