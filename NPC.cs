using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int Health = 5;
    public int Level = 1;
    public float Speed = 1.8f;
    // Start is called before the first frame update
    void Start()
    {
        Health += Level;
        print(Health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += Speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
