using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _health;
    [SerializeField]
    private bool _isAlive;
    [SerializeField]
    private bool _destroyOnDeath;

    public virtual float Health
    {
        get { return _health; }
    }

    public bool IsAlive
    {
        get { return _isAlive; }
    }

    //The damage taken 
    public virtual float TakeDamge(float damgeAmount)
    {
        _health -= damgeAmount;

        return damgeAmount;
    }

    //Increases the health 
    public virtual float IncreaseHealth(float HealthIncrease)
    {
        _health += HealthIncrease;

        return HealthIncrease;
    }

    //when they take damage 
    public virtual void OnDeath()
    {
        _health--;
    }

    // Update is called once per frame
    void Update()
    {
        //checks if there health and is still alive
        if (_health <= 0 && IsAlive)
            OnDeath();

        _isAlive = _health > 0;

        //if the actor is dead
        if (!IsAlive && _destroyOnDeath)
        {
            Destroy(gameObject);
        }
            
    }
}
