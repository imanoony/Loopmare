using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private EnemyBehaviour _enemyBehaviour;
    private Vector3 _backDestination;
    private Vector3 _apprDestination;
    // Start is called before the first frame update
    void Start()
    {
        _enemyBehaviour = GetComponent<EnemyBehaviour>();
        _backDestination = new Vector3(-13f, transform.position.y, 0f);
        _apprDestination = new Vector3(-1f, transform.position.y, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        switch (UseManager._pC)
        {
            case 0:
                _enemyBehaviour.House();
                break;
            case 1:
                _enemyBehaviour.BackMoving(_backDestination); 
                break;
            case 2:
                _enemyBehaviour.Approaching(_apprDestination);
                break;
        }
    }
}
