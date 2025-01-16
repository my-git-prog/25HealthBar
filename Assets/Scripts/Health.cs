using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _minimumValue = 0;
    [SerializeField] private int _maximumValue = 100;

    private int _value;

    public event Action ValueChanged;

    public int MaximumValue => _maximumValue;
    public int Value => _value;

    private void Awake()
    {
        _value = _maximumValue;
    }

    public void TakeMedicine(int value)
    {
        _value = Math.Clamp(_value + value, _minimumValue, _maximumValue);
        ValueChanged?.Invoke();
    }

    public void TakeDamage(int value)
    {
        _value = Math.Clamp(_value - value, _minimumValue, _maximumValue);
        ValueChanged?.Invoke();
    }
}
