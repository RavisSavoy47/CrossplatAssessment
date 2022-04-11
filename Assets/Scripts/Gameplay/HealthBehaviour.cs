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

    public float Health
    {
        get { return _health; }
    }

    public bool IsAlive
    {
        get { return _isAlive; }
    }

    public virtual float TakeDamge(float damgeAmount)
    {
        _health -= damgeAmount;

        return damgeAmount;
    }

    public virtual void OnDeath()
    {
        _health--;
    }

    // Update is called once per frame
    void Update()
    {
        if (_health <= 0 && IsAlive)
            OnDeath();

        _isAlive = _health > 0;

        if (!IsAlive && _destroyOnDeath)
            Destroy(gameObject);
    }
}
