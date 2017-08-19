using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using X.UI;
using X.Tools;
using UnityEngine.SceneManagement;

public class UIMainMenu : UIBase {

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

	public void OnOpenTask()
	{
		this.DisAppear ();

		UITask ui = Singleton<UIManager>.Instance.GetUI<UITask> ();

		ui.Appear ();


	}

	public void OnLoadLevel(string level)
	{
		SceneManager.LoadScene (level);
	}
}
