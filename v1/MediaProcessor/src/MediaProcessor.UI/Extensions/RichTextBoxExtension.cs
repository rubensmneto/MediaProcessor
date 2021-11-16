using System;
using System.Windows.Forms;

namespace MediaProcessor.UI.Extensions
{
    public static class RichTextBoxExtension
    {

        public static void AppendLine(this RichTextBox sender, string text)
        {
            if (string.IsNullOrEmpty(text)) return;
            sender.Text = $@"{DateTime.Now:HH:mm:ss.fff}: {text}{Environment.NewLine}" + sender.Text;
            sender.SelectionStart = 0;
            sender.SelectionLength = 1;
        }

    }
}