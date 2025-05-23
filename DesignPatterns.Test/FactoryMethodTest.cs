using DesignPatterns.FactoryMethodPattern;
using DesignPatterns.Types.Products;
using System.Reflection.Metadata;

namespace DesignPatterns.Test;

public class FactoryMethodTest
{
    [Test]
    public void TestPenCreatorProducesPen()
    {
        // Arrange

        var penCreator = new PenCreator();

        // Act

        var result = UseNewWriter(penCreator);

        // Assert

        Assert.That(result, Is.EqualTo("Picking up writer. Writing smooth cursive."));
    }

	[Test]
	public void TestPencilCreatorProducesPencil()
	{
		// Arrange

		var pencilCreator = new PencilCreator();

		// Act

		var result = UseNewWriter(pencilCreator);

		// Assert

		Assert.That(result, Is.EqualTo("Picking up writer. Drawing some sketches."));
	}

	static string UseNewWriter(Creator creator)
    {
        return creator.CreateWriterAndWrite();
    }
}
