using _05_sm_class_honey;
using UnityEngine;

/// <summary>
/// ステージ管理クラス
/// </summary>
public class StageManager : MonoBehaviour
{
    // 家の位置情報
    [SerializeField] public Transform homeTransform;

    // 海の位置情報
    [SerializeField] public Transform seaTransform;

    // 魚Prefab
    [SerializeField] public GameObject fishPrefab;

    // *以下はSample05のみ使用
    // 家ハニーの位置情報
    [SerializeField] public Transform homeHoneyTransform;

    // 散歩ポイントの位置情報
    [SerializeField] public Transform walkTransform;

    // ハニー
    [SerializeField] public Honey honey;
}