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


        //if (Physics.Raycast(transform.position, transform.forward, out hitInfo, 30))
        //{
        //    if (hitInfo.transform.gameObject)
        //    {
        //        m_targetPos = hitInfo.transform.gameObject.transform.position;

        //    }
        //}

        //Cast a ray from the camera using the mouse position
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

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
