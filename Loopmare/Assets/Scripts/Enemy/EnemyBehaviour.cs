using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private float _enemySpeed = 6f;
    [SerializeField] private float _enemySlowSpeed = 3f;

    private Vector3 _house;
    private void Start()
    {
        _house = transform.position;
    }
    // Start is called before the first frame update
    public void BackMoving(Vector3 dst)
    {
        if (dst.x < transform.position.x)
        {
            gameObject.GetComponent<SpriteRenderer>().material.color = new Color(219 / 255f, 210 / 255f, 134 / 255f, 255 / 255f);
            var speed = _enemySpeed;
            var position = transform.position;
            var PosX = position.x - speed * Time.deltaTime;
            position = new Vector3(PosX, position.y, 0f);
            transform.position = position;
        } 

        else
        {
            Invoke("ChangepC", 5f);
        }
    }

    public void Approaching(Vector3 dst)
    {
        if (dst.x > transform.position.x)
        {
            gameObject.GetComponent<SpriteRenderer>().material.color = new Color(231 / 255f, 144 / 255f, 144 / 255f, 255 / 255f);
            var speed = _enemySlowSpeed;
            var position = transform.position;
            var PosX = position.x + speed * Time.deltaTime;
            position = new Vector3 (PosX, position.y, 0f);
            transform.position = position;
        }

        else
        {
            Invoke("ChangepC", 3f);
        }
    }

    public void House()
    {
        if (transform.position.x <= _house.x)
        {
            gameObject.GetComponent<SpriteRenderer>().material.color = Color.white;
            var speed = _enemySpeed;
            var position = transform.position;
            var PosX = position.x + speed * Time.deltaTime;
            position = new Vector3(PosX, position.y, 0f);
            transform.position = position;
        }

        else if (transform.position.x >= _house.x)
        {
            gameObject.GetComponent<SpriteRenderer>().material.color = Color.white;
            var speed = _enemySpeed;
            var position = transform.position;
            var PosX = position.x - speed * Time.deltaTime;
            position = new Vector3(PosX, position.y, 0f);
            transform.position = position;
        }
    }

    private void ChangepC()
    {
        UseManager._pC = 0;
    }

}
