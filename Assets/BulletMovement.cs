using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletMovement : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (direction != null && speed != 0)
        {
            transform.Translate(direction * Time.deltaTime * speed);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            SceneManager.LoadScene( SceneManager.GetActiveScene().name );
        }
    }
    
    
}
