namespace DesignPatterns.SingletonPattern;

public class Singleton
{
	private static Singleton? _instance;
	private static readonly object _lock = new();

	public string Value { get; private set; } = string.Empty;

	private Singleton() { }

	public static Singleton GetInstance(string value)
	{
		if (_instance is null)
		{
			lock (_lock)
			{
				_instance ??= new Singleton
					{
						Value = value
					};
			}
		}

		return _instance;
	}
}

public class Lolz { }