using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeBehaviour : MonoBehaviour
{
    void Update()
    {
        var speed = -5;
        var position = transform.position;
        var PosX = position.x + speed * Time.deltaTime;
        position = new Vector3(PosX, position.y, 0f);
        transform.position = position;

        DelSlime();
    }

    private void DelSlime()
    {
        if (transform.position.x < -25)
        {
            Destroy(gameObject);
        }
    }
}
