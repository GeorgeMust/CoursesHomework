// <copyright file="EmptyStringException.cs" company="George Must">
// Copyright (C) George Must. All rights reserved.
// </copyright>

/*Разработать класс описывающий уникальное для вашего приложения исключение.
(Методы нашего приложения вызывают исключение, когда в качестве аргумента типа string приходит пустая строка.)
Разработать класс, в котором будет вызываться разработанное ранее исключение.
В классе Program реализовать обработку исключение таким образом, чтобы в зависимости от перехваченного исключения выводилось соответстующее сообщение.
Создать ситуацию при которой будет обработано созданное ранее исключение.*/
#pragma warning disable SA1600
#pragma warning disable SA1402
public class EmptyStringException : Exception
{
	public EmptyStringException()
	{
	}

	public EmptyStringException(string message)
		: base(message)
	{
	}

	public EmptyStringException(string message, Exception inner)
		: base(message, inner)
	{
	}
}

public class MyClass
{
	public void ProcessString(string str)
	{
		if (string.IsNullOrEmpty(str))
		{
			throw new EmptyStringException("Получена пустая строка.");
		}
	}
}

internal class Program
{
	private static void Main(string[] args)
	{
		MyClass myClass = new MyClass();

		try
		{
			myClass.ProcessString(string.Empty);
		}
		catch (EmptyStringException ex)
		{
			Console.WriteLine("Поймано пользовательское исключение: " + ex.Message);
		}
		catch (Exception ex)
		{
			Console.WriteLine("Поймано общее исключение: " + ex.Message);
		}
	}
}
#pragma warning restore SA1600
#pragma warning restore SA1402
