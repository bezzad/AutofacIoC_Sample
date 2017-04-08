namespace IoCSample
{
    /// <summary>
    /// This interface decouples the notion of writing
    /// a date from the actual mechanism that performs
    /// the writing. Like with IOutput, the process
    /// is abstracted behind an interface.    
    /// </summary>
    public interface IDateWriter
    {
        void WriteDate();
    }
}