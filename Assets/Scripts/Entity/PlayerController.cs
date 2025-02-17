using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseController
{
    private GameManager gameManager;
    private Camera camera;

    public void Init(GameManager gameManager)
    {
        this.gameManager = gameManager;
        camera = Camera.main;
    }

    // 캐릭터 조작
    protected override void HandleAction()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");  // 상하 조작
        float vertical = Input.GetAxisRaw("Vertical");  // 좌우 조작
        movementDirection = new Vector2(horizontal, vertical).normalized; // 벡터의 방향 1로 지정
                                                                          
        Vector2 mousePosition = Input.mousePosition;
        Vector2 worldPos = camera.ScreenToWorldPoint(mousePosition);
        lookDirection = (worldPos - (Vector2)transform.position);

        if(lookDirection.magnitude < 0.9f)
        {
            lookDirection = Vector2.zero;
        }
        else
        {
            lookDirection = lookDirection.normalized;
        }
    }
}
