namespace DesignPatterns.AdapterPattern;

public class Adapter(Hello hello) : IGreeter
{
	readonly Hello _hello = hello;

	public string Greet(string name)
	{
		return _hello.SayHello(name);
	}
}
