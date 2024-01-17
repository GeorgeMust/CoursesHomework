// <copyright file="NumberOutOfRange.cs" company="George Must">
// Copyright (C) George Must. All rights reserved.
// </copyright>

/*Создать консольное приложение, приложение просит пользователя ввести два значения [0-255], и затем возвращает в консоль результат деления первого числа на второе. Использовать метод int.Parse. Какие исключения могут возникнуть? Добавить обработку исключений в приложение.
	  Создать ситуацию при котором придется обрабатывать исключения.*/
namespace Testft
{
#pragma warning disable SA1600
#pragma warning disable SA1402
#pragma warning disable SA1009
	public class NumberOutOfRange(string message) : Exception(message)
	{
	}

	public class ParseFailed(string message) : Exception(message)
	{
	}

#pragma warning restore SA1009
	internal class Program
	{
		private static void Main(string[] args)
		{
			int chisl = 0;
			int znamen = 0;
			int div = 0;
			try
			{
				Console.Write("Введите делимое: ");
				InpInt(ref chisl);
				Console.Write("Введите делитель: ");
				InpInt(ref znamen);
				try
				{
					if (znamen == 0)
					{
						throw new DivideByZeroException("Деление на ноль");
					}

					div = chisl / znamen;

					Console.WriteLine("Результат деления: " + div);
				}
				catch (DivideByZeroException ex)
				{
					Console.WriteLine(ex.ToString());
				}
			}
			catch (NumberOutOfRange ex)
			{
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				Console.WriteLine("Введено делимое: " + chisl + " делитель: " + znamen);
			}
		}

		private static void InpInt(ref int value)
		{
			value = ConvToInt();
			if (value < 0 || value > 255)
			{
				throw new NumberOutOfRange("Выходит за заданный диапазон");
			}
		}

		private static int ConvToInt()
		{
			int rezult = 0;
			bool parseOk = false;
			while (!parseOk)
			{
				try
				{
					string? str = Console.ReadLine();
					if (int.TryParse(str, out int value))
					{
						rezult = value;
						parseOk = true;
					}
					else
					{
						throw new ParseFailed("Ошибка преобразования");
					}
				}
				catch (ParseFailed ex)
				{
					Console.WriteLine(ex.ToString());
				}
			}

			return rezult;
		}
	}
#pragma warning restore SA1402
#pragma warning restore SA1600
}
