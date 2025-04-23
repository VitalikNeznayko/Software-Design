using System;
using System.Collections.Generic;

public class Virus : ICloneable
{
    public string Name;
    public string Species;
    public int Age;
    public double Weight;
    public List<Virus> Children;

    public Virus(string name, string species, int age, double weight)
    {
        Name = name;
        Species = species;
        Age = age;
        Weight = weight;
        Children = new List<Virus>();
    }

    public object Clone()
    {
        Virus clone = (Virus)this.MemberwiseClone();
        clone.Children = new List<Virus>();
        foreach (var child in this.Children)
        {
            clone.Children.Add((Virus)child.Clone());
        }
        return clone;
    }

    public void AddChild(Virus child)
    {
        Children.Add(child);
    }

    public void DisplayInfo(int generation = 0)
    {
        string indetifacation = new string(' ', generation * 2);
        Console.WriteLine($"{indetifacation}-Покоління: {generation}, Вірус: {Name}, Вид: {Species}, Вік: {Age}, Вага: {Weight} g. ");
        if (Children.Count > 0)
        {
            foreach (var child in Children)
            {
                child.DisplayInfo(generation + 1);
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Virus grandParent = new Virus("Вірус 1.1", "Вид А", 5, 0.2);
        Virus parent1 = new Virus("Вірус 2.1", "Вид B", 2, 0.1);
        Virus parent2 = new Virus("Вірус 2.2", "Вид C", 1, 0.5);

        Virus child1 = new Virus("Вірус 3.1", "Вид B", 2, 0.1);
        Virus child2 = new Virus("Вірус 3.2", "Вид C", 1, 0.5);
        Virus child3 = new Virus("Вірус 3.3", "Вид C", 1, 0.5);

        parent1.AddChild(child1);
        parent2.AddChild(child2);
        parent2.AddChild(child3);

        grandParent.AddChild(parent1);
        grandParent.AddChild(parent2);
        Virus clonedVirus = (Virus)grandParent.Clone();

        Console.WriteLine("Інформація про вірус:");
        grandParent.DisplayInfo();

        Console.WriteLine("\nІнформація про вірус після клонування:");
        clonedVirus.DisplayInfo();

        clonedVirus.Name = "Клонований вірус1.1";
        clonedVirus.Children[1].Name = "Клонований вірус2.1";
        clonedVirus.Children[1].Name = "Клонований вірус2.2";
        clonedVirus.Children[1].Children[0].Name = "Клонований вірус3.1";

        Console.WriteLine("\n\nІнформація про вірус (після змін у клонованому):");
        grandParent.DisplayInfo();

        Console.WriteLine("\nІнформація про вірус після клонування(після змін у клонованому):");
        clonedVirus.DisplayInfo();

    }
}
