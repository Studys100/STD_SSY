using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserGenerateButton : MonoBehaviour
{
    [SerializeField]
    GameObject diceStartPositionGO; // 변수는 카멜표기법을 따름

    [SerializeField]
    GameObject diceNextPositionGO; 

    public void OnButton() {
        Debug.Log("Generate User's Dice start");
        var diceInstanced = GameObject.Instantiate(GameSceneBase.GetActive<BattleScene>().prefabDice); // 다이스를 생성을 했고
        diceInstanced.transform.position = diceStartPositionGO.transform.position;  // 다이스의 transform.position을 dice Start Position 게임오브젝트의 위치를 대입

        var diffToDir = diceNextPositionGO.transform.position - diceStartPositionGO.transform.position; // 오른쪽 아래로 향하는 방향 백터

        // 가로행을 5개
        // 세로열을 3개
        var randIndexX = Random.Range(0, 5);
        var randIndexY = Random.Range(0, 3);

        var rangeFromStartX = diffToDir.x * randIndexX;
        var rangeFromStartY = diffToDir.y * randIndexY;

        // 만들어진 처음 주사위의 위치가 랜덤한 인덱스만큼 이동됨
        diceInstanced.transform.position += new Vector3(rangeFromStartX, rangeFromStartY);

        Debug.Log("Generate User's Dice end");
    }
}
