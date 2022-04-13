using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    private string _ownerTag;
    [SerializeField]
    private float _damage;
    [SerializeField]
    private float _lifeTime;
    [SerializeField]
    private bool _destroyOnHit;
    private float _currentLifeTime;
    private Rigidbody _rigidbody;


    public string OwnerTag
    {
        get { return _ownerTag; }
        set { _ownerTag = value; }
    }

    public Rigidbody RigidBody
    {
        get { return _rigidbody; }
    }

    public virtual float IncreaseDamage(float damageIncrease)
    {
        _damage += damageIncrease;

        return damageIncrease;
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();

        _damage = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == OwnerTag)
            return;

        HealthBehaviour otherHealth = other.GetComponent<HealthBehaviour>();

        if (!otherHealth)
            return;


        otherHealth.TakeDamge(_damage);

        if (_destroyOnHit)
        {
            Destroy(gameObject);
        }
            
    }
    private void Update()
    {
        _currentLifeTime += Time.deltaTime;

        if (_currentLifeTime >= _lifeTime)
            Destroy(gameObject);
    }
}
