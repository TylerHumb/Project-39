using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

    public float speed;
    float moveFB;
    float moveLR;
    CharacterController controller;
     
    // Start is called before the first frame update
    void Start() {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update() {
        moveFB = Input.GetAxis("Vertical");
        moveLR = Input.GetAxis("Horizontal");
        controller.Move(new Vector3(moveLR*speed*Time.deltaTime, 0, moveFB*speed*Time.deltaTime));
    }
}
