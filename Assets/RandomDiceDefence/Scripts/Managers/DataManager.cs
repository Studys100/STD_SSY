using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ������� �ʴ� �����Ϳ�, ���氡���� ���������Ϳ� ���� ����.
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
        // �������ּ���!! �ҿ���!!
        return null;
    }

    public EnemyDiceDatas GetEnmyDiceData(int uid)
    {
        uidToEnemyDiceData.TryGetValue(uid, out var data);
        return data;
    }
}
