﻿using System;
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

        internal void parse(string filePath, ListBox listBox_logs, RadioButton radioButton_exportToSingle, RadioButton radioButton_exportToSeparate, CheckBox checkBox_alliance, CheckBox checkBox_freeCompany, CheckBox checkBox_linkshell1, CheckBox checkBox_linkshell2, CheckBox checkBox_linkshell3, CheckBox checkBox_linkshell4, CheckBox checkBox_linkshell5, CheckBox checkBox_linkshell6, CheckBox checkBox_linkshell7, CheckBox checkBox_linkshell8, CheckBox checkBox_party, CheckBox checkBox_say, CheckBox checkBox_shout, CheckBox checkBox_tell, CheckBox checkBox_yell)
        {
            Debug.WriteLine("Filepath: " + getFile(listBox_logs.SelectedItem.ToString()));
            var lines = File.ReadAllLines(getFile(listBox_logs.SelectedItem.ToString()));
            Match match;
            Debug.WriteLine("Number of lines:" + lines.Length);
            foreach (var line in lines)
            {
                match = new Regex(@"00\|\d+-\d+-\d+T(?<time>\d+:\d+:\d+).+?\|(?<code>\d+)\|.+?(?<name>[A-Z].+? [A-Z].+?)[A-Z].+?\|(?<message>.+)").Match(line);
                if (match.Success)
                {
                    Debug.WriteLine("PARSING: [" + match.Groups["time"].ToString() + "]" + "<" + match.Groups["name"].ToString() + ">" + match.Groups["message"].ToString());
                    parseCodes(match, filePath, radioButton_exportToSeparate.Checked);
                    
                }

            }

        }

        private void parseCodes(Match match, string filePath, bool separate)
        {
            string processedLine = constructLine(match);
# Say
# Party
# Alliance
# Yell
# Shout
# Free Company
# Tell
# Yell
# Lindshell 1
# Lindshell 2
# Lindshell 3
# Lindshell 4
# Lindshell 5
# Lindshell 6
# Lindshell 7
# Lindshell 8


        }

        private string constructLine(Match match, bool timestamp, bool channel, bool name)
        {
            string completeString = "";
            if(timestamp)
            {
                completeString = "[" + match.Groups["time"].ToString() + "]";
            }
            if (channel)
            {
                completeString += codeToChannel(match.Groups["code"].ToString());
            }
            if (name)
            {
                completeString += "<" + match.Groups["name"].ToString() + ">";
            }
            completeString += match.Groups["message"].ToString()
            return completeString;
        }

        private string codeToChannel(string code)
        {
            throw new NotImplementedException();
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