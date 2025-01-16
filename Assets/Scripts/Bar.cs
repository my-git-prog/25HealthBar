using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bar : MonoBehaviour
{
    [SerializeField] private Parameter _parameter;

    protected int MaximumValue;
    protected int Value;

    private void Start()
    {
        SetMaximumValue();
        SetValue();
    }

    private void OnEnable()
    {
        _parameter.ValueChanged += SetValue;
    }
    private void OnDisable()
    {
        _parameter.ValueChanged -= SetValue;
    }

    protected virtual void SetMaximumValue()
    {
        MaximumValue = _parameter.MaximumValue;
    }

    protected virtual void SetValue()
    {
        Value = _parameter.Value;
    }
}
