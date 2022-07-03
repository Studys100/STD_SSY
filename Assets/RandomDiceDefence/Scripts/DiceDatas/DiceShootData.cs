using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// const, 1�� ����
public class DiceShootData : DiceData
{
    public float cooltime; // 1 �̸� 1�ʿ� �ѹ� ��
    public float bulletSpeed;
    public GameObject prefabForBullet;

    // mutable, N���� ����
    public class RuntimeDiceShootData : RuntimeDiceData
    {
        public DiceShootData originData;
        public float rate;
        float currentLastShootTime;
        public float GetBuffedBulletSpeed => originData.bulletSpeed ;

        public void Shoot()
        {
            // cooltime�� �ѹ��� shoot�� ȣ��
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
