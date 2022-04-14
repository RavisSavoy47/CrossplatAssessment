using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehaviour : MonoBehaviour
{
    private Slider _slider;
    [SerializeField]
    private HealthBehaviour _castleHealth;

    //sets the slider makes it equal to the castle health
    void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _castleHealth.Health;
    }

    // Update is called once per frame
    void Update()
    {
        //sets the value of to be the health
        _slider.value = _castleHealth.Health;
    }
}
