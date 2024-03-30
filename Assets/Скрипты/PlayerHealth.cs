using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float value = 100;
    public RectTransform valueRectTransform;

    public GameObject gameplay;
    public GameObject gameOver;

    private float _maxValue;

    private void Start()
    {
        _maxValue = value;
        HealthBar();
    }

    public void DealDamage(float damage)
    {
        value -= damage;
        if (value <= 0)
        {
            Sdox();
        }
        HealthBar();
    }
    private void Sdox()
    {
            gameplay.SetActive(false);
            gameOver.SetActive(true);
            GetComponent<PlayerController>().enabled = false;
            GetComponent<FireballCaster>().enabled = false;
            GetComponent<CameraRotation>().enabled = false;
    }

    private void HealthBar()
    {
        valueRectTransform.anchorMax = new Vector2(value / _maxValue, 1);
    }
}
