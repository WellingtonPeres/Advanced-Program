using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHandler : MonoBehaviour
{
    [SerializeField] private int speed = 0;
    
    private CharacterController myController;

    private void Start()
    {
        myController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            myController.Move(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f, 0f));
        }
    }
}
