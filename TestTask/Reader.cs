using System.IO;
using System.Linq;

namespace TestTask
{
    internal class Reader
    {
        private readonly string[] _lines;
        private int _pointer;

        internal bool End { get { return _pointer > _lines.Length - 1; } }

        internal Reader(string fileName)
        {
            _lines = File.ReadAllLines(fileName);
            _pointer = -1;
        }

        internal string GetNextLine()
        {
            _pointer++;

            if (!End)
            {
                return _lines[_pointer];
            }

            return null;
        }

        internal bool Contains(string line)
        {
            return _lines.Contains(line);
        }
    }
}
