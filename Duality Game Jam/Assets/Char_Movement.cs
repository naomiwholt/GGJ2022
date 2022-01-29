using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Movement : MonoBehaviour
{
    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize(); //So that speed doesn't increase when moving diagonally

        transform.Translate(movementDirection * speed * Time.deltaTime);
    }
}
