using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour,IPointerDownHandler
{
    public WhichPlant plant;
    public int coldDown;
    private int coldDownTimer;
    public int cost;
    public bool availableOnStart;

    private void Start()
    {
        
        if (availableOnStart)
            coldDownTimer = coldDown;
    }

    private void Update()
    {
        coldDownTimer++; 
    }

    private void ColdDown()
    {

    }

    private void PickedUp()
    {
        if (GameManager.gameManager.sun >= cost && coldDownTimer >= coldDown)
        {
             GameManager.gameManager.pickedUpPlant = plant;
            //Debug.Log(gameManager.pickedUpPlant);
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("pointerdown");
        PickedUp();
    }
}
