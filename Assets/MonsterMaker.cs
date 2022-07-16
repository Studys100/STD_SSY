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

    // ���͸� ��ȯ��, ������ �������
    // ����? ������ ���� �Ǹ�

    public void Start()
    {
        GameScene.CurrentScene.stateRP
            .Where(_state => _state == GameScene.State.Start)
            .Take(1) // �ϳ��� ���Ѵ�
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
