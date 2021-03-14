using System;   // a semicolon indicates the end of a statement
using System.Linq;
using System.Reflection;

// # error version

namespace Basics
{ // an open brace indicates the start of a block
  class Program
  {
    static void Main(string[] args)
    {
      /* onsole.WriteLine("Hello World!");  // a statement
      // outputs a carriage-return 
      Console.WriteLine();
      // outputs the greeting and a carriage-return 
      Console.WriteLine("Hello Ahmed");
      // outputs a formatted number and date and a carriage-return 
      Console.WriteLine("Temperature on {0:D} is {1}°C.", DateTime.Today, 23.4); */

      // declare some unused variables using types
      // in additional assemblies
      System.Data.DataSet ds;
      System.Net.Http.HttpClient client;

      // loop through the assemblies that this app references 
      foreach (var r in Assembly.GetEntryAssembly()
        .GetReferencedAssemblies())
      {
        // load the assembly so we can read its details
        var a = Assembly.Load(new AssemblyName(r.FullName));
        // declare a variable to count the number of methods
        int methodCount = 0;
        // loop through all the types in the assembly
        foreach (var t in a.DefinedTypes)
        {
          // add up the counts of methods
          methodCount += t.GetMethods().Count();
        }
        // output the count of types and their methods
        Console.WriteLine(
          "{0:N0} types with {1:N0} methods in {2} assembly.",
          arg0: a.DefinedTypes.Count(),
          arg1: methodCount,
          arg2: r.Name);
      }
    }
  }
} // a close brace indicates the end of a block
