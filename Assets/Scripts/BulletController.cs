using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    #region fields
    [SerializeField]
    Transform spawnPoint;
    [SerializeField]
    GameObject bulletPrefab;
    [SerializeField]
    float bulletSpeed;
    #endregion

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("left ctrl"))
        {
			AudioManager.Play(AudioClipName.PlayerShot);
            FireBullet(bulletPrefab, spawnPoint);
        }
	}

    void FireBullet(GameObject bullet, Transform spawn)
    {
        GameObject bulletShot = Instantiate(bullet, spawnPoint.transform);
        Rigidbody2D bulletBody = bulletShot.GetComponent<Rigidbody2D>();
        
        bulletBody.AddRelativeForce(Vector2.up * bulletSpeed);
        bulletShot.GetComponent<BulletTimer>().StartTimer(true);
    }
}
