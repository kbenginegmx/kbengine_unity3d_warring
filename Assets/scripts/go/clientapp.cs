using UnityEngine;
using System;
using System.Collections;
using KBEngine;

public class clientapp : KBEMain 
{
	public override void initKBEngine()
	{
		// 强制设定为页游客户端，否则服务端找不到对应这个demo的场景
		clientType = KBEngineApp.CLIENT_TYPE.CLIENT_TYPE_BROWSER;
		base.initKBEngine();
	}
}
