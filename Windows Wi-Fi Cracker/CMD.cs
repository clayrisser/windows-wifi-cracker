using System.Diagnostics;
using System.IO;

namespace Windows_Wi_Fi_Cracker {
    class CMD {

        public static string Execute(string command) {
            string response = "";
            Process process = new Process();
            StreamWriter streamWriter;
            StreamReader streamReader;
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd");

            // Initialize <process>
            processStartInfo.UseShellExecute = false;
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.RedirectStandardError = true;
            processStartInfo.CreateNoWindow = true;
            process.StartInfo = processStartInfo;

            // Execute <process>
            process.Start();
            streamWriter = process.StandardInput;
            streamReader = process.StandardOutput;
            streamWriter.AutoFlush = true;
            streamWriter.WriteLine(command);
            streamWriter.Close();
            response = streamReader.ReadToEnd();
            return response;
        }

    }
}