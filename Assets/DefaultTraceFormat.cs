// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

public class DefaultTraceFromat : Tracker.ITraceFormatter
{
	public string Serialize (List<string> traces)
	{
		string result = "";
		foreach (string trace in traces) {
			result += trace + "\n";
		}
		return result;
	}
}
