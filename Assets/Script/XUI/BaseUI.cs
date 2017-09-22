using UnityEngine;

/// <summary>
/// UI抽象类，声明UI的通用行为方法
/// </summary>
namespace X.UI
{
	public abstract class BaseUI : MonoBehaviour
    {
		void Awake()
		{
			OnAwake ();
		}

		public virtual void OnAwake()
		{
		}

		void Start()
		{
			OnStart ();
		}

		public virtual void OnStart()
		{
		}

		void Update()
		{
			OnUpdate ();
		}

		public virtual void OnUpdate()
		{
		}

		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="parameters">参数封箱，拆箱，自定义</param>
		public virtual void Init(object [] parameters)
		{
		}

		/// <summary>
		/// 显示UI
		/// </summary>
		public virtual void Appear()
		{
		}

		/// <summary>
		/// 隐藏UI
		/// </summary>
		public virtual void DisAppear()
		{
		}

		/// <summary>
		/// 显示回调
		/// </summary>
        public virtual void OnAppear()
        {

        }

		/// <summary>
		/// 隐藏回调
		/// </summary>
        public virtual void OnDisAppear()
        {

        }

		/// <summary>
		/// 暂停->处于后台
		/// </summary>
        public virtual void OnPause()
        {

        }

		/// <summary>
		/// 唤起－>处于前台
		/// </summary>
        public virtual void OnResume()
        {

        }

		/// <summary>
		/// 销毁自身
		/// </summary>
        public void DestroySelf()
        {
            Destroy(gameObject);
        }
	}
}
