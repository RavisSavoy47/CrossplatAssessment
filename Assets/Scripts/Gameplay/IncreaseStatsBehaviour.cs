using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseStatsBehaviour : MonoBehaviour
{
    [SerializeField]
    private HealthBehaviour _enemyHealth;
    [SerializeField]
    private BulletBehaviour _turret;
    [SerializeField]
    private EnemyMovementBehaviour _enemy;

    public virtual void IncreaseStats()
    {
        _enemyHealth.IncreaseHealth(10);
        _enemy.IncreaseDamge(1);
        _turret.IncreaseDamage(2);
    }
}
