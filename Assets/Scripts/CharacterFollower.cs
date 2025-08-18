using UnityEngine;

public class CharacterFollower : MonoBehaviour
{
    [SerializeField] private Transform _followTarget;
    [SerializeField] private float _minDistance;
    [SerializeField] private float _speed;

    private void Update()
    {
        float distance = Mathf.Abs(_followTarget.position.z - transform.position.z);
        if (distance > _minDistance)
        {
            transform.Translate(new Vector3(0, 0, Mathf.Lerp(0, distance, 0.1f * _speed * Time.deltaTime)));
        }
    }
}
