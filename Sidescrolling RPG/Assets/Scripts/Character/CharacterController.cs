using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

//Game Objects
    public GameObject ThirdPersonController;
    private Rigidbody ThirdPersonRigidbody;
    private Collider ThirdPersonCollider;
    public Transform ThirdPersonModel;

    //Controls
    public bool defaultKeys;
    public KeyCode moveRight;
    public KeyCode moveLeft;
    public KeyCode jump;

    //Attributes
    public float speed = 1f;
    public float rotateSpeed = 3f;

    void Start()
    {

        ThirdPersonRigidbody = ThirdPersonController.GetComponent<Rigidbody>();
        ThirdPersonCollider = ThirdPersonController.GetComponent<Collider>();
       

    }

    void DefaultKeys()
    {
        moveRight = KeyCode.D;
        moveLeft = KeyCode.A;
        jump = KeyCode.Space;

    }

	void Update () {
		
      

	}

    void Move()
    {

        
        


    }

    
}
