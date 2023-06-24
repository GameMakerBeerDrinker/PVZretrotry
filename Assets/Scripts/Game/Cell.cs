using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Cell
{
    public enum Type
    {
        Invalid,
        Grass,
        Soil
    };

    public Type type;
    //格子上种了什么植物
    public WhichPlant plant;
    //格子坐标(以左下角为(0,0))
    public Vector2Int position;
}