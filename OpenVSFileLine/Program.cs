﻿using System;
using System.Collections.Generic;
using System.Text;
using EnvDTE;
using EnvDTE80;
using EnvDTE90;
using EnvDTE100;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            EnvDTE80.DTE2 dte;
            dte = (EnvDTE80.DTE2)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE.10.0");

            // Cast to DTE2.
            dte.MainWindow.Activate();
            Window w = dte.ItemOperations.OpenFile(args[0]);
            int line;  
            int.TryParse(args[1], out line);
            ((EnvDTE.TextSelection)w.Document.Selection).GotoLine(line);

        }
    }
}