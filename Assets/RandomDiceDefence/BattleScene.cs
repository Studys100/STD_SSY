using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneBase : MonoBehaviour
{
    static GameSceneBase active;
    static public T GetActive<T>() where T : GameSceneBase
    {
        return active as T;
    }

    private void Awake()
    {
        active = this;
    }
}

public class BattleScene : GameSceneBase
{
    [SerializeField]
    public GameObject prefabDice;

    [SerializeField]
    public GameObject prefabBullet;

    [SerializeField]
    MonsterPathes monsterPathes;
    public MonsterPathes GetMonsterPathes => monsterPathes;
}
