﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeSource : MonoBehaviour
{
    public Rigidbody grenadePrefab;
    public Transform grenadeSourceTransform;
    public float force = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
      if (Input.GetMouseButtonDown(1)) 
      {
            var grenade = Instantiate(grenadePrefab);
            grenade.transform.position = grenadeSourceTransform.position;
            grenade.GetComponent<Rigidbody>().AddForce(grenadeSourceTransform.forward * force);
      }
    }
}
