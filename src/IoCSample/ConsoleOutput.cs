using System;

namespace IoCSample
{
    /// <summary>
    /// This implementation of the IOutput interface
    /// is actually how we write to the Console. Technically
    /// we could also implement IOutput to write to Debug
    /// or Trace... or anywhere else.    
    /// </summary>
    /// <seealso cref="IoCSample.IOutput" />
    public class ConsoleOutput : IOutput
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
}
