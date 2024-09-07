using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    private PlayerBehaviour _playerBehaviour;
    // Start is called before the first frame update
    void Start()
    {
        _playerBehaviour = GetComponent<PlayerBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        var hValue = Input.GetAxisRaw("Horizontal");
        _playerBehaviour.HandleInput(hValue);
    }
}
