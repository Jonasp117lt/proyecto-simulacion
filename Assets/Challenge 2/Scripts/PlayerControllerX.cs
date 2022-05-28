using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnTime = 0.4f;
    public float timer = Time.time;

    // Update is called once per frame
    void Update()
    {
         timer += Time.deltaTime;
            if (timer>=spawnTime)
            {
                // On spacebar press, send dog
                if(Input.GetKeyDown(KeyCode.Space)){
                    SpawnDog();
                    timer=0;
                }
            }
    }

    void SpawnDog()
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
}
