using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseManager : MonoBehaviour
{
    private GameObject _playerGameObject;
    private float _delayTime = 5f;
    public static int _pA = 0;
    public static int _pC = 0;
    public static int _pD = 0;

    [SerializeField] private GameObject _EA;
    [SerializeField] private GameObject _EB;
    [SerializeField] private GameObject _EC;
    [SerializeField] private GameObject _ED;
    // Start is called before the first frame update
    void Start()
    {
        _playerGameObject = GameObject.Find("Player");
        _EA.SetActive(false);
        _EB.SetActive(false);
        _EC.SetActive(false);
        _ED.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (InventoryManager._inventory1 != -1 && Input.GetKeyDown(KeyCode.X))
        {
            if (InventoryManager._inventory1 == 0)
            {
                UsePortionA();
                InventoryManager._inventory1 = -1;
                Invoke("EndPortionA", _delayTime);
            }

            if (InventoryManager._inventory1 == 1)
            {
                UsePortionB();
                _playerGameObject.transform.position = new Vector3(5f, _playerGameObject.transform.position.y, 0f);
                InventoryManager._inventory1 = -1;
                Invoke("EndPortionB", _delayTime);
            }

            if (InventoryManager._inventory1 == 2)
            {
                UsePortionC();
                InventoryManager._inventory1 = -1;
                Invoke("EndPortionC", _delayTime);
            }

            if (InventoryManager._inventory1 == 3)
            {
                UsePortionD();
                InventoryManager._inventory1 = -1;
                Invoke("EndPortionD", _delayTime);
            }
        }

        if (InventoryManager._inventory2 != -1 && Input.GetKeyDown(KeyCode.C))
        {
            if (InventoryManager._inventory2 == 0)
            {
                UsePortionA();
                InventoryManager._inventory2 = -1;
                Invoke("EndPortionA", _delayTime);
            }

            if (InventoryManager._inventory2 == 1)
            {
                UsePortionB();
                _playerGameObject.transform.position = new Vector3(5f, _playerGameObject.transform.position.y, 0f);
                InventoryManager._inventory2 = -1;
                Invoke("EndPortionB", _delayTime);
            }

            if (InventoryManager._inventory2 == 2)
            {
                UsePortionC();
                InventoryManager._inventory2 = -1;
                Invoke("EndPortionC", _delayTime);
            }

            if (InventoryManager._inventory2 == 3)
            {
                UsePortionD();
                InventoryManager._inventory2 = -1;
                Invoke("EndPortionD", _delayTime);

            }
        }
    }
    private void UsePortionA()
    {
        PlayerBehaviour._speed = 13f;
        _pA = 1;
        _EA.SetActive(true);
    }
    private void EndPortionA()
    {
        PlayerBehaviour._speed = 10f;
        _pA = 0;
        _EA.SetActive(false);
    }
    private void UsePortionB()
    {
        _EB.SetActive(true);
    }
    private void EndPortionB()
    {
        _EB.SetActive(false);
    }
    private void UsePortionC()
    {
        _pC = 1;
        _EC.SetActive(true);
    }
    private void EndPortionC()
    {
        _EC.SetActive(false);
    }
    private void UsePortionD()
    {
        _pD = 1;
        _ED.SetActive(true);
    }
    private void EndPortionD()
    {
        _pD = 0;
        _ED.SetActive(false);
    }
}
