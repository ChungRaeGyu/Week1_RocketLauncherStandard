using UnityEngine;
using UnityEngine.InputSystem;

public class RocketMovement : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private Vector2 playerDirection = Vector2.zero;
    private bool _isBoosted;
    private readonly float SPEED = 5f;
    private readonly float ROTATIONSPEED = 0.01f;

    RocketController rocketController;
    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        rocketController = GetComponent<RocketController>();
    }
    
    private void Start(){
        rocketController.OnMoveEvent += ApplyMovement;
        rocketController.OnBoostEvent += ApplyBoost;
    }
    private void FixedUpdate() {
        Move(playerDirection);
    }
    public void ApplyMovement(Vector2 direction)
    {
        // TODO : 회전을 적용하고 이동을 적용함 -> 이에 대한 구현을 아래에서 진행할 것
        playerDirection = direction;
        // Rotate(direction);
         
    }

    public void ApplyBoost(bool isPressed)
    {
        _isBoosted = isPressed;
        Debug.Log("실행");
    }

    private void Rotate(Vector2 direction)
    {
        // TODO : 완만한 회전을 적용함
        
    }

    private void Move(Vector2 direction)
    {   
        // TODO : 움직임 적용
        if(_isBoosted){
            direction = direction * SPEED * 3;
            
        }
            

        else
            direction = direction * SPEED;
        _rb2d.velocity = direction; 
    }
}