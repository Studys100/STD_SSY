using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    // 게임의 상태를 관리

    // 게임의 상태는
    public enum State
    {
        RequireInit,
        Start,
        End,
    }

    // React,
    // 함수형 프로그래밍
    // 체이닝
    public ReactiveProperty<State> stateRP = new ReactiveProperty<State>(State.RequireInit);
    public static GameScene CurrentScene;

    private void Awake()
    {
        CurrentScene = this;
    }

    public void Start()
    {
        // 태초에 선언함,
        // 상태반응 변수가, 만약에 ? Start라면, 나는 그값을 지켜볼거야
        // UniRX는 Observer Pattern이 기본임

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
