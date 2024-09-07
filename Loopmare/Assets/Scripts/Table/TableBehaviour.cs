using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableBehaviour : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var speed = -5;
        var position = transform.position;
        var PosX = position.x + speed *  Time.deltaTime;
        position = new Vector3(PosX, position.y, 0f);
        transform.position = position;

        DelTable();
    }

    private void DelTable()
    {
        if (transform.position.x < -25)
        {
            Destroy(gameObject);
        }
    }
}
