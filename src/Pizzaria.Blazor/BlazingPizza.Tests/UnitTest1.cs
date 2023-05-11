namespace BlazingPizza.Tests;

public class UnitTest1
{
#if !DEBUG
   [Fact]
#endif
    public void Test1() => Assert.True(true, "Corrected Test");
}
