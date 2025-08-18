using UnityEngine;

public class EnemyController : Follower
{
    private void Update()
    {
        Move();
    }

    protected override void Move()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position, _speed * Time.deltaTime);
    }
}
