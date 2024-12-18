using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private TextMeshProUGUI _counterText;

    private void OnEnable()
    {
        _counter.Changed += ViewValue;
    }

    private void OnDisable()
    {
        _counter.Changed -= ViewValue;
    }

    private void Update()
    {
        ViewValue();
    }

    private void ViewValue()
    {
        _counterText.text = _counter.CurrentValue.ToString();
    }
}
