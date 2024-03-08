namespace Lab2Tests
{
    public class Anagram_Test
    {
        [Theory]
        [InlineData("listen", "silent", true)]
        [InlineData("hello", "world", false)]   
        [InlineData("", "", true)]             
        public void IsAnagram_ShouldReturnCorrectResult(string s1, string s2, bool expectedResult)
        {
            // Arrange
            var ClassInstance = new Lab2.Lab2();

            // Act
            var result = ClassInstance.IsAnagram(s1, s2);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
    public class GetTimeOfDay_Test
    {
        [Theory]
        [InlineData("2024-03-08 03:00:00", "Night")] 
        [InlineData("2024-03-08 08:00:00", "Morning")] 
        [InlineData("2024-03-08 13:00:00", "Noon")] 
        [InlineData("2024-03-08 20:00:00", "Evening")] 
        public void GetTimeOfDay_ShouldReturnCorrectResult(string inputDateTimeString, string expectedTimeOfDay)
        {
            // Arrange
            var inputDateTime = DateTime.Parse(inputDateTimeString);
            var ClassInstance = new Lab2.Lab2();

            // Act
            var result = ClassInstance.GetTimeOfDay(inputDateTime);

            // Assert
            Assert.Equal(expectedTimeOfDay, result);
        }
    }
}
