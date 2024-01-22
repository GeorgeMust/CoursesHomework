using System;
using System.IO;
#pragma warning disable SA1600
#pragma warning disable SA1401
#pragma warning disable SA1202
#pragma warning disable SA1201
#pragma warning disable SA1307

public class Director
{
	public string directorName;

	public event EventHandler<ParentsEventArgs> ParentsInfoEvent;

	public Director(string directorName)
	{
		this.directorName = directorName;
	}

	protected virtual void OnParentsEvent(ParentsEventArgs e)
	{
		if (this.ParentsInfoEvent != null)
		{
			this.ParentsInfoEvent(this, e);
		}
	}

	public void HandleEvent(object sender, AddStudEventArgs e)
	{
		Console.WriteLine("Директор рассмотрел:");
		Console.WriteLine("Источник: " + sender.ToString());
		Console.WriteLine("Данные: " + e.StudentData.firstName + " " + e.StudentData.lastName + " " + e.StudentData.age);
		this.OnParentsEvent(new ParentsEventArgs(e.StudentData.parents.firstParent, e.StudentData.parents.secondParent));
	}
}

#pragma warning restore SA1201
#pragma warning restore SA1202
#pragma warning restore SA1307
#pragma warning restore SA1401
#pragma warning restore SA1600
