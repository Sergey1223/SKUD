using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TestTask
{
    internal partial class MainForm : Form
    {
        private static readonly string ANALYZE_TEXT = "Analyze";
        private static readonly string CANCEL_TEXT = "Cancel";

        private string _originalFileName;
        private string _resultFileName;
        private Analyzer _analyzer;
        private bool _analyzeIsActive;

        public MainForm()
        {
            InitializeComponent();

            _analyzer = new Analyzer();
            _analyzer.LineProcessed += OnLineProcessed;
            _analyzer.Complete += OnComplete;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _analyzer.LineProcessed -= OnLineProcessed;
            _analyzer.Stop();

            base.OnClosing(e);
        }

        private void OpenOriginalFileButton_Click(object sender, EventArgs e)
        {
            OpenFile(ref _originalFileName, originalFileNameLabel);
        }

        private void OpenResultFileButton_Click(object sender, EventArgs e)
        {
            OpenFile(ref _resultFileName, resultFileNameLabel);
        }

        private void OpenFile(ref string fileName, Label label)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;

                label.Text = fileName;

                analyzeButton.Enabled = _originalFileName != null && _resultFileName != null;
            }
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Text = string.Empty;

            if (_analyzeIsActive)
            {
                _analyzer.Stop();
            }
            else
            {
                _analyzer.Start(_originalFileName, _resultFileName);
            }

            _analyzeIsActive = !_analyzeIsActive;

            analyzeButton.Text = !_analyzeIsActive ? ANALYZE_TEXT : CANCEL_TEXT;
        }

        private void OnLineProcessed(object sender, LineEventArgs e)
        {
            Color color;

            switch (e.Status)
            {
                case Status.Unchanged:
                    color = Color.Green;

                    break;
                case Status.Deleted:
                    color = Color.Red;

                    break;
                case Status.Added:
                    color = Color.Orange;

                    break;
                default:
                    color = Color.Black;

                    break;
            }


            outputRichTextBox.Invoke(new Action(() =>
            {
                outputRichTextBox.AppendText(e.Text + Environment.NewLine);
                outputRichTextBox.Select(outputRichTextBox.Text.Length - e.Text.Length - 1, e.Text.Length);
                outputRichTextBox.SelectionColor = color;
            }));
        }

        private void OnComplete()
        {
            _analyzeIsActive = false;

            analyzeButton.Invoke(new Action(() => analyzeButton.Text = ANALYZE_TEXT));
        }
    }
}
