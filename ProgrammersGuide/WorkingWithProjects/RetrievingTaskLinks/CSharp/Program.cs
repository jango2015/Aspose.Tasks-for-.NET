//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System.Collections;
using System;

namespace RetrievingTaskLinks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Create a project reader instance
            ProjectReader rdr = new ProjectReader();

            // Call read method of project reader to open the project
            Project prj = rdr.Read(dataDir + "Project.mpp");

            // Retrieve task links
            ArrayList alTskLnk = prj.TaskLinks;
            foreach (TaskLink tskLnk in alTskLnk)
            {
                Console.WriteLine("Pred Task : " + tskLnk.PredTask.Name);
                Console.WriteLine("Succ Task : " + tskLnk.SuccTask.Name);
            }
 
        }
    }
}