using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByAsteroid : MonoBehaviour {

    [SerializeField]
    GameObject ScoreCard;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.tag);
        if(collision.gameObject.tag == "Asteroid")
        {
            ScoreCard.GetComponent<ScoreManager>().StopGameTimer();
            AudioManager.Play(AudioClipName.PlayerDeath);
            Destroy(this.gameObject);
        }
    }
}
