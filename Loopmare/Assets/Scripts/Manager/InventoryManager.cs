using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static int _inventory1;
    public static int _inventory2;

    private GameObject _item;
    private int _itemNum;

    [SerializeField] private GameObject _tableSpawner;
    [SerializeField] private GameObject _playerGameObject;

    private AudioManager _audioManager;
    // Start is called before the first frame update
    void Start()
    {
        _inventory1 = -1;
        _inventory2 = -1;

        _audioManager = GameManager.Instance.AudioManager;
    }

    // Update is called once per frame
    void Update()
    {
        GetItem();
    }

    private void GetItem()
    {
        if (_tableSpawner.transform.childCount != 0)
        {
            GameObject table = _tableSpawner.transform.GetChild(0).gameObject;
            float distance = Vector3.Distance(table.transform.position, _playerGameObject.transform.position);

            for(int i = 0; i < 4; i++)
            {
                if (table.transform.GetChild(i).gameObject.activeSelf)
                {
                    _item = table.transform.GetChild(i).gameObject;
                    _itemNum = i;
                }
            }

            if (distance < 4f && distance > -4f && Input.GetKeyDown(KeyCode.Z) && _item.activeSelf)
            {
                if (_inventory1 != -1 && _inventory2 != -1)
                {
                    Debug.Log("Full Inventory");
                }

                else
                {
                    _item.SetActive(false);

                    if (_inventory1 == -1)
                    {
                        _inventory1 = _itemNum;
                    }

                    else
                    {
                        _inventory2 = _itemNum;
                    }

                    _audioManager.PlaySfx(1);
                }
            }
        }
    }
}
