using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public static float _speed;

    public float NormalSpeed => _speed;
    private AudioManager _audioManager;
    // Start is called before the first frame update
    void Start()
    {
        _speed = 10f;
        _audioManager = GameManager.Instance.AudioManager;
    }
    public void HandleInput(float hValue)
    {
        var speed = _speed;
        var position = transform.position;
        var PosX = position.x + speed * hValue * Time.deltaTime;
        position = new Vector3(Mathf.Clamp(PosX, -9.2f, 9.2f), position.y, 0f);
        transform.position = position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameManager.Instance.GameStateManager.PrepareGame();
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Slime" && UseManager._pD == 0)
        {
            if (UseManager._pA == 0)
            {
                _speed = 8f;
                gameObject.GetComponent<SpriteRenderer>().material.color = new Color(179 / 255f, 248 / 255f, 170 / 255f, 255 / 255f);
            }
            else
            {
                _speed = 9f;
                gameObject.GetComponent<SpriteRenderer>().material.color = new Color(179 / 255f, 248 / 255f, 170 / 255f, 255 / 255f);
            }
        }
            

        if (collision.gameObject.tag == "Slime" && UseManager._pD == 1)
        {
            if (UseManager._pA == 0)
            {
                _speed = 10f;
                gameObject.GetComponent<SpriteRenderer>().material.color = Color.white;
            }
            else
            {
                _speed = 13f;
                gameObject.GetComponent<SpriteRenderer>().material.color = Color.white;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Slime")
        {
            if (UseManager._pA == 0)
            {
                _speed = 10f;
                gameObject.GetComponent<SpriteRenderer>().material.color = Color.white;
            }
            else
            {
                _speed = 13f;
                gameObject.GetComponent<SpriteRenderer>().material.color = Color.white;
            }
        }
    }

}
