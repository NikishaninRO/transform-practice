using System;
using UnityEngine;

public abstract class Follower : MonoBehaviour
{
    [SerializeField] protected Transform _target;
    [SerializeField] protected float _speed;
    abstract protected void Move();
}
