using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peashooter : Plant
{
    //获取豌豆的索引
    public GameObject pea;


    void Start()
    {
        //豌豆射手种下时，对其第一发攻击设定冷却
        SetActColdDown();
    }

    void FixedUpdate()
    {
        Act();
    }
    public override void Act()
    {
        actTimer++;
        if (actTimer==actColdDown)
        {
            Instantiate(pea, transform.position, Quaternion.Euler(0, 0, 0));
            actTimer = 0;
            SetActColdDown();
        }
    }

    public override void SetActColdDown()
    {
        actColdDown = Random.Range(136, 150);
    }
}
