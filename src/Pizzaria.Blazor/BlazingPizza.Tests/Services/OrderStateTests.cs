namespace BlazingPizza.Tests.Services;
using Xunit;

public class OrderStateTests
{
    [Fact()]
    public void ConfirmConfigurePizzaDialogTest()
    {
        //Arrange
        var os = new OrderState();

        //Act
        os.ShowConfigurePizzaDialog(new PizzaSpecial());
        os.ConfirmConfigurePizzaDialog();

        //Assert
        Assert.NotNull(os);
        Assert.NotNull(os.Order);
        Assert.NotNull(os.Order.Pizzas);
        Assert.False(os.ShowingConfigureDialog);
        Assert.True(os.Order.Pizzas.Count >= 1);
    }

    [Fact()]
    public void CancelConfigurePizzaDialogTest()
    {
        //Arrange
        var os = new OrderState();
        //Act
        os.ConfirmConfigurePizzaDialog();

        //Assert
        Assert.NotNull(os);
        Assert.Null(os.ConfiguringPizza);
        Assert.NotNull(os.Order);
        Assert.NotNull(os.Order.Pizzas);
        Assert.False(os.ShowingConfigureDialog);
    }

    [Fact()]
    public void ShowConfigurePizzaDialogTest()
    {
        //Arrange
        var os = new OrderState();
        //Act
        os.ConfirmConfigurePizzaDialog();

        //Assert
        Assert.NotNull(os);
        Assert.Null(os.ConfiguringPizza);
        Assert.NotNull(os.Order);
        Assert.NotNull(os.Order.Pizzas);
        Assert.False(os.ShowingConfigureDialog);
    }

    [Fact()]
    public void RemoveConfiguredPizzaTest()
    {
        //Arrange
        var os = new OrderState();

        //Act        
        os.RemoveConfiguredPizza(new Pizza());

        //Assert
        Assert.NotNull(os);
        Assert.Null(os.ConfiguringPizza);
        Assert.NotNull(os.Order);
        Assert.NotNull(os.Order.Pizzas);
        Assert.False(os.ShowingConfigureDialog);
    }

    [Fact()]
    public void CancelConfigurePizzaDialogTest1()
    {
        //Arrange
        var os = new OrderState();

        //Act        
        os.RemoveConfiguredPizza(new Pizza());

        //Assert
        Assert.NotNull(os);
        Assert.Null(os.ConfiguringPizza);
        Assert.NotNull(os.Order);
        Assert.NotNull(os.Order.Pizzas);
        Assert.False(os.ShowingConfigureDialog);
    }
}
