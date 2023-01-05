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

    private Rigidbody2D _rb2d = default;

    private void Start()
    {
        //以下の書き方は、このコンポーネントをアタッチしているオブジェクトからしか
        //取得できないため、注意
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        //TODO：移動処理(ジャンプ)
        var hol = Input.GetAxisRaw("Horizontal");
        var ver = Input.GetAxisRaw("Vertical");

        _rb2d.velocity = new Vector2(hol, ver) * _moveSpeed;
    }
}
