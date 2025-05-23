using DesignPatterns.Types.Products;

namespace DesignPatterns.FactoryMethodPattern;

public class PencilCreator : Creator
{
	public override IWriter CreateWriter()
	{
		return new Pencil();
	}
}
