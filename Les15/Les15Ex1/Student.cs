// <copyright file="Student.cs" company="George Must">
// Copyright (C) George Must. All rights reserved.
// </copyright>

using System;

#pragma warning disable SA1600
#pragma warning disable SA1401
#pragma warning disable SA1307
public class Student
{
	public string firstName;
	public string lastName;
	public int age;
	public Parents parents;

	public Student(string firstName, string lastName, int age, Parents parents)
	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.age = age;
		this.parents = parents;
	}
}
#pragma warning restore SA1307
#pragma warning restore SA1401
#pragma warning restore SA1600
