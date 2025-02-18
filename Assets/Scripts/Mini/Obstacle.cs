using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Obstacle : MonoBehaviour
{
    // 장애물 위치
    public float highPosY = 1f;
    public float lowPosY = -1f;

    // 장애물 사이즈
    public float holeSizeMin = 1f;
    public float holeSizeMax = -1f;

    public Transform topObject;
    public Transform bottomObject;

    public float widthPadding = 4f;

    // 장애물 랜덤 소환
    public Vector3 SetRandomPlace(Vector3 lastPosition, int obstacleCount)
    {
        float holeSize = Random.Range(holeSizeMin, holeSizeMax);
        float halfHoleSize = holeSize / 2f;
        topObject.localPosition = new Vector3(0, halfHoleSize);
        bottomObject.localPosition = new Vector3(0, -holeSize);

        Vector3 placePosition = lastPosition + new Vector3(widthPadding, 0);
        placePosition.y = Random.Range(lowPosY, highPosY);

        transform.position = placePosition;

        return placePosition;
    }
}
