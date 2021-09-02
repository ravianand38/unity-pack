using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
   
    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();


   // looping a dictionary

    private void Start()
    {

        Item sword = new Item();
        sword.name = "Sword";
        sword.id = 0;


        Item bread = new Item();
        bread.name = "bread";
        bread.id = 1;


        Item flour = new Item();
        flour.name = "flour";
        flour.id = 2;



        Item rice = new Item();
        rice.name = "rice";
        rice.id = 3;



        Item oil = new Item();
        oil.name = "oil";
        oil.id = 4;



        itemDictionary.Add(0, sword);
        itemDictionary.Add(1, bread);

        itemDictionary.Add(2, flour);

        itemDictionary.Add(3, rice);
        itemDictionary.Add(4, oil);



        if (itemDictionary.ContainsKey(1))
            {
            Debug.Log("Key found");
        }
        else
        {
            Debug.Log("KEY NOT FOUND");
        }

        /*

        foreach(KeyValuePair<int, Item> item in itemDictionary)
        {
            Debug.Log("Key: " + item.Key);
            Debug.Log("Value: " + item.Value.name);
        }





        foreach(int Key in itemDictionary.Keys)
        {
            Debug.Log("KEY: " + Key);

        }

                */


        foreach (Item item in itemDictionary.Values)
        {
            Debug.Log("Item Name: " + item.name);

        }


    }




    






}
