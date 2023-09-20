using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private CharacterController characterController;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CompareTag("Blue")) {
            Vector3 move = new(Input.GetAxis("BlueH"), Input.GetAxis("BlueV"), 0);
            characterController.Move(speed * Time.deltaTime * move);
        }
        else if (CompareTag("Red")) {
            Vector3 move = new(Input.GetAxis("RedH"), Input.GetAxis("RedV"), 0); 
            characterController.Move(speed * Time.deltaTime * move);
        }
    }
}
