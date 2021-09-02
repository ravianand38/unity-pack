using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> itemDatabase = new List<Item>();


    public void AddItem(int itemID,Player player)
    {
        foreach(var item in itemDatabase)
        {
            if(item.id == itemID)
            {
                Debug.Log("We have item");
                player.inventory[0] = item;
                return;
            }

        }
        Debug.Log("item does not exist");
    }
    

    public void RemoveItem(int itemID,Player player)
    {
        foreach(var item in itemDatabase)
        {
            if(item.id == itemID)
            {
                player.inventory[0] = null;
            }
        }


    }
}
