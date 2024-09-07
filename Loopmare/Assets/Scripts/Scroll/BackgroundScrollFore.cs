using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrollFore : MonoBehaviour
{
    [SerializeField] float speed;

    float leftPosX = 0f;
    float rightPosX = 0f;
    // Start is called before the first frame update
    void Start()
    {
        leftPosX = -(GetComponent<Renderer>().bounds.size.x);
        rightPosX = -leftPosX;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.position += new Vector3(speed, 0f, 0f) * Time.deltaTime;

            if (transform.position.x < leftPosX)
            {
                Vector3 nextPos = new Vector3(0f, transform.position.y, 0f);
                nextPos = new Vector3(nextPos.x + rightPosX, nextPos.y, 0f);
                transform.position = nextPos;
            }
        }
        
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.position += new Vector3(-speed, 0f, 0f) * Time.deltaTime;

            if (transform.position.x > -leftPosX)
            {
                Vector3 nextPos = new Vector3(0f, transform.position.y, 0f);
                nextPos = new Vector3(nextPos.x - rightPosX, nextPos.y, 0f);
                transform.position = nextPos;
            }
        }

        
    }
}
