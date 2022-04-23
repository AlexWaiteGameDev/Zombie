using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float Speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update 1/Frame
    void Update()
    {
        Vector3 position = transform.position;
        

        // S (Ground Up)
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector3.up * Time.deltaTime * Speed, Space.World);

            position.y += Speed * Time.deltaTime;

            if (position.y >= 20.0f)
            {
                position.y -= 40.0f;
            }            
        }// END


        // W (Ground Down)
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.down * Time.deltaTime * Speed, Space.World);

            position.y -= Speed * Time.deltaTime;

            if (position.x <= -20.0f)
            {
                position.x += 40.0f;
            }
        }// END
    

        // A (Ground Right)
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector3.right * Time.deltaTime * Speed, Space.World);

            position.x += Speed * Time.deltaTime;

            if (position.x >= 20.0f)
            {
                position.x -= 40.0f;
            }
        }// END

        // D (Ground Left)
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector3.left * Time.deltaTime * Speed, Space.World);

            position.x -= Speed * Time.deltaTime;

            if (position.x <= -20.0f)
            {
                position.x += 40.0f;
            }

            transform.position = position;
        }// END

        
    }
}
