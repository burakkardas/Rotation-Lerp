using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLerp : MonoBehaviour
{
    [SerializeField] [Range(0f, 10f)] private float _lerpTime;
    [SerializeField] private float _time;
    [SerializeField] private Vector3[] _angles;
    float _currentTime;
    int _angleIndex;
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(_angles[_angleIndex]), _lerpTime * Time.deltaTime);

        if(_currentTime <= 0) {
            _currentTime = _time;
            _angleIndex++;
        }
        else {
            _currentTime -= Time.deltaTime;
        }

        if(_angleIndex >= _angles.Length) {
            _angleIndex = 0;
        }
    }
}
