using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UserDataManager;

// 유저 데이터를 관리합니다.
public class UserDataManager : Singleton<UserDataManager>
{
    public int Gold;
    
    [SerializeField]
    List<int> uidsForDiceData = new List<int>();

    // Composite 패턴에는 소유자 개념이 있음.
    // 소유자는 여러 기능들 갖음.
    public class BattleDiceActor : IBuffable
    {
        // 읽어들일 원본 데이터
        public DiceData data { get; set; } // 다형성을 갖 고 있는 ReadOnly Data

        // Dice Data의 Runtime 버전
        public RuntimeDiceData runtimeData { get; set; }

        public List<Buff> buffs { get; private set; } = new List<Buff>();

        // speed

        public void Init()
        {
            // 버프 시스템 초기화
            foreach(var id in data.InitialBuffIDs)
            {
                this.AddBuff(id);
            }

            // 런타임시에 필요한 데이터를 동적으로 생성
            runtimeData = data.MakeRuntimeData(); 
        }

        public void UpdateBuff()
        {

        }
    }
    public class CurrentEnemyData : IBuffable
    {
        public EnemyDiceData data { get; set; }
        public List<Buff> buffs { get; private set; } = new List<Buff>();

        public float speedRateValue = 1;

        // GetSpeed (기획자가 설정한 스피드 값) * speedBuffValue(1)
        public float GetBuffedSpeed => data.GetSpeed * speedRateValue;
    }

    

    public override void Init()
    {
        base.Init();
    }
}
