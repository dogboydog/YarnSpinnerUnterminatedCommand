using System;
using System.Collections.Generic;
using System.IO;
using Yarn.Compiler;
public class Program
{
    public static void Main(string[] args)
    {
        var yarnScriptPath = Path.GetFullPath("../../../Hello.yarn");
        var job = CompilationJob.CreateFromFiles(new List<string>
        {
            yarnScriptPath
        });
        var compilationResult = Yarn.Compiler.Compiler.Compile(job);
        foreach (var diag in compilationResult.Diagnostics)
        {
            Console.WriteLine($"Diag {diag.Severity} {diag.Message}");
        }
    }
}