
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] SpawnList = new GameObject[3];

    public List<GameObject> objectsCreated = new List<GameObject>();
    
   public int SpawnCount { get; set; }
    private bool _initColorChange;
    private void Update()
    {



        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (SpawnCount == 10 )

            {
                _initColorChange = true;
                return;


            }
            var objectToSpawn = SpawnList[Random.Range(0, SpawnList.Length)];
            var x = Random.Range(-10, 10);
            var y = Random.Range(-10, 10);
            var pos = new Vector3(x, y, 0);
             GameObject go = Instantiate(objectToSpawn, pos, Quaternion.identity);

            objectsCreated.Add(go);


            SpawnCount++;

        }

        if(_initColorChange == true)
        {
            _initColorChange = false;


            foreach(var obj in objectsCreated)
            {
                obj.GetComponent<MeshRenderer>().material.color = Color.green;
            }
            objectsCreated.Clear();

        }

    }




}



