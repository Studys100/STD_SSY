using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHasEnemyDiceData
{
    public EnemyDiceData Data { get; set; }
}

public class EnemyDiceData
{
    [SerializeField]
    int UID;

    [SerializeField]
    float MaxHp;
    public float GetMaxHP => MaxHp;

    [SerializeField]
    float Speed;
    public float GetSpeed => Speed;

    [SerializeField]
    int InitialBuffID;
    public float GetInitBuffID => InitialBuffID;

    [SerializeField]
    GameObject prefab;

    public GameObject CreateMonsterInstance(Transform parent)
    {
        var monster = GameObject.Instantiate(prefab, parent);
        var hasEnemyDiceData = monster.GetComponent<IHasEnemyDiceData>();
        if(hasEnemyDiceData != null)
        {
            hasEnemyDiceData.Data = this;
        }
        return monster;
    }
}


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/EnemyDiceDatas", order = 1)]
public class EnemyDiceDatas : SerializedScriptableObject
{
    [Searchable]
    [SerializeField]
    List<EnemyDiceData> enemyDiceDatas = new List<EnemyDiceData>();

    public EnemyDiceData GetEnemyData(int id)
    {
        return enemyDiceDatas[id];
    }
}
