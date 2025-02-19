using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    private bool isPlayerInRange = false;

    // NPC의 개별 대사 출력
    [SerializeField] private List<string> npcDialogue;

    // 플레이어가 범위 안으로 들어올때
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    // 플레이어가 범위 밖으로 나갈때
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

    // NPC 대사 반환
    public List<string> GetDialogue()
    {
        return npcDialogue;
    }
}
