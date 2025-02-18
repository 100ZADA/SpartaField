using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Obstacle : MonoBehaviour
{
    // 장애물 위치
    public float higPosY = 1f;
    public float lowPosX = -1f;

    // 장애물 사이즈
    public float holeSizeMin = 1f;
    public float holeSizeMax = -1f;

    //
    public Transform topObject;
    public Transform bottomObject;
}
