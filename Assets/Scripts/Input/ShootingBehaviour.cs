using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootingBehaviour : MonoBehaviour
{
    [SerializeField]
    private BulletEmitterBehaviour _gun;

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.sceneCount == 1 & Input.GetMouseButtonDown(0))
        {
            _gun.Fire();
        }
    }
}
