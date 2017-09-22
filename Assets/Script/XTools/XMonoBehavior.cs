using UnityEngine;

public class XMonoBehavior : MonoBehaviour {
    private void Awake()
    {
        OnAwake();
    }

    private void Start()
    {
        OnStart();
    }


    protected virtual void OnAwake()
    {

    }

    protected virtual void OnStart()
    {

    }

    protected virtual void OnDestroy()
    {

    }
}
