using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using Sirenix.OdinInspector;

public class MonsterMaker : MonoBehaviour
{
    [SerializeField, ReadOnly]
    int currentWave = 0;

    // 몬스터를 소환함, 데이터 기반으로
    // 언제? 게임이 시작 되면

    public void Start()
    {
        GameScene.CurrentScene.stateRP
            .Where(_state => _state == GameScene.State.Start)
            .Take(1) // 하나만 취한다
            .Subscribe(_state => {
                StartSpawnMonster();
            }).AddTo(this);
    }

    private void StartSpawnMonster()
    {
        var waveDatas = DataManager.Instance.GetWaveDatas;
        foreach (var waveData in waveDatas)
        {
            StartCoroutine(waveData.RegistSpawn());
        }
    }
}
