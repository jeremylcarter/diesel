﻿namespace Diesel.Parsing.CSharp
{
    public class NamespaceName : Terminal
    {
        public string Name { get; private set; }
        public NamespaceName(string name)
        {
            Name = name;
        }
    }
}