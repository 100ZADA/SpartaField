using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    private bool isPlayerInRange = false;

    // NPC�� ���� ��� ���
    [SerializeField] private List<string> npcDialogue;

    // �÷��̾ ���� ������ ���ö�
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    // �÷��̾ ���� ������ ������
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }

    public bool CanTalk()
    {
        return isPlayerInRange;
    }

    // NPC ��� ��ȯ
    public List<string> GetDialogue()
    {
        return npcDialogue;
    }
}
