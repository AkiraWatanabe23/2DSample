using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Playerの処理について記述するクラス
/// </summary>
public class PlayerController : MonoBehaviour
{
    [Header("PlayerStatus一覧")]
    [SerializeField] private float _moveSpeed = 1f;
    [SerializeField] private float _jumpPower = 1f;
    [SerializeField] private int _hp = 100;
    [SerializeField] private bool _isGround = false;

    private Rigidbody2D _rb = default;
    private float _input = 0;

    private void Start()
    {
        //コンポーネントの取得
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movement();
    }

    private void FixedUpdate()
    {
        //物理演算はFixedupdate()で行う
        _rb.velocity = new Vector2(_input * _moveSpeed, _rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _isGround = true;
    }

    private void Movement()
    {
        var hol = Input.GetAxisRaw("Horizontal");

        //横方向の入力を反映
        _input = hol;

        if (Input.GetButtonDown("Jump") && _isGround)
        {
            _rb.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
            _isGround = false;
        }
    }
}
