using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    /*enum Type
    {
        Natural,
        Produced,
    }*/
    public int value;
    private bool collected;
    public Vector3 destination;
    public float speed;
    public float disappearTime;
    public float disappearTimer;

    private void Start()
    {
        
    }

    private void Update()
    {
        Collect();
    }

    
    private void FixedUpdate()
    {
        if (collected)
            Moveto(destination);
        disappearTimer++;
        if (disappearTimer == disappearTime)
            Destroy(gameObject);
    }

    public void Collect()
    {
        if(Input.GetMouseButton(0)&&!collected)
        {
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10);
            Vector3 distance = clickPosition - transform.position;
            if (distance.magnitude<0.4f)
            {
                Debug.Log("collect sun");
                collected = true;
                GameManager.gameManager.sun += value;
            }
        }
    }
    
    private void Moveto(Vector3 destination)
    {
        Vector3 direction = (destination - transform.position).normalized;
        //Debug.Log(direction);
        transform.position += direction * speed * Time.fixedDeltaTime;
        if ((destination - transform.position).magnitude < 0.1f)
            Destroy(gameObject);
    }
}
