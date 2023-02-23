namespace ConversionLabs.UnitTests;

public class ObjectToStringTests
{
    [Theory]
    [InlineData("1234", "1234")]
    [InlineData(1234, "1234")]
    [InlineData(null, "")]
    public void ConvertUsingAs_ValidString(object? val, string expectedVal) {
        //Arrange
        var sut = new ObjectToStringConverters();

        //Act
        var result = sut.UsingAs(val);

        //Assert
        Assert.IsType<string>(result);
        Assert.Equal(expectedVal, result);
    }

    [Theory]
    [InlineData("1234", "1234")]
    [InlineData(1234, "1234")]
    [InlineData(null, "")]
    public void ConvertUsingCasting_ValidString(object? val, string expectedVal) {
        //Arrange
        var sut = new ObjectToStringConverters();

        //Act
        var result = sut.UsingCasting(val);

        //Assert
        Assert.IsType<string>(result);
        Assert.Equal(expectedVal, result);
    }

    [Theory]
    [InlineData("1234", "1234")]
    [InlineData(1234, "1234")]
    [InlineData(null, "")]
    public void ConvertUsingConvertToString_ValidString(object? val, string expectedVal) {
        //Arrange
        var sut = new ObjectToStringConverters();

        //Act
        var result = sut.UsingConvertToString(val);

        //Assert
        Assert.IsType<string>(result);
        Assert.Equal(expectedVal, result);
    }


    [Theory]
    [InlineData("1234", "1234")]
    [InlineData(1234, "1234")]
    [InlineData(null, "")]
    public void ConvertUsingToString_ValidString(object? val, string expectedVal) {
        //Arrange
        var sut = new ObjectToStringConverters();

        //Act
        var result = sut.UsingToString(val);

        //Assert
        Assert.IsType<string>(result);
        Assert.Equal(expectedVal, result);
    }
}