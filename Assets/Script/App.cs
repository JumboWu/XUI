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
public class App :  MonoSingleton<App>{

	protected override void Awake ()
	{
		base.Awake ();

	}

	protected void Start()
	{
		//演示
		Singleton<UIManager>.Create();

		UIMainMenu ui = Singleton<UIManager>.Instance.GetUI<UIMainMenu> ();
		ui.Init (null);
		ui.Appear ();
	}
		

	protected override void OnDestroy ()
	{
		base.OnDestroy ();


	}

	protected void Update()
	{
	}
		
}
