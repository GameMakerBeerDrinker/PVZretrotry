using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Plant : MonoBehaviour
{
    //ֲ��Ĺ������ԣ����ѡ�����ֵ
    public int cost,health;
    //�ж������ÿ��ֲ�ﶼ�������Ե�ִ���ж����򹥻�������
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
