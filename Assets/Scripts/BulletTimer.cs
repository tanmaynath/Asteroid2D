using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTimer : MonoBehaviour {

    #region fields
    [SerializeField]
    float lifeSpan;
    float elapsedTime;
    bool startTimer = false;
    #endregion

    // Use this for initialization
    void Start () {
        elapsedTime = 0.0f;
	}

    public void StartTimer(bool flag)
    {
        startTimer = flag;
    }

	// Update is called once per frame
	void Update () {
        if (startTimer)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= lifeSpan)
            {
                Destroy(this.gameObject);
            }
        }
		
	}
}
