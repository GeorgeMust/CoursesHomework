// <copyright file="Parents.cs" company="George Must">
// Copyright (C) George Must. All rights reserved.
// </copyright>

using System;

public class Parents
{
    public string firstParent;
    public string secondParent;
    public Parents(string firstParent, string secondParent)
    {
        this.firstParent = firstParent;
        this.secondParent = secondParent;
    }

    public void HandleEvent(object sender, ParentsEventArgs e)
    {
        Console.WriteLine("Получено сообщение со школы:");
        Console.WriteLine("Источник: " + sender.ToString());
        Console.Write("Уважаемые " + e.Parent1);
        Console.WriteLine(" и " + e.Parent2 + ", ваш ребёнок зачислен");
    }
}
