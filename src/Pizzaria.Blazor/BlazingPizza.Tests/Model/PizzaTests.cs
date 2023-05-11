namespace BlazingPizza.Tests.Model;

using Xunit;


public class PizzaTests
{
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(0, 1, 0)]
    [InlineData(1, 0, 0)]
    [InlineData(1, 12, 1)]
    [InlineData(10, 12, 10)]
    [InlineData(5, 12, 5)]
    [InlineData(5, 120, 50)]
    [InlineData(12.75, 12, 12.75)]
    [InlineData(12.75, 9, 9.56)]
    [InlineData(12.75, 17, 18.06)]
    public void GetBasePriceTest(decimal basePrice = 0M, int size = 1, decimal expectedPrice = 0M)
    {
        //Arrange
        var pizza = new Pizza
        {
            Special = new PizzaSpecial
            {
                BasePrice = basePrice,
                Id = 1,
                ImageUrl = "",
                Description = "",
                Name = ""
            },
            Size = size,
            Id = 1,
            OrderId = 1,
            SpecialId = 1,
            Toppings = new List<PizzaTopping>
            {
                new PizzaTopping
                {
                    PizzaId = 1,
                    Topping = new Topping
                    {
                        Id = 1,
                        Name = "",
                        Price = 1
                    }
                }
            }
        };

        //Act
        var actualPrice = Math.Round(pizza.GetBasePrice(), 2);

        //Assert
        Assert.Equal(expectedPrice, actualPrice);
    }


    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(0, 1, 0)]
    [InlineData(1, 0, 0)]
    [InlineData(1, 12, 1)]
    [InlineData(10, 12, 10)]
    [InlineData(5, 12, 5)]
    [InlineData(5, 120, 50)]
    [InlineData(12.75, 12, 12.75)]
    [InlineData(12.75, 9, 9.56)]
    [InlineData(12.75, 17, 18.06)]
    public void GetFormattedTotalPriceTest(decimal basePrice = 0M, int size = 1, decimal expectedPrice = 0M)
    {
        //Arrange
        var pizza = new Pizza
        {
            Special = new PizzaSpecial
            {
                BasePrice = basePrice,
                Id = 1,
                ImageUrl = "",
                Description = "",
                Name = ""
            },
            Size = size,
            Id = 1,
            OrderId = 1,
            SpecialId = 1,
            Toppings = new List<PizzaTopping>
            {
                new PizzaTopping
                {
                    PizzaId = 1,
                    Topping = new Topping
                    {
                        Id = 1,
                        Name = "",
                        Price = 1
                    }
                }
            }
        };

        //Act
        var actualPrice = pizza.GetFormattedTotalPrice();

        //Assert
        Assert.Equal(expectedPrice.ToString("0.00"), actualPrice);

    }
}
