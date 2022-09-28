using System.Collections;
using UnityEngine;

/// <summary>
/// MonoBehaviourHandlerクラス
/// 非MonoBehaviorクラスはこの関数を使用する
/// </summary>
public class MonoBehaviorHandler : MonoBehaviour
{
    private static MonoBehaviorHandler s_instance;

    private static MonoBehaviorHandler Instance
    {
        get
        {
            if (s_instance != null)
                return s_instance;

            var o = new GameObject("MonoBehaviorHandler");
            DontDestroyOnLoad(o);
            s_instance = o.AddComponent<MonoBehaviorHandler>();
            return s_instance;
        }
    }

    public void OnDisable()
    {
        if (s_instance)
            Destroy(s_instance.gameObject);
    }

    /// <summary>
    /// コルーチン実行
    /// </summary>
    /// <param name="coroutine"></param>
    public static void StartStaticCoroutine(IEnumerator coroutine)
    {
        Instance.StartCoroutine(coroutine);
    }
}