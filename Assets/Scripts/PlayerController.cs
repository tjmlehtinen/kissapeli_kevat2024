using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 3f;
    private float verticalInput = 0;
    private float horizontalInput = 0;
    private float mouseInput = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(horizontalInput, -1, verticalInput);
        controller.Move(direction * speed * Time.deltaTime);

        mouseInput = Input.GetAxis("Mouse X");
    }
}
