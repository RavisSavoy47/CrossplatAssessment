using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBehaviour : MonoBehaviour
{
    [SerializeField]
    private Vector3 m_targetPos;
    private Camera _camera;
    private bool _isSelected = false;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _camera = Camera.main;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hitInfo;
        //Cast a ray from the camera using the mouse position
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        //If the ray hit an object...
        if (Physics.Raycast(ray, out hitInfo) & _isSelected == true)
        {
            m_targetPos = (hitInfo.point );
            transform.LookAt(m_targetPos);
            _isSelected = false;
        }
    }
    private void OnMouseDrag()
    {
        _isSelected = true;
    }
}
