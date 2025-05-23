using DesignPatterns.Types.Products;

namespace DesignPatterns.FactoryMethodPattern;

public abstract class Creator
{
	public abstract IWriter CreateWriter();

	public string CreateWriterAndWrite()
	{
		return $"Picking up writer. {CreateWriter().Write()}";
	}
}
