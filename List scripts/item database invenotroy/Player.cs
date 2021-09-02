using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Item[] inventory = new Item[10];


    private ItemDB _itemDatabase;


    private void Start()
    {
        _itemDatabase = GameObject.Find("ItemDatabase").GetComponent<ItemDB>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _itemDatabase.AddItem(0, this);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            _itemDatabase.RemoveItem(0,this);
        }

    }




}
