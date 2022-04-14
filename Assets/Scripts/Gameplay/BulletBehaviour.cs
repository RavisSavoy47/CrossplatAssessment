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

    //increases the owners damage
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

    /// <summary>
    /// once it collides with something it calls takedamage on the other health
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == OwnerTag)
            return;
        //sets the others health
        HealthBehaviour otherHealth = other.GetComponent<HealthBehaviour>();

        if (!otherHealth)
            return;
        //deals damage
        otherHealth.TakeDamge(_damage);

        //destroys the bullet on hit
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
