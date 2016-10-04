using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ACT_Log_Extractor
{
    internal class LogParser
    {

        List<Tuple<string, string>> list = new List<Tuple<string, string>>();

        public LogParser(ListBox listBox_logs)
        {
            refresh(listBox_logs);            
        }

        public void refresh(ListBox listBox_logs)
        {
            Debug.WriteLine("Path: " + getLogDirPath());

            string[] files = Directory.GetFiles(getLogDirPath(), "*.log", SearchOption.AllDirectories);

            listBox_logs.Items.Clear();

            foreach (string file in files)
            {
                Debug.WriteLine("Adding item: " + getDate(file));
                string displayName = getDate(file);
                list.Add(new Tuple<string, string>(displayName, file));
                listBox_logs.Items.Add(getDate(file));
            }
        }

        internal void parse(ListBox listBox_logs, Form1 form)
        {
            Debug.WriteLine("Filepath: " + getFile(listBox_logs.SelectedItem.ToString()));
            var lines = File.ReadAllLines(getFile(listBox_logs.SelectedItem.ToString()));
            Match match;
            foreach (var line in lines)
            {
                match = new Regex(@"00\|\d+-\d+-\d+T(?<time>\d+:\d+:\d+).+?\|(?<code>\d+)\|.+?(?<name>[A-Z].+? [A-Z].+?)[A-Z].+?\|(?<message>.+)").Match(line);
                if (match.Success)
                {
                    Debug.WriteLine(match.Groups["name"]);
                }
                
            }

        }

        private string getDate(string file)
        {
            Regex regex = new Regex(@".+FFXIVLogs\\[A-z]+_(?<date>\d+)\.");
            Match match = regex.Match(file);
            return match.Groups["date"].Value;
        }

        private string getFile(string date)
        {
            foreach (var entry in list)
            {
                if (entry.Item1.Equals(date))
                {
                    return entry.Item2;
                }
            }
            return null;
        }

        private string getLogDirPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Advanced Combat Tracker\FFXIVLogs";
        }
    }
}