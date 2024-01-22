// <copyright file="School.cs" company="George Must">
// Copyright (C) George Must. All rights reserved.
// </copyright>

using System;

#pragma warning disable SA1600
#pragma warning disable SA1402
#pragma warning disable SA1401
#pragma warning disable SA1202
#pragma warning disable SA1201
#pragma warning disable SA1307
public class School
{
	private List<Student> students;
	public Director director;

	public event EventHandler<AddStudEventArgs> AddSchoolEvent;

	public School(List<Student> students, Director director)
	{
		this.students = students;
		this.director = director;
	}

	protected virtual void OnAddSchoolEvent(AddStudEventArgs e)
	{
		if (this.AddSchoolEvent != null)
		{
			this.AddSchoolEvent(this, e);
		}
	}

	public Student? SearchStudent(Predicate<Student> prStudent)
	{
		var student = this.students.Find(prStudent);
		return student;
	}

	public void StudAdd(Student prStudent)
	{
		this.students.Add(prStudent);
		this.director.ParentsInfoEvent += prStudent.parents.HandleEvent;
		this.OnAddSchoolEvent(new AddStudEventArgs(prStudent));
	}
}

public class AddStudEventArgs : EventArgs
{
	public Student StudentData { get; }

	public AddStudEventArgs(Student student)
	{
		this.StudentData = student;
	}
}

public class ParentsEventArgs : EventArgs
{
	public string Parent1 { get; }

	public string Parent2 { get; }

	public ParentsEventArgs(string parent1, string parent2)
	{
		this.Parent1 = parent1;
		this.Parent2 = parent2;
	}
}
#pragma warning restore SA1201
#pragma warning restore SA1202
#pragma warning restore SA1307
#pragma warning restore SA1401
#pragma warning restore SA1402
#pragma warning restore SA1600
