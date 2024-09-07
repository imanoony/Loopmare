using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image _bar; 

    private float _fill;
    // Start is called before the first frame update
    void Start()
    {
        _fill = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        _fill = GameStateManager._time / 150f;

        _bar.fillAmount = _fill;
    }
}
