using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehaviour : MonoBehaviour
{
    private Slider _slider;
    [SerializeField]
    private HealthBehaviour _castleHealth;
    // Start is called before the first frame update
    void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _castleHealth.Health;
    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = _castleHealth.Health;

    }
}
