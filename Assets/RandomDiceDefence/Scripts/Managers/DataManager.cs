using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 변경되지 않는 데이터와, 변경가능한 유저데이터에 접근 가능.
public class DataManager : Singleton<DataManager>
{
    // scriptable objects
    [SerializeField]
    EnemyDiceDatas enemyDiceDatas;

    [SerializeField]
    DiceDatas diceDatas;

    // read only    
    Dictionary<int, EnemyDiceDatas> uidToEnemyDiceData = new Dictionary<int, EnemyDiceDatas>();
    Dictionary<int, DiceDatas> uidToPlayerDiceData = new Dictionary<int, DiceDatas>();

    // user data

    public override void Init()
    {

    }
    public Buff GetBuffData(int initialBuffID)
    {
        // 구현해주세요!! 소영님!!
        return null;
    }

    public EnemyDiceDatas GetEnmyDiceData(int uid)
    {
        uidToEnemyDiceData.TryGetValue(uid, out var data);
        return data;
    }
}
