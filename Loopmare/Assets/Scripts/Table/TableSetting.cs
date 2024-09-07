using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TableSetting : MonoBehaviour
{
    [SerializeField] private GameObject[] _portions;
    // Start is called before the first frame update
    void Start()
    {
        _portions[0].SetActive(false);
        _portions[1].SetActive(false);
        _portions[2].SetActive(false);
        _portions[3].SetActive(false);

        int num = Random.Range(0, 4);
        _portions[num].SetActive(true);
    }
}
