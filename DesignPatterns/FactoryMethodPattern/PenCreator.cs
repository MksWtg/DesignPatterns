using DesignPatterns.Types.Products;

namespace DesignPatterns.FactoryMethodPattern;

public class PenCreator : Creator
{
	public override IWriter CreateWriter()
	{
		return new Pen();
	}
}
