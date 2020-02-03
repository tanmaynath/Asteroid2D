using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustController : MonoBehaviour {

    // Use this for initialization
    # region Variables
    [SerializeField]
    float torque;
    
    Rigidbody2D shipBody;
    float shipRotation;
    [SerializeField]
    float thrustMultiplier;
    float thrust;
    float screenWrapY;
    float screenWrapX;
    #endregion

    // Setup screen constraints and rigidbody
    void Start () {
        shipBody = this.GetComponent<Rigidbody2D>();        
	}

    void Update()
    {
        thrust = Input.GetAxis("Thrust");
        shipRotation = Input.GetAxis("Rotate");
    }

    // Update is called once per frame
    void FixedUpdate () {
        shipBody.AddRelativeForce(Vector2.up * thrust * thrustMultiplier);        // Add force based on thrust input. The value gradually increases to 1
                                                            // simulating the realistic movement of a spacecraft.
                                                               // Further thrust can be added but this felt enough for the game

        shipBody.AddTorque(shipRotation * torque);             // Rotation is also gradual giving a more space like movement feel.
                                                               // Transform.Rotate gives a more rigid feel to the movement which is
                                                               // it is replaced by AddTorque
	}
}
