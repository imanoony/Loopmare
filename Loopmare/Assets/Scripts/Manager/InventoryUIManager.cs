using System;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIManager : MonoBehaviour
{
    [SerializeField] private GameObject _inXpA;
    [SerializeField] private GameObject _inXpB;
    [SerializeField] private GameObject _inXpC;
    [SerializeField] private GameObject _inXpD;

    [SerializeField] private GameObject _inCpA;
    [SerializeField] private GameObject _inCpB;
    [SerializeField] private GameObject _inCpC;
    [SerializeField] private GameObject _inCpD;
    // Start is called before the first frame update
    void Start()
    {
        _inXpA.SetActive(false);
        _inXpB.SetActive(false);
        _inXpC.SetActive(false);
        _inXpD.SetActive(false);

        _inCpA.SetActive(false);
        _inCpB.SetActive(false);
        _inCpC.SetActive(false);
        _inCpD.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        switch (InventoryManager._inventory2)
        {
            case -1:
                _inCpA.SetActive(false);
                _inCpB.SetActive(false);
                _inCpC.SetActive(false);
                _inCpD.SetActive(false);
                break;
            case 0:
                _inCpA.SetActive(true);
                _inCpB.SetActive(false);
                _inCpC.SetActive(false);
                _inCpD.SetActive(false);
                break;
            case 1:
                _inCpA.SetActive(false);
                _inCpB.SetActive(true);
                _inCpC.SetActive(false);
                _inCpD.SetActive(false);
                break;
            case 2:
                _inCpA.SetActive(false);
                _inCpB.SetActive(false);
                _inCpC.SetActive(true);
                _inCpD.SetActive(false);
                break;
            case 3:
                _inCpA.SetActive(false);
                _inCpB.SetActive(false);
                _inCpC.SetActive(false);
                _inCpD.SetActive(true);
                break;
        }

        switch (InventoryManager._inventory1)
        {
            case -1:
                _inXpA.SetActive(false);
                _inXpB.SetActive(false);
                _inXpC.SetActive(false);
                _inXpD.SetActive(false);
                break;
            case 0:
                _inXpA.SetActive(true);
                _inXpB.SetActive(false);
                _inXpC.SetActive(false);
                _inXpD.SetActive(false);
                break;
            case 1:
                _inXpA.SetActive(false);
                _inXpB.SetActive(true);
                _inXpC.SetActive(false);
                _inXpD.SetActive(false);
                break;
            case 2:
                _inXpA.SetActive(false);
                _inXpB.SetActive(false);
                _inXpC.SetActive(true);
                _inXpD.SetActive(false);
                break;
            case 3:
                _inXpA.SetActive(false);
                _inXpB.SetActive(false);
                _inXpC.SetActive(false);
                _inXpD.SetActive(true);
                break;
        }
    }

}
