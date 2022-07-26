﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.Protocols;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "test.txt";
            string sourcePath = @"C:\Users\Public\TestFolder";
            string targetPath = @"C:\Users\Public\TestFolder\SubDir";
            // Use Path class to manipulate file and directory paths.

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            //if (!System.IO.Directory.Exists(targetPath))
            //{
                //System.IO.Directory.CreateDirectory(targetPath);
            //}
            // To copy a file to another location and 
            // overwrite the destination file if it already exists.


            System.IO.File.Copy(sourceFile, destFile, true);
        }
    }
}
