using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPUStressTest
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

                bool operationSuccessfull = await TEST.Perform();

                MessageBox.Show("Test finished! ", "Your PC has managed to finish test without turnig off!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(InvalidCastException)
            {
                MessageBox.Show("User Error!", "Number of threads may only be in range 1-65535", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
