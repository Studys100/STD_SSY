using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// const, 1개 생김
public class DiceShootData : DiceData
{
    public float cooltime; // 1 이면 1초에 한번 쏨
    public float bulletSpeed;
    public GameObject prefabForBullet;

    // mutable, N개씩 생김
    public class RuntimeDiceShootData : RuntimeDiceData
    {
        public DiceShootData originData;
        public float rate;
        float currentLastShootTime;
        public float GetBuffedBulletSpeed => originData.bulletSpeed ;

        public void Shoot()
        {
            // cooltime에 한번씩 shoot이 호출
        }

        public override void OnDie()
        {
        }


        public override void Start()
        {
            
        }

        public override void Update()
        {
            if(Time.time - currentLastShootTime > originData.cooltime)
            {
                currentLastShootTime = Time.time;
                Shoot();
            }
        }
    }

    public override RuntimeDiceData MakeRuntimeData()
    {
        return new RuntimeDiceShootData() { originData = this };
    }
}
