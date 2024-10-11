using CalculadoraProj.Services;

namespace CalculadoraProjTest;

public class UnitTest1
{
    public Calculadora ConstruirClasse()
    {
        string data = "10/10/2010";
        var calc = new Calculadora(data);
        return calc;
    }
    
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 4, 7)]
    public void SomarTest(int num1, int num2, int resultadoEsperado)
    {
        //Arrange
        var calc = ConstruirClasse();
        //Act
        var resultado = calc.Somar(num1, num2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(3, 4, 12)]
    public void MultiplicarTest(int num1, int num2, int resultadoEsperado)
    {
        //Arrange
        var calc = ConstruirClasse();
        //Act
        var resultado = calc.Multiplicar(num1, num2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(6, 4, 2)]
    public void SubtrairTest(int num1, int num2, int resultadoEsperado)
    {
        //Arrange
        var calc = ConstruirClasse();
        //Act
        var resultado = calc.Subtrair(num1, num2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(80, 5, 16)]
    [InlineData(6, 3, 2)]
    public void DividirTest(int num1, int num2, int resultadoEsperado)
    {
        //Arrange
        var calc = ConstruirClasse();
        //Act
        var resultado = calc.Dividir(num1, num2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void TestarDivisaoPor0()
    {
        var calc = ConstruirClasse();
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }

    [Fact]
    public void HistoricoTest()
    {
        //Arrange
        var calc = ConstruirClasse();

        calc.Somar(3, 4);
        calc.Dividir(6, 2);
        calc.Multiplicar(10, 2);
        calc.Subtrair(25, 40);

        var lista = calc.RetornarHistorico();

        //Assert
        Assert.NotEmpty(calc.RetornarHistorico());
        Assert.Equal(3, lista.Count);

    }
}