using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndShoot : MonoBehaviour
{
    public float speed;
    public float stopDistance;
    public float retreatDistance;
    private Transform target;
    private float shootDelay;
    public float startDelay;
    public float distance;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        shootDelay = startDelay;
    }

    // Update is called once per frame
    void Update()
    {
        
       if(Vector2.Distance(transform.position, target.position) > stopDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else if(Vector2.Distance(transform.position, target.position) < stopDistance && Vector2.Distance(transform. position, target.position) > retreatDistance)
        {
            transform.position = this.transform.position;
            
            
        }
        else if(Vector2.Distance(transform.position, target.position)> retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        
        if(shootDelay <= 0)
        {
            Debug.Log("AAAA");
            Attack();
            shootDelay = startDelay;
        }
        else
        {
            startDelay -= Time.deltaTime;
        }
       
    }
    
    void Attack()
    {
        transform.position = this.transform.position;
        Instantiate(projectile,transform.position, Quaternion.identity);
        shootDelay = shootDelay;
    }
}
