using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public GameStateManager GameStateManager { get; private set; }
    public InventoryManager InventoryManager { get; private set; }
    public InventoryUIManager InventoryUIManager { get; private set; }
    public UseManager UseManager { get; private set; }
    public UIManager UIManager { get; private set; }
    public AudioManager AudioManager { get; private set; }

    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }


        Instance = this;
        GameStateManager = GetComponentInChildren<GameStateManager>();
        InventoryManager = GetComponentInChildren<InventoryManager>();
        InventoryUIManager = GetComponentInChildren<InventoryUIManager>();
        UseManager = GetComponentInChildren<UseManager>();
        UIManager = GetComponentInChildren<UIManager>();
        AudioManager = GetComponentInChildren<AudioManager>();
    }
}
