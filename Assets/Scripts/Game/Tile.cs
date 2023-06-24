using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Tile : MonoBehaviour
{
    public Tilemap tilemap { get; private set; }

    private void Awake()
    {
        tilemap = GetComponent<Tilemap>();
    }
}
