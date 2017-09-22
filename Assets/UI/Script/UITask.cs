using UnityEngine;
using X.UI;

public class UITask : UIBase {

	public override void Init (object[] parameters)
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

		UIMainMenu ui = UIManager.Instance.GetUI<UIMainMenu>();

		ui.Appear ();



	}
}
