using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterController1 : MonoBehaviour
{
    public float speed;
    public float tilt;
    public Boundary boundary;
    public float xMin, xMax, zMin, zMax;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire;


    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            Debug.Log("Pew2");
        }
    }

    private void FixedUpdate()
    {

    }
}
