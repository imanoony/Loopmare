using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _tablePrefab;
    [SerializeField] private GameObject _tableSpawner;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTable());
    }

    private IEnumerator SpawnTable()
    {
        while (true)
        {
            var spawnPosition = new Vector3(19f, -2.5f, 0f);
            var table = Instantiate(_tablePrefab, spawnPosition, Quaternion.identity);
            table.transform.SetParent(gameObject.transform);

            int time = Random.Range(8, 24);
            yield return new WaitForSecondsRealtime(time);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0f)
        {
            StopCoroutine(SpawnTable());
        }
    }
}
