using System;

namespace Auraxis.Net.Helpers
{
    [AttributeUsage(AttributeTargets.Property)]
    internal sealed class JsonArrayPathAttribute : Attribute
    {
        internal string Path { get; }

        internal JsonArrayPathAttribute(string path) => Path = path;
    }
}
