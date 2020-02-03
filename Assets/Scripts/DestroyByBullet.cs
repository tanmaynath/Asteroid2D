using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBullet : MonoBehaviour {

    [SerializeField]
    GameObject asteroidPrefab;

    // Use this for initialization
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Asteroid"))
        {
            if(collision.transform.localScale.x < asteroidPrefab.transform.localScale.x/2)
            {
				AudioManager.Play(AudioClipName.AsteroidHit);
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }
            
            else
            {
				AudioManager.Play(AudioClipName.AsteroidHit);
				Destroy(collision.gameObject);
                SpawnSmallAsteroid(asteroidPrefab, collision);
                Destroy(this.gameObject);
            }   
        }
    }

    void SpawnSmallAsteroid(GameObject asteroid, Collision2D collision)
    {
        float posX = collision.transform.position.x;
        float posY = collision.transform.position.y;
        for (int i =0; i < 2; i++)
        {
            GameObject newAsteroid = Instantiate(asteroid, new Vector3(posX, posY, 0), Quaternion.identity) as GameObject;
            newAsteroid.transform.localScale = new Vector3(collision.transform.localScale.x / 2, collision.transform.localScale.y / 2, 1);
        }
    }
}
