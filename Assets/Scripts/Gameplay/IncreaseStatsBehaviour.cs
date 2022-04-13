using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseStatsBehaviour : MonoBehaviour
{
    [SerializeField]
    private HealthBehaviour _enemyHealth;
    [SerializeField]
    private BulletBehaviour _turret;

    public virtual void IncreaseStats()
    {
        _enemyHealth.IncreaseHealth(10);
        _turret.IncreaseDamage(11);
    }
}
