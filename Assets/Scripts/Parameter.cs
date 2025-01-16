using System;
using UnityEngine;

public class Parameter : MonoBehaviour
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

    public void ValuePlus(int step)
    {
        _value = Math.Clamp(_value + step, _minimumValue, _maximumValue);
        ValueChanged?.Invoke();
    }

    public void ValueMinus(int step)
    {
        _value = Math.Clamp(_value - step, _minimumValue, _maximumValue);
        ValueChanged?.Invoke();
    }
}
