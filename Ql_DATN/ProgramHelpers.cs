using Ql_DATN;
using System;
using System.Windows.Forms;

internal static class ProgramHelpers
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new NopDoAn());
    }
}