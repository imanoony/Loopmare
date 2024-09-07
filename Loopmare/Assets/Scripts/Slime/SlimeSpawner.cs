using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _slimePrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnSlime());
    }

    private IEnumerator SpawnSlime()
    {
        while (true)
        {
            var spawnPosition = new Vector3(22f, -6.5f, 0f);
            var table = Instantiate(_slimePrefab, spawnPosition, Quaternion.identity);
            table.transform.SetParent(gameObject.transform);

            int time = Random.Range(6, 25);
            yield return new WaitForSecondsRealtime(time);
        }
    }

    private void Update()
    {
        if (Time.timeScale == 0f)
        {
            StopCoroutine(SpawnSlime());
        }
    }
}