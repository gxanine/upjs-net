using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace upjs
{
    public static class upjs
    {

        public static bool GithubFull(string user, string repo, string current, string name = "")
        {

            string args = String.Format("github-full -u \"{0}\" -r \"{1}\" -c \"{2}\" -n \"{3}\" -s", user, repo, current, name);
            string result = Execute(args);


            if (result == "true")
                return true;

            return false;

        }

        public static string Execute(string args)
        {
            /* Sample args: 
                    String.Format("github-full -u \"{0}\" -r \"{1}\" -c \"{2}\" -n \"{3}\" -s", user, repo, current, name);
             */


            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.Arguments = args;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = "upjs.exe";
            p.Start();
            // Read the output stream first and then wait for exit.
            string output = p.StandardOutput.ReadToEnd();
            string errors = p.StandardError.ReadToEnd();
            output = output.Trim();
            errors = errors.Trim();
            if (output.Length > 0) Debug.WriteLine("upjs out: " + output);
            if (errors.Length > 0) throw new Exception(errors);
            p.WaitForExit();

            return output;
        }

        public static void Clear()
        {
            Execute("clear -s");
        }

        public static void RemOld()
        {
            Execute("rem-old -s");
        }


        public static void RestartSelf(Process mainProcess)
        {
            Process.Start(mainProcess.MainModule.FileName);
            mainProcess.Kill();
        }
    }

    
}
