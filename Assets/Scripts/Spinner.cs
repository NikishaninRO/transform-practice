using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _rotationCenter;
    private Vector3 _offset;


    private void Start()
    {
        UpdateOffset();
    }

    private void Update()
    {
        transform.position = _rotationCenter.position + _offset;
        transform.Rotate(Vector3.up, _speed * Time.deltaTime);
        transform.RotateAround(_rotationCenter.transform.position, Vector3.up, _speed * Time.deltaTime);
        UpdateOffset();
    }


    private void UpdateOffset()
    {
        _offset = transform.position - _rotationCenter.position;
    }
}
