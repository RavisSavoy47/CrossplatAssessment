using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBehaviour : MovementBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _damage;

    public Transform Target
    {
        get { return _target; }
        set { _target = value; }
    }

    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public virtual float IncreaseDamge(float damgeIncrease)
    {
        _damage += damgeIncrease;

        return damgeIncrease;
    }

    // Update is called once per frame
    public override void Update()
    {
        Vector3 direction = _target.position - transform.position;
        Velocity = direction.normalized * Speed;

        base.Update();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _target)
        {
            //Increment the enemycount 
            HealthBehaviour castleHealth = other.GetComponent<HealthBehaviour>();
            if (castleHealth)
                castleHealth.TakeDamge(_damage);

            //destorys this enemy
            Destroy(gameObject);

            //HealthBehaviour _maxHealth = GetComponent<HealthBehaviour>();
            //if (_maxHealth.Health <= 0)
            //{
            //    //destorys this enemy
            //    Destroy(gameObject);
            //    _maxHealth.IncreaseHealth(5);
            //    IncreaseDamge(1);
            //}

        }
    }
}
