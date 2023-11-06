﻿using System;
namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            // Create ConcreteComponent and two Decorators
            ChristmasTree christmasTree = new ChristmasTree();
            DecoratedTree decoratedTree = new DecoratedTree();
            LightedTree lightedTree = new LightedTree();

            // Link decorators
            decoratedTree.SetTree(christmasTree);
            lightedTree.SetTree(decoratedTree);

            lightedTree.Operation();
        }
    }
    // "Component"
    abstract class Tree
    {
        public abstract void Operation();
    }

    // "ConcreteComponent"
    class ChristmasTree : Tree
    {
        public override void Operation()
        {
            Console.WriteLine("A Christmas tree has been planted");
        }
    }
    // "Decorator"
    abstract class Decorator : Tree
    {
        protected Tree tree;

        public void SetTree(Tree tree)
        {
            this.tree = tree;
        }
        public override void Operation()
        {
            if (tree != null)
            {
                tree.Operation();
            }
        }
    }

    // "ConcreteDecoratorA"
    class DecoratedTree : Decorator
    {
        private string decoration;

        public override void Operation()
        {
            base.Operation();
            decoration = "star";
            Console.WriteLine("A tree has been decorated with {0}", decoration);
        }
    }

    // "ConcreteDecoratorB" 
    class LightedTree : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("A tree has been lighted");
        }
        void AddedBehavior()
        { 
            Console.WriteLine("One, two, three, let the tree burn!");
        }
    }
}