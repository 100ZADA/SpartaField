using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; // UI Ŭ�� ����

public class DialogueManager : MonoBehaviour, IPointerClickHandler
{
    public static DialogueManager Instance;

    [SerializeField] private GameObject dialoguePanel;  // ��ȭ �г�
    [SerializeField] private Text dialogueText;         // ��ȭ ����

    private Queue<string> sentences;    // NPC�� ��� ���� �� ������ ǥ��
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

    // �ؽ�Ʈ�� ������ ���� ���� ����
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
            Debug.Log("dialoguePanel Ŭ����! ���� �������� �̵�");
            DisplayNextSentence();
        }
    }
}
