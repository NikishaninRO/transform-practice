using UnityEngine;

public class DefenderController : Follower
{
    private Vector3 _offset;

    private void Start()
    {
        UpdateOffset();
    }

    private void Update()
    {
        Move();
    }

    protected override void Move()
    {
        transform.position = _target.position + _offset;
        transform.RotateAround(_target.transform.position, Vector3.up, _speed * Time.deltaTime);
        transform.LookAt(_target);
        UpdateOffset();
    }


    private void UpdateOffset()
    {
        _offset = transform.position - _target.position;
    }
}
