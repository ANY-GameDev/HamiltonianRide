using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class move : MonoBehaviour
{
    private float _horizontalInput;
    private float _verticalInput;
    public int movementSpeed = 0;
    public int rotationSpeed = 0;
    [SerializeField]
    GameManager gm;

    Rigidbody2D rb2d;
    void Start()
    {
        _horizontalInput = 0;
        _verticalInput = 0;
        rb2d = GetComponent<Rigidbody2D>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (gm.GetIsGameOver())
        {
            movementSpeed = 0;
            rotationSpeed = 0;
            rb2d.velocity = Vector2.zero;
            return;
        }

        GetPlayerInput();

    }

    private void FixedUpdate()
    {

        RotatePlayer();
        MovePlayer();
    }


    private void GetPlayerInput()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        _verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void RotatePlayer()
    {
        float rotation = -_horizontalInput * rotationSpeed;
        transform.Rotate(Vector3.forward * rotation);
    }

    private void MovePlayer()
    {
        rb2d.velocity = transform.up * Mathf.Clamp01(_verticalInput) * movementSpeed;
    }
}
