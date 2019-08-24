﻿using System;
using System.Diagnostics;

namespace CodeRunner.Executors
{
    public class CLIExecutorSettings
    {
        public CLIExecutorSettings(string filePath, string[] arguments)
        {
            FilePath = filePath;
            Arguments = arguments;
        }

        public string FilePath { get; set; }

        public string[] Arguments { get; set; }

        public string? Input { get; set; }

        public long? MemoryLimit { get; set; }

        public TimeSpan? TimeLimit { get; set; }

        public bool CollectOutput { get; set; }

        public bool CollectError { get; set; }

        public string WorkingDirectory { get; set; } = string.Empty;

        public ProcessStartInfo CreateStartInfo()
        {
            ProcessStartInfo res = new ProcessStartInfo
            {
                FileName = FilePath
            };
            foreach (string r in Arguments)
            {
                res.ArgumentList.Add(r);
            }

            if (Input != null || CollectOutput || CollectError)
            {
                res.UseShellExecute = false;
            }

            if (Input != null)
            {
                res.RedirectStandardInput = true;
            }

            if (CollectOutput)
            {
                res.RedirectStandardOutput = true;
            }

            if (CollectError)
            {
                res.RedirectStandardError = true;
            }

            if (!string.IsNullOrEmpty(WorkingDirectory))
            {
                res.WorkingDirectory = WorkingDirectory;
            }

            return res;
        }
    }
}