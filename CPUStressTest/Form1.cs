﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPUStressTest
{
    public partial class MainScreen : Form
    {
        #region Launch
        private ShowCPUUsage showStats = new ShowCPUUsage();
        private List<Task<bool>> allRunningTests = new List<Task<bool>>();

        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        private CancellationToken canlllationToken;

        public MainScreen()
        {
            InitializeComponent();

            canlllationToken = cancellationTokenSource.Token;
            CheckCPUState();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

        }

        private async Task CheckCPUState()
        {
            PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            await Task.Run(async () =>
            {
                await showStats.CreateFile();

                while (true)
                {
                    await showStats.UpdateFile(cpuCounter.NextValue().ToString().Substring(0, 2) + "%");                    
                    Thread.Sleep(500);
                }
            });
        }
        #endregion

        #region TEST

        private async void START_TEST_Click(object sender, EventArgs e)
        {
            try
            {
                ushort threadsNo = Convert.ToUInt16(TextBox_NumberOfThreads.Text);

                var TEST = new PerformTest(threadsNo);

                if(ChangeDisplayedValue(true) != true)
                {
                    MessageBox.Show("Internal Error!", "Please concact our onsite support!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                await showStats.UpdateFile($"A test has started with amount of {threadsNo} threads.");

                                
                Task<bool> thisTask = TEST.Perform(canlllationToken);
                allRunningTests.Add(thisTask);

                var stopwatch = new Stopwatch();
                stopwatch.Start();

                bool operationSuccessfull = await thisTask;


                if (operationSuccessfull)
                {
                    await showStats.UpdateFile($"A test has ended with amount of {threadsNo} threads.");

                    int elapsedTime = (int)stopwatch.ElapsedMilliseconds;
                    int elapsedSeconds = elapsedTime / 1000;
                    int elapsedMinutes = elapsedSeconds / 60;
                    elapsedSeconds = elapsedSeconds - elapsedMinutes * 60;

                    if (MessageBox.Show($"Your PC has managed to finish test without turnig off! Elapsed time: {elapsedMinutes} min {elapsedSeconds}s. Click OK to show CPU usage report.", "Test finished! ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        await showStats.OpenFile();
                    }                    
                }
                else
                {
                    MessageBox.Show("There was either thread conflict or test was interrupted.", "Test failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                stopwatch.Stop();                

                if (ChangeDisplayedValue(false) != true)
                {
                    MessageBox.Show("Internal Error!", "Please concact our onsite support!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch(InvalidCastException)
            {
                MessageBox.Show("Number of threads may only be in range 1-65535", "User Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(OperationCanceledException)
            {
                MessageBox.Show("Operation has been sucessfully canelled!", "User Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("Please concact our onsite support!", "Internal Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void STOP_TEST_Click(object sender, EventArgs e)
        {
            foreach(var element in allRunningTests)
            {
                cancellationTokenSource.Cancel();
            }

            allRunningTests.Clear();
            cancellationTokenSource.Dispose();

            cancellationTokenSource = new CancellationTokenSource();
            canlllationToken = cancellationTokenSource.Token;
        }
        #endregion

        private bool ChangeDisplayedValue(bool increaseOrNot)
        {
            int value = Convert.ToInt32(Label_Running_Tests.Text);

            if (increaseOrNot)
            {
                ++value;
            }
            else
            {
                --value;
            }

            Label_Running_Tests.Text = value.ToString();

            return true;
        }


        #region ToolStripButtons
        private async void Button_Update_Check_Click(object sender, EventArgs e)
        {
            await UpdateHelper.OpenDownloadLocation();
        }

        private async void Button_Open_Manual_Click(object sender, EventArgs e)
        {
            await UpdateHelper.OpenInstallationManual();
        }

        private void Button_Show_Authors_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://github.com/Quanthis/CPUStressTest/graphs/contributors");
        }
        #endregion
    }
}
