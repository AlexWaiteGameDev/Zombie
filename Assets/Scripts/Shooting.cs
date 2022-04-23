using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // VARS *************************

    // Public
    public Transform barrelEnd;
    public AudioSource bulletSound;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;

    // Private
    private float Timer = 0.3f;
    private float RapidTimer = 0.3f;
    bool isRapidFire = false;


    // Update **********************
    void Update()
    {
        // Left Click (Single)
        if (Input.GetMouseButtonDown(0)) {
            Shoot();
        }
        // Right Click (RF On)
        if (Input.GetMouseButtonDown(1)) {
            isRapidFire = true;
            Timer = 0.3f;
        }
        // Right Click (RF Off)
        if (Input.GetMouseButtonUp(1)) {
            isRapidFire = false;
        }

        // Rapid Fire Active
        if (isRapidFire) /* λ */ { RapidFire(); }
    }


    // Shoot *************************
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, barrelEnd.position, barrelEnd.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(barrelEnd.right * bulletSpeed, ForceMode2D.Impulse);
        bulletSound.Play();
        Timer = 0.0f; // Reset Timer
    }


    // RapidFire ***********************
    void RapidFire()
    {
        Timer += Time.deltaTime; // Timer++
        if (Timer > RapidTimer) /* λ */ { Shoot(); } 
    }

}
