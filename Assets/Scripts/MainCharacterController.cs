using UnityEngine;

public class MainCharacterController : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed;
    private int _currentWaypointIndex;

    void Start()
    {
        _currentWaypointIndex = 0;
    }

    void Update()
    {
        if (_currentWaypointIndex == _waypoints.Length)
        {
            _currentWaypointIndex = 0;
        }
        Transform currentWaypoint = _waypoints[_currentWaypointIndex];
        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, _speed * Time.deltaTime);
        if (transform.position == currentWaypoint.position)
        {
            ++_currentWaypointIndex;
        }
    }
}
