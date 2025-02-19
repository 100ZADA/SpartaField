using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector2 minCameraBoundary;  // 카메라 최소 범위
    [SerializeField] Vector2 maxCameraBoundary;  // 카메라 최대 범위

    // 카메라가 플레이어 따라 이동
    private void LateUpdate()
    {
        Vector3 targetPos = new Vector3(player.position.x, player.position.y, this.transform.position.z);

        targetPos.x = Mathf.Clamp(targetPos.x, minCameraBoundary.x, maxCameraBoundary.x);  // Mathf.Clamp 통해 카메라 최소값 설정
        targetPos.y = Mathf.Clamp(targetPos.y, minCameraBoundary.y, maxCameraBoundary.y);  // Mathf.Clamp 통해 카메라 최대값 설정

        transform.position = targetPos;     
    }
}
