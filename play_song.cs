using System;
using System.Diagnostics;

namespace Play_Single_Music
{
    class Program
    {
        static void Main(string[] args)
        {
            string strCmdText;
            // Replace FILE_PATH and filename
            strCmdText = "/C start vlc FILE_PATH\\filename.mp3";

            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
    }
}
