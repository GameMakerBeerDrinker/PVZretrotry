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
    //����������ʲôֲ��
    public WhichPlant plant;
    //��������(�����½�Ϊ(0,0))
    public Vector2Int position;
}