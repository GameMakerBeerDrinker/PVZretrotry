using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager uIManager;

    public TextMeshProUGUI sun;

    private void Awake()
    {
        if (uIManager == null)
            uIManager = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sun.text = GameManager.gameManager.sun.ToString();
    }
}
