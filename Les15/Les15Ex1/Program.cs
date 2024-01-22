// <copyright file="Program.cs" company="George Must">
// Copyright (C) George Must. All rights reserved.
// </copyright>

/*Разработать класс School который содержит учеников, и имеет публичный метод,который принимает делегат который используется для поиска конкретного ученика по имени и фамилии.
Добавить в школу директора школы, который должен реагировать на добавление нового ученика в школу, директор должен получить информацию с именем и возрастом ученика и отправить сообщение с приветствием его родителям.*/
namespace Les15Ex1
{
	 #pragma warning disable SA1600
	internal class Program
	{
		private static void Main(string[] args)
		{
			List<Student> students = new List<Student>();
			Director director = new Director("А.Д. Николаев");
			School school = new School(students, director);
			school.AddSchoolEvent += director.HandleEvent;

			school.StudAdd(new Student("Петров", "Василь", 7, new Parents("А.Г. Петров", "В.Д. Петрова")));
			school.StudAdd(new Student("Иванов", "Пётр", 6, new Parents("А.В. Иванов", "Ю.Г. Иванова")));

			Predicate<Student> prStudent = (prStudent) => prStudent.firstName == "Иванов" && prStudent.lastName == "Пётр";
			var rezult = school.SearchStudent(prStudent);
			Console.WriteLine(rezult);
		}
	}
#pragma warning restore SA1600
}
