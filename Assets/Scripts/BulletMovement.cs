using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed;
    private Transform _transform;
    public GameObject explosionPrefab;
    private void Awake()
    {
        _transform = GetComponent<Transform>();       
        Destroy(this.gameObject, 2);       
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        _transform.position = new Vector2(transform.position.x, _transform.position.y + speed * Time.deltaTime);        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);           
            Destroy(gameObject);
            Destroy(explosion, 1);
        }
    }
}
