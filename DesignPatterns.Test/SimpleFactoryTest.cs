using DesignPatterns.SimpleFactoryPattern;

namespace DesignPatterns.Test;

public class SimpleFactoryTest
{
    [Test]
    public void TestSimpleFactoryProducesPen()
    {
        // Arrange
		
		var factory = new SimpleFactory();

		// Act

		var pen = factory.CreatePen();

		// Assert

		Assert.That(pen.Write(), Is.EqualTo("Writing smooth cursive."));
    }

	[Test]
	public void TestSimpleFactoryProducesPencil()
	{
		// Arrange

		var factory = new SimpleFactory();

		// Act

		var pencil = factory.CreatePencil();

		// Assert

		Assert.That(pencil.Write(), Is.EqualTo("Drawing some sketches."));
	}
}
