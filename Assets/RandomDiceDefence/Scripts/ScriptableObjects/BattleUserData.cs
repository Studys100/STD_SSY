using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 생명 주기 : 로그인시에 생성
// 로그아웃 시에 해제 됨.
//public class UserData
//{
//    // 전투 덱
//    // 1번덱에 dice가 32, 10, 50, 22, 31, -
//    public List<int> UserBattleTeam1 = new List<int>();
//    public Dictionary<int, UserDiceData> uidToUserDiceData;
//}

// 생명 주기를 파악해야 함
// 스크립트에이블 오브젝트인가? 아니다.
// 생명주기가 언제 시작? 전투 진입 전,

// const
public class DiceData
{
    public List<int> InitialBuffID = new List<int>(); // 태극 같은 것들, 태엽같은 애들
    public float PointForSummon;
    public int BulletID;                              // 어떤 총알을 쏠 것인지

}

// current data

public class CurrentDiceData
{

}

public class BattleUserData
{
    [SerializeField]
    int UserID;

    [SerializeField]
    int PointForSummon;
}
