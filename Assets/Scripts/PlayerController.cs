using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float speed;

    private Rigidbody2D rb;
    private Vector2 moveVal = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(moveVal.x, moveVal.y, 0)*speed*Time.deltaTime);
    }

    public void Move(InputAction.CallbackContext callbackContext)
    {
        moveVal = callbackContext.ReadValue<Vector2>();
    }
   
}
