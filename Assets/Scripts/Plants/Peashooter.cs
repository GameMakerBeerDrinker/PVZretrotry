using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peashooter : Plant
{
    //��ȡ�㶹������
    public GameObject pea;


    void Start()
    {
        //�㶹��������ʱ�������һ�������趨��ȴ
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
