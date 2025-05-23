using DesignPatterns.Types.Products;

namespace DesignPatterns.SimpleFactoryPattern;

public class SimpleFactory
{
	public Pen CreatePen() => new();

	public Pencil CreatePencil() => new();
}
