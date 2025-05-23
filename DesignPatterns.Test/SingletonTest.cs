using DesignPatterns.SingletonPattern;

namespace DesignPatterns.Test;

public class SingletonTest
{
	[Test]
	public void TestSingletonGetInstanceMultiThreadedSetsFirstValue()
	{
		// Arrange

		string result1 = string.Empty;
		string result2 = string.Empty;

		var process1 = new Thread(() =>
		{
			result1 = TestSingleton("FOO");
		});
			
		var process2 = new Thread(() =>
		{
			result2 = TestSingleton("BAR");
		});

		// Act

		process1.Start();
		process2.Start();

		process1.Join();
		process2.Join();

		// Assert

		Assert.That(result1, Is.EqualTo(result2));
	}

	[Test]
	public void TestSingletonGetInstanceSetsFirstValue()
	{
		// Arrange & Act
		
		var result1 = TestSingleton("FOO");
		var result2 = TestSingleton("BAR");

		// Assert

		Assert.That(result1, Is.EqualTo(result2));
	}

	static string TestSingleton(string value)
	{
		var singleton = Singleton.GetInstance(value);
		return singleton.Value;
	}
}