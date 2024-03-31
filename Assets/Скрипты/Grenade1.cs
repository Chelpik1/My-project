using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade1 : MonoBehaviour
{
    public float delay = 3;
    public GameObject explosionPrefab;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Invoke("Explosion", 3);
    }
    private void Explosion()
    {
        Destroy(gameObject);
        var explosion = Instantiate(explosionPrefab);
        explosion.transform.position = transform.position;
    }
}
