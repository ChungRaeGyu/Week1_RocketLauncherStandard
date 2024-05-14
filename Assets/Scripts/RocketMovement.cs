using UnityEngine;
using UnityEngine.InputSystem;

public class RocketMovement : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private Vector2 playerDirection = Vector2.zero;
    private Vector2 rotateDirection = Vector2.zero;
    private bool _isBoosted;
    private readonly float SPEED = 5f;
    private readonly float ROTATIONSPEED = 0.01f;
    private EnergySystem _energySystem;
    RocketController rocketController;
    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        rocketController = GetComponent<RocketController>();
        _energySystem = GetComponent<EnergySystem>();
    }
    
    private void Start(){
        rocketController.OnMoveEvent += ApplyMovement;
        rocketController.OnBoostEvent += ApplyBoost;
    }
    private void FixedUpdate() {
        if(playerDirection==Vector2.zero)return;
        ApplyMovement(playerDirection);


    }
    public void ApplyMovement(Vector2 direction)
    {
        // TODO : 회전을 적용하고 이동을 적용함 -> 이에 대한 구현을 아래에서 진행할 것
        playerDirection = direction;
        Move(playerDirection);
        Rotate(playerDirection);
         
    }

    public void ApplyBoost(bool isPressed)
    {
        _isBoosted = isPressed;
        Debug.Log("실행");
    }

    private void Rotate(Vector2 direction)
    {
        // TODO : 완만한 회전을 적용함
        rotateDirection = direction;
        float rotZ = Mathf.Atan2(direction.y,direction.x)*Mathf.Rad2Deg;
        Debug.Log(rotZ);
        Quaternion rotate  = Quaternion.Euler(0,0,rotZ-90);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotate, ROTATIONSPEED);
    }

    private void Move(Vector2 direction)
    {   
        float oil=0;
        // TODO : 움직임 적용
        if(_isBoosted){
            direction = direction * SPEED * 3;
            oil=3;
        }
        else{
            direction = direction * SPEED;
            oil = 1;
        }
        if(_energySystem.UseEnergy(oil))
            _rb2d.velocity = direction;
    }
}