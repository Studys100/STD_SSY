using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

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
public abstract class DiceData
{
    public List<int> InitialBuffIDs = new List<int>(); // 태극 같은 것들, 태엽같은 애들
    public float PointForSummon;
    public int BulletID;                              // 어떤 총알을 쏠 것인지

    abstract public RuntimeDiceData MakeRuntimeData();
}

// 실제 런타임시에 필요한 데이터 구성
public abstract class RuntimeDiceData
{
    abstract public void Start();
    abstract public void Update();
    abstract public void OnDie();


}

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/DiceDatas", order = 1)]
public class DiceDatas : SerializedScriptableObject
{
    [SerializeField]
    List<DiceData> diceDatas = new List<DiceData>();
}