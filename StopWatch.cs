using System;

public class StopWatch
{

	private DateTime startTime = DateTime.Now;
	private bool timerRunning = false;

	public void Start()
	{
		if (timerRunning) 
		{
			Console.WriteLine($"Timer is already running.\nTime: {DateTime.Now - startTime}");
		} else
		{
			Console.WriteLine("Timer started!");
		timerRunning = true;
		startTime = DateTime.Now;
		}
	}

	public void Stop()
	{
		timerRunning = false;
		Console.WriteLine(DateTime.Now - startTime);
	}

	
	public static void Main(string[] args)
		{
			StopWatch watch1 = new StopWatch();
			watch1.Start();
			watch1.Start();
			watch1.Stop();
			watch1.Stop();
		}

}

