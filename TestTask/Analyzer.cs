using System;
using System.Threading;

namespace TestTask
{
    internal class Analyzer
    {
        private Thread _thread;
        private bool _isALive;
        private string _originalFileName;
        private string _resultFileName;

        internal event EventHandler<LineEventArgs> LineProcessed;
        internal event Action Complete;

        internal Analyzer()
        {
            _thread = null;
            _isALive = false;
        }

        private void Run()
        {
            Reader originalReader = new Reader(_originalFileName);
            Reader resultReader = new Reader(_resultFileName);

            string original = originalReader.GetNextLine();
            string result = resultReader.GetNextLine();

            while (_isALive && !originalReader.End && !resultReader.End)
            {
                if (original.Equals(result))
                {
                    LineProcessed?.Invoke(this, new LineEventArgs(original, Status.Unchanged));

                    original = originalReader.GetNextLine();
                    result = resultReader.GetNextLine();
                }
                else
                {
                    if (!resultReader.Contains(original))
                    {
                        LineProcessed?.Invoke(this, new LineEventArgs(original, Status.Deleted));

                        original = originalReader.GetNextLine();
                    }

                    if (!originalReader.Contains(result))
                    {
                        LineProcessed?.Invoke(this, new LineEventArgs(result, Status.Added));

                        result = resultReader.GetNextLine();
                    }
                }
            }

            while (_isALive && !originalReader.End)
            {
                LineProcessed?.Invoke(this, new LineEventArgs(original, Status.Deleted));

                original = originalReader.GetNextLine();
            }

            while (_isALive && !resultReader.End)
            {
                LineProcessed?.Invoke(this, new LineEventArgs(result, Status.Added));

                result = resultReader.GetNextLine();
            }

            Complete?.Invoke();
        }

        internal void Start(string originalFileName, string resultFileName)
        {
            Stop();

            _isALive = true;
            _originalFileName = originalFileName;
            _resultFileName = resultFileName;

            _thread = new Thread(Run);
            _thread.Start();
        }

        internal void Stop()
        {
            _isALive = false;

            if (_thread != null)
            {
                _thread.Join(1000);
                _thread = null;
            }
        }
    }
}