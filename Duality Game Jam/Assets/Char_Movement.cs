using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Movement : MonoBehaviour
{
    public float speed; 
    public float jumpSpeed;

    
    private float ySpeed;
    private CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        float magnitude = 1; //Mathf.Clamp01(movementDirection.magnitude) * speed;

        characterController.SimpleMove(movementDirection * magnitude);

        transform.Translate(movementDirection * speed * Time.deltaTime);
    }
}
