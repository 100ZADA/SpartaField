using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransferScene : MonoBehaviour
{
    // �̵��� �� �̸�
    public string transferMapName;

    void Start()
    {

    }

    // �÷��̾�� �浹 ��
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(transferMapName);
        }
    }
}