using System;
using System.Collections.Generic;

class NoOggyChecker
{
  static void RemoveOggy(List<string> names)
  {
    int size = names.Count;
    for (int i = size - 1; i >= 0; i--)
    {
      if (names[i].StartsWith("oggy", StringComparison.InvariantCultureIgnoreCase))
      {
       names.RemoveAt(i);
      }

    }
    
  }
  static bool OggyIsRemoved(List<string> names)
  {
    return names.Find(x => x.Contains("oggy")) == null;
  }
  static int Main()
  {
    var names = new List<string>
      { "nobita", "bheem", "oggy", "oggy cockroach", "ninja" };
    RemoveOggy(names);
    if(OggyIsRemoved(names)) {
      Console.WriteLine("Passed!");
      return 0;
    } 
    else 
    {
      Console.WriteLine("Failed!!");
      return 1;

    }
  }
}
