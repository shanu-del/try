using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeywordSearch.Searcher;

namespace KeywordSearch
{
    public partial class FormSearch : Form
    {
        private double _fileLoadTime;
        private double _comparsionTime;
        
        private string[] _originalLines;
        private string[] _lowerLines;

        public FormSearch()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!File.Exists("Extensions.txt"))
            {
                File.WriteAllText("Extensions.txt", "txt\r\nlog\r\nlts");
            }

            var extensions = File.ReadAllLines("Extensions.txt");

            var extensionString = string.Join(";", extensions.Select(s => "*." + s.ToUpper()));

            var openFileDialog = new OpenFileDialog
            {
                Filter = $@"Text Files ({extensionString})|{extensionString}"
            };

            openFileDialog.ShowDialog();

            textBoxFilePath.Text = openFileDialog.FileName;

            labelFileLoadTime.Text = "File Load Time: Running...";

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            _originalLines = File.ReadAllLines(textBoxFilePath.Text);

            _lowerLines = new string[_originalLines.Length];
            
            Parallel.For(0, _originalLines.Length, i =>
            {
                _lowerLines[i] = _originalLines[i].ToLower();
            });

            stopwatch.Stop();

            _fileLoadTime = Math.Round(stopwatch.Elapsed.TotalSeconds, 2);

            if (_originalLines.Length > 0)
            {
                buttonFindMatches.Enabled = true;
                labelFileLoadTime.Text = "File Load Time: " + _fileLoadTime + " s";
            }
            else
            {
                labelFileLoadTime.Text = "File Load Time: Failed";
            }
        }

        private void buttonFindMatches_Click(object sender, EventArgs e)
        {
            if (listViewResults.VirtualMode)
            {
                listViewResults.VirtualMode = false;
            }

            if (listViewResults.Items.Count > 0)
            {
                listViewResults.Items.Clear();
            }

            labelComparsionTime.Text = "Comparsion Time: Running...";

            var searcher = new MainSearcher(textBoxKeywords.Lines);

            var stopwatch = new Stopwatch();
            
            SuspendLayout();
            listViewResults.BeginUpdate();

            var matchedIndexes = new List<int>();

            stopwatch.Start();

            Parallel.For(0, _lowerLines.Lesgth, i =>
            {
                if (searcher.Search(_lowerLines[i]))
                {
                    lock (matchedIndexes)
                    {
                        matchedIndexes.Add(i);
                    }
                }
            });

            matchedIndexes.Sort();
            
            for (var i = 0; i < matchedIndexes.Count; i++)
            {
                var matchedIndex = matchedIndexes[i];
                
                listViewResults.AddObject(new WordItem(matchedIndex + 1, _originalLines[matchedIndex]));
            }
            
            stopwatch.Stop();

            listViewResults.EndUpdate();
            ResumeLayout(false);

            _comparsionTime = Math.Round(stopwatch.Elapsed.TotalSeconds, 2);
            
            labelComparsionTime.Text = "Comparsion Time: " + _comparsionTime + " s";
        }

        private void listViewResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewResults.SelectedItems.Count == 0)
            {
                return;
            }

            Clipboard.SetText(listViewResults.SelectedItems[0].SubItems[1].Text.Trim());
        }
    }

    public class WordItem
    {
        public string Line { get; set; }
        public string Context { get; set; }

        public WordItem(int index, string line)
        {
            Line = index.ToString();
            Context = line;
        }
    }
}
