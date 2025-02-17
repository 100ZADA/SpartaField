using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector2 minCameraBoundary;  // ī�޶� �ּ� ����
    [SerializeField] Vector2 maxCameraBoundary;  // ī�޶� �ִ� ����

    // ī�޶� �÷��̾� ���� �̵�
    private void LateUpdate()
    {
        Vector3 targetPos = new Vector3(player.position.x, player.position.y, this.transform.position.z);

        targetPos.x = Mathf.Clamp(targetPos.x, minCameraBoundary.x, maxCameraBoundary.x);  // Mathf.Clamp ���� ī�޶� �ּҰ� ����
        targetPos.y = Mathf.Clamp(targetPos.y, minCameraBoundary.y, maxCameraBoundary.y);  // Mathf.Clamp ���� ī�޶� �ִ밪 ����

        transform.position = targetPos;     
    }
}
