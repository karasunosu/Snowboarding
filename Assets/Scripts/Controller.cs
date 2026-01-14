using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    [SerializeField] float baseTorque = 0f;

    Rigidbody2D myRigidbody;
    InputAction moveAction;

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        moveAction.Enable();

        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        PlayerController();
    }

    void PlayerController()
    {
        Vector2 moveVector = moveAction.ReadValue<Vector2>();
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
}
