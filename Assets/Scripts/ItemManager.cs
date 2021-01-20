﻿using UnityEngine;

public class ItemManager : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void GetItem()
    {
        gameManager.AddScore(500);
        Destroy(this.gameObject);
    }
}
