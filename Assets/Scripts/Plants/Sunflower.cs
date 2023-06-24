using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunflower : Plant
{
    public GameObject sun;

    private void Start()
    {
        actColdDown = Random.Range(300, 1250);
    }

    private void FixedUpdate()
    {
        Act();
    }

    public override void Act()
    {
        //throw new System.NotImplementedException();
        actTimer++;
        if (actTimer == actColdDown)
        {
            Instantiate(sun, transform.position,Quaternion.Euler(0,0,0));
            actTimer = 0;
            SetActColdDown();
        }
    }

    public override void SetActColdDown()
    {
        actColdDown = Random.Range(2350, 2500);
    }
}
