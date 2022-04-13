using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomBehaviour : MonoBehaviour
{
    private Camera _camera;
    private Vector2 _referenceAspectRation;
    private Vector3 _startPos;
    private float _refRatio;

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
        
    }
}
