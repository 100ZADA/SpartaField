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
    }

    // ĳ���� ����
    protected override void HandleAction()
    {
        camera = Camera.main;

        float horizontal = Input.GetAxisRaw("Horizontal");  // ���� ����
        float vertical = Input.GetAxisRaw("Vertical");  // �¿� ����
        movementDirection = new Vector2(horizontal, vertical).normalized; // ������ ���� 1�� ����

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

        // EŰ�� ���� ȣ��
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(currentNPC == null)
            {
                return;
            }

            if (currentNPC.CanTalk())
            {
                List<string> npcDialogue = currentNPC.GetDialogue(); // ���� NPC ��ȭ ��������
                
                if(npcDialogue.Count > 0)
                {
                    DialogueManager.Instance.StartDialogue(npcDialogue);
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
