using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using X.UI;
using X.Tools;

public class UITask : UIBase {

	public override void Init (Object[] parameters)
	{
		base.Init (parameters);
	}


	public override void Appear ()
	{
		base.Appear ();
	}

	public override void DisAppear ()
	{
		base.DisAppear ();
	}

	public override void OnAppear ()
	{
		base.OnAppear ();
	}

	public override void OnDisAppear ()
	{
		base.OnDisAppear ();
	}

	public void OnBackMainMenu()
	{
		this.DisAppear ();

		UIMainMenu ui = Singleton<UIManager>.Instance.GetUI<UIMainMenu>();

		ui.Appear ();



	}
}
