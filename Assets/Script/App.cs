/*****************************************************************
 *      File:App.cs
 *
 * 
 *      Author:Jumbo @ 08/19/2017 Shanghai  Email:wjb0108@gmail.com
******************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using X.Tools;
using X.UI;

/// <summary>
/// 程序应用入口
/// </summary>
public class App :  XMonoSingleton<App>{

    protected override void OnAwake()
    {
        base.OnAwake();
    }

    protected override void OnStart()
    {
        base.OnStart();

        //演示

        UIMainMenu ui = UIManager.Instance.GetUI<UIMainMenu>();
        ui.Init(null);
        ui.Appear();
    }

	protected override void OnDestroy ()
	{
		base.OnDestroy ();


	}

	protected void Update()
	{
	}
		
}
