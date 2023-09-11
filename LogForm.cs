using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inspection_Report
{
    public partial class LogForm : Form
    {
        private TextBox textBoxLog;
        public LogForm(List<string> logEntries)
        {
            InitializeComponent();

            textBoxLog = new TextBox
            {
                Multiline = true,
                Dock = DockStyle.Fill,
                ReadOnly = true
            };
            Controls.Add(textBoxLog);

            foreach (string logEntry in logEntries)
            {
                textBoxLog.AppendText(logEntry + Environment.NewLine);
            }
        }

        public void AppendLog(string logEntry)
        {
            if (!textBoxLog.IsDisposed)
            {
                textBoxLog.AppendText(logEntry + Environment.NewLine);
            }
        }
    }
}