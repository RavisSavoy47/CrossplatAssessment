using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraZoomBehaviour : MonoBehaviour
{
    private Camera _camera;
    [SerializeField]
    private Vector2 _referenceAspectRation;
    private Vector3 _startPos;
    private float _refRatio;
    [SerializeField]
    private Vector3 _zoomScale = Vector3.one;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();
        _refRatio = _referenceAspectRation.x / _referenceAspectRation.y;
        _startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        double ratio = _refRatio / _camera.aspect;
        ratio = Math.Round(ratio, 4);

        Vector3 scalePosition = Vector3.Scale(_startPos * (float)ratio, _zoomScale);

        transform.position = scalePosition;
    }
}
