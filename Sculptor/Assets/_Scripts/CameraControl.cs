using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Vector3 _rotation;

    [SerializeField]
    private List<float> _rotCamera;
    private int _namberPos;

    void Start()
    {
        _namberPos = 0;
        _rotation = transform.eulerAngles;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            NexPos();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            PreviousPos();
        }
    }
    private void FixedUpdate()
    {
        transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, _rotation, 0.2f);
    }

    private void NexPos()
    {
        if (_namberPos >= _rotCamera.Count-1)
        {
            _namberPos = 0;
        }
        else
        {
            _namberPos++;
        }
        _rotation.y = _rotCamera[_namberPos];
        Debug.Log(_namberPos);
    }
    private void PreviousPos()
    {
        if (_namberPos <= 0)
        {
            _namberPos = _rotCamera.Count-1;
        }
        else
        {
            _namberPos--;
        }
        _rotation.y = _rotCamera[_namberPos];
        Debug.Log(_namberPos);
    }
    [ContextMenu("RecordingRotationCamera")]
    private void RecordingRotationCamera()
    {
        _rotCamera.Add(transform.eulerAngles.y);
    }
}
