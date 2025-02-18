using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MiniPlayer : MonoBehaviour
{
    GameManager2 gameManager2 = null;

    Animator animator = null;
    Rigidbody2D _rigidbody = null;

    // Player ����
    public float flapForce = 6f;
    public float forwardSpeed = 3f;
    public bool isDead = false;
    float deathCooldown = 0f;

    bool isFlap = false;

    // �׽�Ʈ ���
    public bool TestMode = false;

    void Start()
    {
        gameManager2 = GameManager2.Instance;

        animator = transform.GetComponentInChildren<Animator>();
        _rigidbody = transform.GetComponent<Rigidbody2D>();

        if(animator == null)
        {
            Debug.LogError("Not Founded Animator");
        }
        
        if(_rigidbody == null)
        {
            Debug.LogError("Not Founded Rigidbody");
        }
    }

    // �÷��̾� ���� ���
    void Update()
    {
        if (isDead)
        {
            if(deathCooldown <= 0)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    gameManager2.RestartGame();
                }
            }
            else
            {
                deathCooldown -= Time.deltaTime;
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                isFlap = true;
            }
        }
    }

    public void FixedUpdate()
    {
        if (isDead)
        {
            return;
        }

        Vector3 velocity = _rigidbody.velocity;
        velocity.x = forwardSpeed;

        if (isFlap)
        {
            velocity.y += flapForce;
            isFlap = false;
        }

        _rigidbody.velocity = velocity;

        // �÷��̾��� Ŭ���� ���� y�� ���� 
        float angle = Mathf.Clamp((_rigidbody.velocity.y * 10f), -90, 90);
        float lerpAngle = Mathf.Lerp(_rigidbody.velocity.y, angle, Time.fixedDeltaTime * 5f);
        transform.rotation = Quaternion.Euler(0, 0, lerpAngle);
    }

    // �浹 �۾�
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (TestMode)
        {
            return;
        }

        if (isDead)
        {
            return;
        }

        animator.SetInteger("IsDie", 1);
        isDead = true;
        deathCooldown = 1f;
        gameManager2.GameOver();
    }
}
