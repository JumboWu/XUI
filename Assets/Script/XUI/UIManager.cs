/*****************************************************************
 *      File:UIManager.cs
 *      UIManager实例创建：Singleton<UIManager>.Create();
 *
 *		UI类获取：T ui = Singleton<UIManager>.Instance.GetUI<T> ();//T为UI类
 *      UI初始化：ui.init(Object [] parameters);
 *		UI显示：ui.Appear ();
 * 
 *      Author:Jumbo @ 08/19/2017 Shanghai  Email:wjb0108@gmail.com
******************************************************************/


using UnityEngine;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// 所有UI统一管理器
/// </summary>

namespace X.UI
{
	
	public class UIManager
    {
		//所有的UI类字典容器存储，key：UI的prefab名称 ＝ 脚步命名规则  value：UI类型
		private Dictionary<string, UIBase> _UIDict = new Dictionary<string, UIBase>();


		private  Stack<UIBase> _UIStack = new Stack<UIBase>();

        private Transform _canvas;//UGUI 画布

        private UIManager()
        {
            _canvas = GameObject.Find("UICanvas").transform; //场景中的画布节点名称
            foreach (Transform item in _canvas)
            {
                GameObject.Destroy(item.gameObject);
            }
        }
			

		public int UIStackCount
		{
			get{
				return _UIStack.Count;
			}

		}

		public void PushUI(UIBase ui) 
		{
			if (!_UIStack.Contains(ui))
			    _UIStack.Push (ui);
		}

		public UIBase PeekUI()
		{
			return _UIStack.Peek ();
		}

		public UIBase PopUI()
		{
			return _UIStack.Pop ();
		}

		/// <summary>
		/// 通过以prefab名称作为key，来加载，创建，并获取对应的UI界面
		/// </summary>
		/// <returns>返回对应的UI界面类</returns>
		/// <param name="key">prefab名称</param>
		public UIBase GetUI(string key)
		{
			UIBase ui = null;
			if (!_UIDict.TryGetValue (key, out ui)) {
				GameObject go = GameObject.Instantiate(Resources.Load<GameObject>(key)) as GameObject;    
				go.transform.SetParent(_canvas, false);
				go.SetActive (false);
				ui = go.GetComponent<UIBase> ();

				_UIDict.Add (key, ui);
			}

			return ui;
		}

		/// <summary>
		/// 泛型方式：通过UI类，来获取对应的UI界面
		/// </summary>
		/// <returns>返回对应的UI界面类</returns>
		/// <typeparam name="T">UI类</typeparam>
		public T GetUI<T>() where T : UIBase
		{
			string key = typeof(T).ToString ();
			UIBase ui = GetUI (key);

			return (ui as T);
		}

		/// <summary>
		/// 通过以prefab名称作为key，尝试获取对应的UI界面，可能为空
		/// </summary>
		/// <returns>返回对应的UI界面类</returns>
		/// <param name="key">prefab名称</param>
		public UIBase TryGetUI(string key)
		{
			UIBase ui = null;
			if (_UIDict.TryGetValue (key, out ui)) {
				return ui;
			}

			return null;
		}

		/// <summary>
		/// 泛型方式：通过UI类，尝试来获取对应的UI界面，可能为空
		/// </summary>
		/// <returns>返回对应的UI界面类</returns>
		/// <typeparam name="T">UI类</typeparam>
		public T TryGetUI<T>() where T : UIBase
		{
			string key = typeof(T).ToString ();
			UIBase ui = null;
			if (_UIDict.TryGetValue (key, out ui)) {
				return (ui as T);
			}

			return null;
		}

       
		/// <summary>
		/// 销毁key对应的UI
		/// </summary>
		/// <param name="key">UI的prefab名称</param>
		public void DestroyUI(string key)
        {
			
			if (!_UIDict.ContainsKey(key))
            {
                return;
            }

			if (_UIDict[key] == null)
            {
				_UIDict.Remove(key);
                return;
            }

			GameObject.Destroy(_UIDict[key]);
			_UIDict.Remove(key);
        }
		/// <summary>
		/// 销毁UI类为T的UI
		/// </summary>
		/// <typeparam name="T">UI类</typeparam>
		public void DestroyUI<T>() where T : UIBase
		{
			string key = typeof(T).ToString ();
			DestroyUI (key);
		}
	}
}
