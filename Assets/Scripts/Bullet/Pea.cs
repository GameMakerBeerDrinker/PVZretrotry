using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pea : MonoBehaviour
{

    //�㶹�ķ����ٶ��뷽��
    public float speed;
    //public int direction;

    //�㶹���˺�
    public int damage;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Move();
    }

    /// <summary>
    /// �㶹�ķ���
    /// </summary>
    public void Move()
    {
        transform.position += speed * Time.fixedDeltaTime  * Vector3.right;
    }
}
