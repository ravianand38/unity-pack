
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<string> names = new List<string>();
    







    private void Start()
    {

    }




    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            {

            var nameToRemove = names[Random.Range(0, names.Count)];


            names.Remove(nameToRemove);

            foreach (var i in names)
            {
                Debug.Log(i);
            }
            Debug.Log("WE REMOVE: " + nameToRemove);
        }
    }
}



