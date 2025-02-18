using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; // UI 클릭 감지

public class DialogueManager : MonoBehaviour, IPointerClickHandler
{
    public static DialogueManager Instance;

    [SerializeField] private GameObject dialoguePanel;  // 대화 패널
    [SerializeField] private Text dialogueText;         // 대화 내용

    private Queue<string> sentences;    // NPC의 대사 저장 및 순차적 표시
    private bool isTalking = false;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
       
        sentences = new Queue<string>();
        dialoguePanel.SetActive(false);
    }

    public void StartDialogue(List<string> dialogue)
    {
        isTalking = true;
        dialoguePanel.SetActive(true);
        sentences.Clear();

        foreach(string sentence in dialogue)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    // 텍스트가 끝나면 다음 문장 진행
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    public void EndDialogue()
    {
        isTalking = false;
        dialoguePanel.SetActive(false);
    }

    public void OnPointerClick(PointerEventData evnetData)
    {
        if (isTalking)
        {
            Debug.Log("dialoguePanel 클릭됨! 다음 문장으로 이동");
            DisplayNextSentence();
        }
    }
}
