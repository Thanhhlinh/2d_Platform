﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObject", menuName = "ScriptableObject/PlayerStats")]
public class PlayerStats : ScriptableObject
{
    [Header("Speed")]
    [SerializeField] private float _speedX;
    [SerializeField] private float _speedY;
    [SerializeField] private float _wallSlideSpeed;
    [SerializeField] private Vector2 _wallJumpSpeed;

    [Header("Force")]
    [SerializeField] private Vector2 _knockBackForce;
    [SerializeField] private Vector2 _dashForce;

    //Đạt được nhiều thành tựu thì mới tăng thêm maxHP
    [Header("HP"), Range(1, GameConstants.PLAYER_MAX_HP_LEVEL_2)]
    [SerializeField] private int _maxHP;

    [Header("Factor")]
    [SerializeField, Range(1f, 2f)] private float _jumpSpeedFactor;
    [SerializeField, Range(1f, 2f)] private float _dbJumpSpeedFactor; //Db jump 0 thể mạnh hơn Jump
    [SerializeField] private float _gravScale;

    [Header("Time")]
    //Disable Time Là khoảng thgian mà mình disable directionX ở state WallJump
    //Mục đích cho nó nhảy hướng ra phía đối diện cái wall vừa đu
    //Mà 0 bị ảnh hưởng bởi input directionX
    [SerializeField] private float _jumpTime;
    [SerializeField] private float _disableTime;
    [SerializeField] private float _delayDashTime;
    [SerializeField] private float _invulnerableTime;
    [SerializeField] private float _timeEachApplyAlpha;
    [SerializeField] private float _coyoteTime;

    [Header("Alpha Value")]
    [SerializeField] private float _alphaValueGotHit;

    public float SpeedX { get { return _speedX; } }

    public float SpeedY { get { return _speedY; } }

    public float WallSlideSpeed { get { return _wallSlideSpeed; } }

    public Vector2 WallJumpSpeed { get { return _wallJumpSpeed; } }

    public Vector2 KnockBackForce { get { return _knockBackForce; } }

    public Vector2 DashForce { get { return _dashForce; } }

    //Xử lý cẩn thận
    public int MaxHP { get { return _maxHP; } set { _maxHP = value; } } //Ngoại lệ

    public float JumpSpeedFactor { get { return _jumpSpeedFactor; } }

    public float DbJumpSpeedFactor { get { return _dbJumpSpeedFactor; } }

    public float GravScale { get { return _gravScale; } }

    public float JumpTime { get { return _jumpTime; } }

    public float DisableTime { get { return this._disableTime; } }

    public float DelayDashTime { get { return _delayDashTime; } }

    public float InvulnerableTime { get { return _invulnerableTime; } }

    public float TimeEachApplyAlpha { get { return _timeEachApplyAlpha; } }

    public float CoyoteTime { get { return _coyoteTime; } }

    public float AlphaValueGotHit { get { return _alphaValueGotHit; } }

}
