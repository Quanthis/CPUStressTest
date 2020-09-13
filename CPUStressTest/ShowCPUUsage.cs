using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace CPUStressTest
{
    public class ShowCPUUsage
    {
        public const string PATH = @"logfile.txt";

        public async Task OpenFile()
        {
            await Task.Run(() =>
            {
                lock (PATH)
                {
                    Process.Start(PATH);
                    Debug.WriteLine("File should open");
                }
            });
        }

        public async Task CreateFile()
        {
            await Task.Run
                (() =>
                {
                    lock (PATH)
                    {
                        FileStream fs = new FileStream(PATH, FileMode.Create);
                        fs.Dispose();
                    }
                });
        }

        public async Task UpdateFile(string message)
        {
            await Task.Run
                (() =>
                {
                    StringBuilder sb = new StringBuilder();
                    string time = ((DateTime.Now - Process.GetCurrentProcess().StartTime).ToString()).Substring(0, 11);
                    sb.Append(time);
                    sb.Append(" - ");
                    sb.Append(message);
                    sb.Append("\n");
                    
                    using (FileStream fs = new FileStream(PATH, FileMode.Open))
                    {
                        lock (fs)
                        {
                            using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                            {
                                sb.Append(sr.ReadToEnd());
                            }
                        }
                    }

                    using (FileStream fs = new FileStream(PATH, FileMode.Open))
                    {
                        lock (fs)
                        {
                            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                            {
                                sw.WriteLine(sb.ToString());
                            }
                        }
                    }
                });
        }
    }
}
