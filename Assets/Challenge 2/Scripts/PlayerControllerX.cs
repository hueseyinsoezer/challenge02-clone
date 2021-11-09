using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timer1 = 2.0f, spawnReload = 2.0f;
    // Update is called once per frame
    void Update()
    {
        timer1 -= Time.deltaTime; Debug.Log(timer1);
        if (timer1 < 0)
        {
            timer1 = -1.0f;//to decrease of load
        }
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (timer1 < 0)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timer1 = spawnReload;
            }
            else
            {

            }
            
        }
    }
}
