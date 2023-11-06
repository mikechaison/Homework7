﻿using System;
using System.Collections;
namespace CompositeExample
{
    class MainApp
    {
        static void Main()
        {
            // Create a tree structure
            Component root = new Unit("Army");
            root.Add(new Soldier("Soldier Adams"));
            root.Add(new Soldier("Soldier Biden"));
            Component comp = new Unit("Unit X");
            comp.Add(new Soldier("Soldier Hanks"));
            comp.Add(new Soldier("Soldier Smith"));
            root.Add(comp);
            comp = new Unit("Unit Y");
            comp.Add(new Soldier("Soldier Clinton"));
            comp.Add(new Soldier("Soldier Cruise"));
            root.Add(comp);
            root.Add(new Soldier("Soldier Carlson"));
            // Add and remove a soldier
            Soldier soldier = new Soldier("Soldier Doroshenko");
            root.Add(soldier);
            root.Display(1);
            root.Remove(soldier);
            // Recursively display tree
            root.Display(1);
        }
    }
    // "Component"
    abstract class Component
    {
        protected string name;
        // Constructor
        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
    // "Composite"
    class Unit : Component
    {
        private ArrayList children = new ArrayList();
        // Constructor
        public Unit(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            // Recursively display child nodes
            foreach (Component component in children)
            {
                component.Display(depth + 2);
            }
        }
    }

    // "Leaf"
    class Soldier : Component
    {
        // Constructor
        public Soldier(string name)
            : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a soldier");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a soldier");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

    }
}