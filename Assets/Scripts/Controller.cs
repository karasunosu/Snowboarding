using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    [SerializeField] float baseTorque = 0f;
    [SerializeField] float boostAmount = 0f;
    [SerializeField] SurfaceEffector2D surfaceEffector2D;
    
    Rigidbody2D myRigidbody;
    InputAction moveAction;
    Vector2 moveVector;

    float baseSpeed = 0f;
    public bool canControl = true;

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        moveAction.Enable();

        myRigidbody = GetComponent<Rigidbody2D>();
        
        baseSpeed = surfaceEffector2D.speed;
    }

    void Update()
    {
        if (canControl)
        {
            PlayerController();
            Boost();
        }
    }

    void PlayerController()
    {
        moveVector = moveAction.ReadValue<Vector2>();
        // xoay trai/phai
        if(moveVector.x < 0)
        {
            myRigidbody.AddTorque(baseTorque);
        }
        else if(moveVector.x > 0)
        {
            myRigidbody.AddTorque(-baseTorque);
        }
    }

    void Boost()
    {
        if(moveVector.y > 0)
        {
            surfaceEffector2D.speed += boostAmount;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }
}
