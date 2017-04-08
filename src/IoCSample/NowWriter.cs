using System;

namespace IoCSample
{
    /// <summary>
    /// This NowWriter is where it all comes together.
    /// Notice it takes a constructor parameter of type
    /// IOutput - that lets the writer write to anywhere
    /// based on the implementation. Further, it implements
    /// WriteDate such that today's date is written out;
    /// you could have one that writes in a different format
    /// or a different date.    
    /// </summary>
    /// <seealso cref="IoCSample.IDateWriter" />
    public class NowWriter : IDateWriter
    {
        private readonly IOutput _output;
        public NowWriter(IOutput output)
        {
            this._output = output;
        }

        public void WriteDate()
        {
            this._output.Write(DateTime.Now.ToString("F"));
        }
    }
}