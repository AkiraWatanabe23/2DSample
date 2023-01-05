using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Player�̏����ɂ��ċL�q����N���X
/// </summary>
public class PlayerController : MonoBehaviour
{
    [Header("PlayerStatus�ꗗ")]
    [SerializeField] private float _moveSpeed = 1f;
    [SerializeField] private float _jumpPower = 1f;
    [SerializeField] private int _hp = 100;
    [SerializeField] private bool _isGround = false;

    private Rigidbody2D _rb2d = default;

    private void Start()
    {
        //�ȉ��̏������́A���̃R���|�[�l���g���A�^�b�`���Ă���I�u�W�F�N�g���炵��
        //�擾�ł��Ȃ����߁A����
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        //TODO�F�ړ�����(�W�����v)
        var hol = Input.GetAxisRaw("Horizontal");
        var ver = Input.GetAxisRaw("Vertical");

        _rb2d.velocity = new Vector2(hol, ver) * _moveSpeed;
    }
}
