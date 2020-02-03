using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrapper : MonoBehaviour {

    # region fields
    float screenWrapY;
    float screenWrapX;
    [SerializeField]
    float verticalBuffer;
    [SerializeField]
    float horizontalBuffer;
    #endregion

    // Use this for initialization
    void Start () {
        screenWrapY = Camera.main.orthographicSize + verticalBuffer;                    // Gives vertical bound based on camera size
        screenWrapX = (screenWrapY * Screen.width / Screen.height + horizontalBuffer);    // Gives horizontal bound based on camera size
    }
	
	// Update is called once per frame
	void Update () {
        

        if (transform.position.y > screenWrapY)      // If the Y axis position exceeds screen wrapper, reverse the sign.
                                                                // Top becomes bottom and vice-versa
        {
            transform.position = new Vector3(transform.position.x, -transform.position.y + verticalBuffer, transform.position.z);
        }

        if (transform.position.y < -screenWrapY)      // If the Y axis position exceeds screen wrapper, reverse the sign.
                                                     // Top becomes bottom and vice-versa
        {
            transform.position = new Vector3(transform.position.x, -transform.position.y - verticalBuffer, transform.position.z);
        }

        if (transform.position.x > screenWrapX)      // Same logic as given above.
        {
            transform.position = new Vector3(-transform.position.x + horizontalBuffer, transform.position.y, transform.position.z);
        }

        if(transform.position.x < -screenWrapX)      // Same logic as given above.
        {
            transform.position = new Vector3(-transform.position.x - horizontalBuffer, transform.position.y, transform.position.z);
        }
    }
}
