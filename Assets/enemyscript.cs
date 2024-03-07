using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    public float reloadTime = 2f;

    public float elapsed;
    public float bulletSpeed;
    

    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerStay(Collider other)
    {
        print("stay");
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (other.CompareTag("Player"))
        {
            Debug.Log("Do something here");
            elapsed += Time.fixedDeltaTime;
            if (elapsed > reloadTime)
            {
                Shoot(other);
                elapsed = 0f;
            }
            
            Debug.Log("Do something here");
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            elapsed = 0f;
        }
    }

    void Shoot(Collider other)
    {
        var target = other.gameObject.transform;
        var heading = (target.position - transform.position).normalized;

        var bulletInstance = Instantiate(bullet, transform.position, Quaternion.identity);
        //spawn prefab object (with hit collision)
        var BulMove = bulletInstance.GetComponent<BulletMovement>();

        BulMove.direction = heading;
        BulMove.speed = bulletSpeed;

        //sent object in a specific direction

    }
}
