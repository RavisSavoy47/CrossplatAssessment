using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBehaviour : MonoBehaviour
{
    [SerializeField]
    private EnemyMovementBehaviour _enemy;
    [SerializeField]
    private Transform _enemyTarget;

    [SerializeField]
    private float _spawnTime = 5.0f;
    private float _timer = 0.0f;

    private void Update()
    {
        if (_timer >= _spawnTime)
        {
            EnemyMovementBehaviour spawnedEnemy = Instantiate(_enemy, transform.position, transform.rotation);
            spawnedEnemy.Target = _enemyTarget;
            _timer = 0.0f;
        }
        _timer += Time.deltaTime;
    }
}
