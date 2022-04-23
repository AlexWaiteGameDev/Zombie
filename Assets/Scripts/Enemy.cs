using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    // VARS *****************************

    // Public
    public GameObject mainPlayer;
    public Transform target;
    public Animator enemyAnimator;
    public int scoreValue = 1;

    // Private
    private Vector3 _StartPos;




    // Start ****************************
    void Start()
    {
        _StartPos = transform.position;
        GameObject mainPlayer = GameObject.FindGameObjectWithTag("Player");
        target = mainPlayer.transform;        
    }


    // Update ****************************
    private void Update()
    {
        // Get Current Position
        Vector3 currentPosition = transform.position;

        // Track Player
        Vector3 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


        // Distance Check (Attack)
        if (Vector2.Distance(transform.position, target.position) < 1.0f) // Distance Check
        {
            enemyAnimator.SetBool("Attacking", true); // Attack ON
        } else {        
            enemyAnimator.SetBool("Attacking", false); // Attack OFF

            // Distance Check (Move)
            if (Vector2.Distance(transform.position, target.position) < 20.0f) // Distance Check
            {               
                enemyAnimator.SetBool("Moving", true); // Move ON
                transform.Translate(Vector3.right * Time.deltaTime * 1.0f);
            } else {               
                enemyAnimator.SetBool("Moving", false); // Move OFF
            }
        }// END anim

    }// END Update()


    // Reset Function **********************************
    public void DestroyThis(GameObject objectKill)
    {
        Destroy(objectKill);
    }
 

    // Trigger Function ******************************
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("TRIGGER ENTER");

        switch (collider.gameObject.tag) {
            
            //case "Player":
                //Destroy(collider.gameObject);
                // thePlayer.Reset();
                //break;

            case "Bullet":
                ScoreManager.score += scoreValue;
                Destroy (collider.gameObject);
                Destroy(gameObject);
                break;
        }      
    }


    // Collision Function *****************************
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("COLLISION ENTER");


    }


}