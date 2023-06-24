using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pea : MonoBehaviour
{

    //豌豆的飞行速度与方向
    public float speed;
    //public int direction;

    //豌豆的伤害
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
    /// 豌豆的飞行
    /// </summary>
    public void Move()
    {
        transform.position += speed * Time.fixedDeltaTime  * Vector3.right;
    }
}
