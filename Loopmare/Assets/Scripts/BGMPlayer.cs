using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMPlayer : MonoBehaviour
{
    private AudioSource _audioSource;
    private GameObject[] _musics;
    // Start is called before the first frame update
    void Awake()
    {
        _musics = GameObject.FindGameObjectsWithTag("Music");

        if (_musics.Length >=2)
        {
            Destroy(this.gameObject);
        }
        
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        if (_audioSource.isPlaying)
        {
            return;
        }
        _audioSource.Play();
    }

}
