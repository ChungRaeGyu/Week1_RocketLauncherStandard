using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class RocketController : MonoBehaviour
{
    private EnergySystem _energySystem;

    public event Action<Vector2> OnMoveEvent;
    public event Action<bool> OnBoostEvent;

    private bool _isMoving;
    private Vector2 _movementDirection;
    
    private void Awake()
    {
        _energySystem = GetComponent<EnergySystem>();
    }

    // TODO : OnMove 구현
    // private void OnMove...
    private void OnMove(InputValue value){
        Vector2 direction = value.Get<Vector2>().normalized;
        OnMoveEvent?.Invoke(direction);
    }

    // TODO : OnBoost 구현
    // private void OnBoost...
    private void OnBooster(InputValue value)
    {   
        OnBoostEvent?.Invoke(value.isPressed);
    }
}