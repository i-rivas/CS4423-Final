using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    DiscreteMovement movement;

    // Start is called before the first frame update
    void Awake()
    {
        movement = GetComponent<DiscreteMovement>();
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 vel = Vector3.zero;

      if(Input.GetKey(KeyCode.W)){
        vel.y = 1;
      }if(Input.GetKey(KeyCode.S)){
        vel.y = -1;
      }if(Input.GetKey(KeyCode.A)){
        vel.x = -1;
      }if(Input.GetKey(KeyCode.D)){
        vel.x = 1;
      }
      movement.Movement(vel);

    }
}
