using System;
using UnityEngine;

public class EnergySystem : MonoBehaviour
{
    public event Action<float> OnEnergyChanged;
    public float MaxFuel { get; private set; } = 10f;
    public float Fuel { get; private set; } = 10f;
    
    public bool UseEnergy(float amount)
    {
        if (Fuel < amount) return false;
        // TODO : 에너지를 사용하는 로직을 적용

        return true;
    }
}