﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPUStressTest
{
    public partial class MainScreen : Form
    {
        private ShowCPUUsage showStats = new ShowCPUUsage();

        public MainScreen()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            CheckCPUState();
        }

        private async Task CheckCPUState()
        {
            PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            await Task.Run(async () =>
            {
                await showStats.CreateFile();

                while (true)
                {
                    showStats.UpdateFile(cpuCounter.NextValue().ToString().Substring(0, 1) + "%");                    
                    Thread.Sleep(500);
                }
            });
        }

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

                showStats.UpdateFile($"A test has started with amount of {threadsNo} threads.");
                bool operationSuccessfull = await TEST.Perform();

                if (operationSuccessfull)
                {
                    MessageBox.Show("Your PC has managed to finish test without turnig off! Click OK to show CPU usage report.", "Test finished! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await showStats.OpenFile();
                }
                else
                {
                    MessageBox.Show("There was either thread conflict or test was interrupted.", "Test failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch(InvalidCastException)
            {
                MessageBox.Show("Number of threads may only be in range 1-65535", "User Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Please concact our onsite support!", "Internal Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ChangeDisplayedValue(bool increaseOrNot)
        {
            int value = Convert.ToInt32(Label_Running_Tests.Text);

            if(increaseOrNot)
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
    }
}
