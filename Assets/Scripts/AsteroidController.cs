//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour {

    #region fields
    Rigidbody2D asteroidBody;
    [SerializeField]
    float minImpulseForce;
    [SerializeField]
    float maxImpulseForce;
    [SerializeField]
    float maxAngularSpeed;
    [SerializeField]
    float minAngularSpeed;
    public string forceDirection;
    float angle;
    #endregion

    // Use this for initialization
    void Start () {

        MoveAsteroid();
        
	}

    void MoveAsteroid()
    {
        if(this.transform.localScale.x < 0.4f)
        {
            minImpulseForce = 2f;
            maxImpulseForce = 4f;
            angle = UnityEngine.Random.Range(0, 2 * Mathf.PI);
        }
        else
        {
            angle = GetAngle(forceDirection);
        }
        
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = UnityEngine.Random.Range(minImpulseForce, maxImpulseForce);
        asteroidBody = GetComponent<Rigidbody2D>();
        asteroidBody.AddForce(direction * magnitude, ForceMode2D.Impulse);
        asteroidBody.angularVelocity = UnityEngine.Random.Range(minAngularSpeed, maxAngularSpeed);          // Add angular velocity to give a tumbling motion to the rock.   
    }

    private float GetAngle(string dir)
    {
        float angle = 0.0f;
        switch(dir)
        {
            case "up":
                angle = 75.0f + UnityEngine.Random.Range(75 * Mathf.Deg2Rad, 105 * Mathf.Deg2Rad);
                break;

            case "down":
                angle = -75.0f + UnityEngine.Random.Range(-75 * Mathf.Deg2Rad, -105 * Mathf.Deg2Rad);
                break;

            case "right":
                angle = 0.0f + UnityEngine.Random.Range(0 * Mathf.Deg2Rad, 30 * Mathf.Deg2Rad);
                break;

            case "left":
                angle = 90.0f + UnityEngine.Random.Range(90 * Mathf.Deg2Rad, 120 * Mathf.Deg2Rad);
                break;

            default:
                break;
        }

        return angle;
    }
}
