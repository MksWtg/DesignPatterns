using DesignPatterns.AdapterPattern;

namespace DesignPatterns.Test;

public class AdapterTest
{
	[Test]
	public void TestAdapterCanGreet()
	{
		// Arrange

		var hello = new Hello();
		var adapter = new Adapter(hello);

		// Act

		var result = CallGreet(adapter, "mukund");

		// Assert

		Assert.That(result, Is.EqualTo("Hello, mukund!"));
	}

	static string CallGreet(IGreeter greeter, string name)
	{
		return greeter.Greet(name);
	}
}