using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

	public Slider slider;
	public Gradient gradient;
	public Image fill;

    private void Start()
    {
        slider.maxValue = GetComponentInParent<BearHealth>().maxHealth;
	}
    private void Update()
    {
		slider.value = GetComponentInParent<BearHealth>().currHealth;
    }
}

