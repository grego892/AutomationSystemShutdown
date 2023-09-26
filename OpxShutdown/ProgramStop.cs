using OpxShutdown;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace OpxShutdown
{
    internal class ProgramStop
    {
        public static void StopProgramsAll()
        {
            foreach (string program in ProgramList.OpxPrograms)
            {
                StopSingleProgram(program);
            }
        }

        public static void StopSingleProgram(string program)
        {
            try
            {
                Process[] process = Process.GetProcessesByName(program);

                if (process.Length > 0)
                {
                    for (int i = 0; i < process.Length; i++)
                    {
                        Process p = process[i];
                        p.CloseMainWindow();
                        p.Close();
                        p.Dispose();
                        p.Refresh();
                    }

                    //Process.GetProcessesByName(program)[0].CloseMainWindow();
                    //Process.GetProcessesByName(program)[0].Dispose();
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}