using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : Singleton<BattleManager>
{
    private void Awake()
    {
        new BattleManager();
        GameStateManager.Instance.gameState = GameStateManager.State.InBattle;
    }
}
