using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // VARS *****************************
    public float speed = 5.0f;
    public AudioSource deathSnd;

    // Private
    private Vector3 _StartPos;


    // Start ********************************
    void Start() { _StartPos = transform.position; } // Locate Player



    // Update **********************************
    void Update()
    {
        // Find Mouse Pos
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0.0f;

        // Find Angle
        Vector3 dir = mouseWorldPosition - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


        // CONTROLS ********************************

        // Up (W)
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
        }
        // Down (S)
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector3.down * Time.deltaTime * speed, Space.World);
        }
        // Left (A)
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
        }
        // Right (D)
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
        }
        // Menu (Esc)
        if (Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene("Menu");
        } 

    }// END

    // Reset ****************************************
    public void Reset()
    {      
        deathSnd.Play();
        transform.position = _StartPos;
    }

    // Trigger Function ******************************
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("TRIGGER ENTER");

        if (collider.gameObject.tag == "Enemy")
        {
            ScoreManager.score = 0; // Reset Score
            Reset(); // Reset Player

            // List all enemies
            var enemies = GameObject.FindGameObjectsWithTag("Enemy");

            // Destroy all Enemies
            foreach (var enemy in enemies)
            {
                Destroy(enemy);
                // Destroy(collider.gameObject);
            }
            
        }        
    }

}
