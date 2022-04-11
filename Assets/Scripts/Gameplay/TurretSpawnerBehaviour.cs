using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSpawnerBehaviour : MonoBehaviour
{
    [SerializeField]
    private TurretBehaviour _turret;
    [SerializeField]
    private Vector3 _newLocation;
    private Camera _camera;
    private bool _isSelected = false;
    private float _spawnTime = 5.0f;

    public void Instantiate()
    {
         RaycastHit spawnInfo;
        //Cast a ray from the camera using the mouse position
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out spawnInfo) & _isSelected == true)
        {
            _newLocation = (spawnInfo.point);
            _isSelected = false;
            _spawnTime = 5;
        }
    }

    private void Update()
    {
        if(_spawnTime >= 5)
        {
            TurretBehaviour spawnedTurret = Instantiate(_turret, transform.position, transform.rotation);
            spawnedTurret.transform.position = _newLocation;
        }
        
    }
    private void OnMouseDown()
    {
        _isSelected = true;
    }

}
