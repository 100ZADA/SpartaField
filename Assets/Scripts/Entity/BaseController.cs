using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;

    [SerializeField] private SpriteRenderer characterRenderer;

    // ĳ���� �̵�
    protected Vector2 movementDirection = Vector2.zero;
    public Vector2 MovementDirection { get { return movementDirection; } }

    // ĳ���� ����
    protected Vector2 lookDirection = Vector2.zero;
    public Vector2 LookDirection { get { return lookDirection; } }

    protected AnimationHandler animationHandler;

    // ���� �� ������Ʈ�� ȣ��Ǵ� �̺�Ʈ �Լ�
    protected virtual void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        animationHandler = GetComponent<AnimationHandler>();
    }

    protected virtual void Start()
    {

    }

    // Ŭ���� ��� ȣ��
    protected virtual void Update()
    {
        HandleAction();
        Rotate(lookDirection);
    }

    protected virtual void FixedUpdate()
    {
        Movement(movementDirection);
    }

    protected virtual void HandleAction()
    {

    }

    private void Movement(Vector2 direction)
    {
        direction = direction * 5;
        
        _rigidbody.velocity = direction; // ������ �ӵ�
        animationHandler.Move(direction);
    }

    // ���콺 ����Ʈ ��ġ ã��
    private void Rotate(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        // ���콺 ��ġ�� 90�� �Ѿ�����
        bool isLeft = Mathf.Abs(rotZ) > 90f;
        characterRenderer.flipX = isLeft;
    }
}
