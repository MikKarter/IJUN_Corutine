using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _delay = 0.5f;
    [SerializeField] private int _value = 1;
    [SerializeField] private int _minValue = 0;
    [SerializeField] private CounterView _counter;

    private bool _isRunning = false;

    public int CurrentValue { get; private set; }

    public event Action Changed;

    private void OnEnable()
    {
        CurrentValue = _minValue;
    }

    private void Update()
    {
        Switshing();
        AddValue();
    }

    private void AddValue()
    {
        if (_isRunning)
        StartCoroutine(IncreaseCouner());
        else
            StopCoroutine(IncreaseCouner());
    }

    private void Switshing ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isRunning == true)
            { 
                _isRunning = false;
            }
            else
            {
                _isRunning = true;
            }    
        }
            
    }

    private IEnumerator IncreaseCouner ()
    {
        float elapsedTime = 0f;

        while (elapsedTime <= _delay)
        {
            elapsedTime += Time.deltaTime;
        }

        CurrentValue += _value;        

        yield return null;
    }
}
