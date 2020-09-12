namespace CPUStressTest
{
    partial class MainScreen
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.Label_ThreadsNoInf = new System.Windows.Forms.Label();
            this.TextBox_NumberOfThreads = new System.Windows.Forms.TextBox();
            this.Label_RunningTestsInf = new System.Windows.Forms.Label();
            this.Label_Running_Tests = new System.Windows.Forms.Label();
            this.START_TEST = new System.Windows.Forms.Button();
            this.Label_GeneralWarning = new System.Windows.Forms.Label();
            this.STOP_TEST = new System.Windows.Forms.Button();
            this.UpperBar = new System.Windows.Forms.ToolStrip();
            this.Button_Update_Check = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.UpperBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_ThreadsNoInf
            // 
            this.Label_ThreadsNoInf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label_ThreadsNoInf.Location = new System.Drawing.Point(270, 37);
            this.Label_ThreadsNoInf.Name = "Label_ThreadsNoInf";
            this.Label_ThreadsNoInf.Size = new System.Drawing.Size(230, 25);
            this.Label_ThreadsNoInf.TabIndex = 0;
            this.Label_ThreadsNoInf.Text = "Enter number threads you want to use: ";
            this.Label_ThreadsNoInf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_NumberOfThreads
            // 
            this.TextBox_NumberOfThreads.Location = new System.Drawing.Point(533, 37);
            this.TextBox_NumberOfThreads.MaximumSize = new System.Drawing.Size(200, 25);
            this.TextBox_NumberOfThreads.MaxLength = 5;
            this.TextBox_NumberOfThreads.MinimumSize = new System.Drawing.Size(50, 25);
            this.TextBox_NumberOfThreads.Name = "TextBox_NumberOfThreads";
            this.TextBox_NumberOfThreads.Size = new System.Drawing.Size(50, 25);
            this.TextBox_NumberOfThreads.TabIndex = 1;
            this.TextBox_NumberOfThreads.Text = "1";
            // 
            // Label_RunningTestsInf
            // 
            this.Label_RunningTestsInf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label_RunningTestsInf.Location = new System.Drawing.Point(270, 83);
            this.Label_RunningTestsInf.Name = "Label_RunningTestsInf";
            this.Label_RunningTestsInf.Size = new System.Drawing.Size(181, 25);
            this.Label_RunningTestsInf.TabIndex = 2;
            this.Label_RunningTestsInf.Text = "Running tests at the moment:";
            this.Label_RunningTestsInf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Running_Tests
            // 
            this.Label_Running_Tests.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Running_Tests.Location = new System.Drawing.Point(483, 83);
            this.Label_Running_Tests.Name = "Label_Running_Tests";
            this.Label_Running_Tests.Size = new System.Drawing.Size(100, 25);
            this.Label_Running_Tests.TabIndex = 3;
            this.Label_Running_Tests.Text = "0";
            this.Label_Running_Tests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // START_TEST
            // 
            this.START_TEST.BackColor = System.Drawing.Color.DarkRed;
            this.START_TEST.Cursor = System.Windows.Forms.Cursors.Hand;
            this.START_TEST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.START_TEST.ForeColor = System.Drawing.Color.White;
            this.START_TEST.Location = new System.Drawing.Point(48, 83);
            this.START_TEST.Name = "START_TEST";
            this.START_TEST.Size = new System.Drawing.Size(118, 60);
            this.START_TEST.TabIndex = 4;
            this.START_TEST.Text = "Begin";
            this.START_TEST.UseVisualStyleBackColor = false;
            this.START_TEST.Click += new System.EventHandler(this.START_TEST_Click);
            // 
            // Label_GeneralWarning
            // 
            this.Label_GeneralWarning.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label_GeneralWarning.Location = new System.Drawing.Point(191, 151);
            this.Label_GeneralWarning.Name = "Label_GeneralWarning";
            this.Label_GeneralWarning.Size = new System.Drawing.Size(421, 161);
            this.Label_GeneralWarning.TabIndex = 5;
            this.Label_GeneralWarning.Text = resources.GetString("Label_GeneralWarning.Text");
            // 
            // STOP_TEST
            // 
            this.STOP_TEST.BackColor = System.Drawing.Color.Green;
            this.STOP_TEST.Cursor = System.Windows.Forms.Cursors.Hand;
            this.STOP_TEST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.STOP_TEST.ForeColor = System.Drawing.Color.White;
            this.STOP_TEST.Location = new System.Drawing.Point(48, 237);
            this.STOP_TEST.Name = "STOP_TEST";
            this.STOP_TEST.Size = new System.Drawing.Size(118, 60);
            this.STOP_TEST.TabIndex = 7;
            this.STOP_TEST.Text = "BREAK";
            this.STOP_TEST.UseVisualStyleBackColor = false;
            this.STOP_TEST.Click += new System.EventHandler(this.STOP_TEST_Click);
            // 
            // UpperBar
            // 
            this.UpperBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UpperBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_Update_Check,
            this.toolStripButton1});
            this.UpperBar.Location = new System.Drawing.Point(0, 0);
            this.UpperBar.Name = "UpperBar";
            this.UpperBar.Size = new System.Drawing.Size(624, 25);
            this.UpperBar.TabIndex = 8;
            this.UpperBar.Text = "toolStrip1";
            // 
            // Button_Update_Check
            // 
            this.Button_Update_Check.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Update_Check.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Button_Update_Check.ForeColor = System.Drawing.Color.Black;
            this.Button_Update_Check.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Update_Check.Name = "Button_Update_Check";
            this.Button_Update_Check.Size = new System.Drawing.Size(110, 22);
            this.Button_Update_Check.Text = "Check For Updates";
            this.Button_Update_Check.Click += new System.EventHandler(this.Button_Update_Check_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(104, 22);
            this.toolStripButton1.Text = "How do I update?";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.UpperBar);
            this.Controls.Add(this.STOP_TEST);
            this.Controls.Add(this.Label_GeneralWarning);
            this.Controls.Add(this.START_TEST);
            this.Controls.Add(this.Label_Running_Tests);
            this.Controls.Add(this.Label_RunningTestsInf);
            this.Controls.Add(this.TextBox_NumberOfThreads);
            this.Controls.Add(this.Label_ThreadsNoInf);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "CPU Stress Test (by Quanthis) v1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UpperBar.ResumeLayout(false);
            this.UpperBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_ThreadsNoInf;
        private System.Windows.Forms.TextBox TextBox_NumberOfThreads;
        private System.Windows.Forms.Label Label_RunningTestsInf;
        private System.Windows.Forms.Label Label_Running_Tests;
        private System.Windows.Forms.Button START_TEST;
        private System.Windows.Forms.Label Label_GeneralWarning;
        private System.Windows.Forms.Button STOP_TEST;
        private System.Windows.Forms.ToolStrip UpperBar;
        private System.Windows.Forms.ToolStripButton Button_Update_Check;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

