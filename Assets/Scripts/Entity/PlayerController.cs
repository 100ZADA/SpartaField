using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : BaseController
{
    private GameManager gameManager;
    private Camera camera;
    private NPCController currentNPC;

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

        if (lookDirection.magnitude < 0.9f)
        {
            lookDirection = Vector2.zero;
        }
        else
        {
            lookDirection = lookDirection.normalized;
        }

        // E키를 통해 호출
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(currentNPC == null)
            {
                Debug.Log(" 대화할 NPC가 없음!");
                return;
            }

            if (currentNPC.CanTalk())
            {
                List<string> npcDialogue = currentNPC.GetDialogue(); // 현재 NPC 대화 가져오기
                
                if(npcDialogue.Count > 0)
                {
                    DialogueManager.Instance.StartDialogue(npcDialogue);
                }
                else
                {
                    Debug.Log("대화할 NPC가 없음!");
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NonPlayer"))
        {
            currentNPC = collision.GetComponent<NPCController>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("NonPlayer"))
        {
            currentNPC = null;
        }
    }
}
