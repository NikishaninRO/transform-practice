using UnityEngine;

public class Observer : MonoBehaviour
{
    [SerializeField] private Transform _followTarget;

    private void Update()
    {
        var direction = (_followTarget.transform.position - transform.position).normalized;
        transform.forward = direction;
    }
}
