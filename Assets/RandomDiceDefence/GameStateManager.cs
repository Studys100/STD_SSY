using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 하나만 존재하는 게임 상태 관리자
public class GameStateManager : Singleton<GameStateManager>
{
    public enum State
    {
        None,
        Ready,
        InBattle,
        End
    }

    public State gameState = State.None;
}
