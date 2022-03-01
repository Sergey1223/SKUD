using System;

namespace TestTask
{
    internal class LineEventArgs : EventArgs
    {
        internal string Text { get; private set; }
        internal Status Status { get; private set; }

        public LineEventArgs(string text, Status status)
        {
            Text = text;
            Status = status;
        }
    }
}