using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DeBugHandler : MonoBehaviour
{
	public DeBugger debuggerObj;

	public void SwitchDeBugger(DeBugger newDebuggerObj)
	{
		debuggerObj = newDebuggerObj;
	}
	void Update () 
	{
		debuggerObj.OnDebug();
	}
}
