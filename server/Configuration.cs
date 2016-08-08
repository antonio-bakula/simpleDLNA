using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NMaier.SimpleDlna.Server
{
  public static class Configuration
  {
    private static string _DontCheckGetCapInfoIPList = "";

    public static string DontCheckGetCapInfoIPList
    {
      get
      {
        return _DontCheckGetCapInfoIPList;
      }
      set
      {
        lock (typeof(Configuration))
        {
          _DontCheckGetCapInfoIPList = value;
        }
      }
    }
  }
}
