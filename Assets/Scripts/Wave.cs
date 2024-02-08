using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OneLine;

[System.Serializable]
public class SpawnItemData
{
    public float delay;
    public bool isBomb;
    public float x;
    public Vector2 velocity = new Vector2(0, 10f);
    public bool isRandomPosition;
    public bool isRandomVelocity;
    public bool isRandomBomb;

}

[System.Serializable]
public class Wave
{
    [OneLineWithHeader]public List<SpawnItemData> items;
}
