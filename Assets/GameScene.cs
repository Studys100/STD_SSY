using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    // ������ ���¸� ����

    // ������ ���´�
    public enum State
    {
        RequireInit,
        Start,
        End,
    }

    // React,
    // �Լ��� ���α׷���
    // ü�̴�
    public ReactiveProperty<State> stateRP = new ReactiveProperty<State>(State.RequireInit);
    public static GameScene CurrentScene;

    [SerializeField]
    MonsterPathes monsterPath;
    public MonsterPathes GetMonsterPath => monsterPath;

    private void Awake()
    {
        CurrentScene = this;
    }

    public void Start()
    {
        // ���ʿ� ������,
        // ���¹��� ������, ���࿡ ? Start���, ���� �װ��� ���Ѻ��ž�
        // UniRX�� Observer Pattern�� �⺻��

        stateRP
            .Where(_state=>_state == State.Start)
            .Subscribe(_state => {
                Debug.LogError("state : " + _state);
            }).AddTo(this);
    }

    public void TryStartGame()
    {
        if(stateRP.Value == State.RequireInit)
        {
            stateRP.Value = State.Start;
        }
    }
}
