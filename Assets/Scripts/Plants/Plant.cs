using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Plant : MonoBehaviour
{
    //植物的共有属性：花费、生命值
    public int cost,health;
    //行动间隔，每棵植物都是周期性地执行行动，或攻击或生产
    public float actColdDown;
    protected int actTimer = 0;

    private void Update()
    {
        if (health <= 0)
            Die();
    }

    public abstract void Act();
    public abstract void SetActColdDown();

    public virtual void Die()
    {
        Destroy(gameObject);
    }
}
