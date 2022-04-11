using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEmitterBehaviour : MonoBehaviour
{
    [SerializeField]
    private BulletBehaviour _bulletRef;
    [SerializeField]
    private float _bulletForce;
    [SerializeField]
    private GameObject _owner;

    public void Fire()
    {
        GameObject bullet = Instantiate(_bulletRef.gameObject, transform.position, transform.rotation);
        BulletBehaviour bulletBehaviour = bullet.GetComponent<BulletBehaviour>();
        bulletBehaviour.OwnerTag = _owner.tag;
        bulletBehaviour.RigidBody.AddForce(transform.forward * _bulletForce, ForceMode.Impulse);
    }
}
