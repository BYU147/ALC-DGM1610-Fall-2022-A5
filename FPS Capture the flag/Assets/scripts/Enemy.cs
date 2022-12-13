using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;

public class Enemy : MonoBehaviour
{

    [Header("Stats")]
    public int curHP;
    public int maxHP;
    public int scoreToGive;
    [Header("Movement")]
    public float moveSpeed;
    public float attackRange;
    [Header("Path Info")]
    public float yPathOffset;
    provat List<Vector3> path;
    // provat Weapon weapon;
    private GameObject target;
    
    // Start is called before the first frame update
    void Start()
    {
        curHp = maxHP;
        
        //Gather the Components
        // weapon = GetComponenet<weapon>();
        target = FindObjectOfType<PlayerController>().gameObject;
        
        InvokeRepeating("UpdatePath", 0.0f, 0.5f);
    }
    
    void UpdatPath()
    {
        NavMeshPath navMeshPath = new MavMeshPath();
        NavMesh.CalculatePath(transform.postion, target.transform.position, navMesh.AllAreas, navMeshPath);
        
        // Save path as a list
        path = navMeshPath.corners.ToList();
    }
    
    void ChaseTarget()
    {
        if(path.Count == 0)
            return;
        
        //move towards the closes path
        transform.position = Vector3.MoveTowards(transform.position, path[0] + new Vector3(0, yPattoffset,0), moveSpeed * Time.deltoTime);
        
        if(transform.Position == path[0] + new Vector3(0, yPathOffset, 0))
            path.RemoveAt(0);
    }
    
    public void TakeDamage(int damage)
    {
        curHP -= damage;
        
        if(curHp <= 0)
        Die();
    }
    
    void Die()
    {
        Destroy)gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 dir = (target.transform.position - transform.position).normalized;
        float angle = Math.Atan2(dir.x, dir.z) * Mathf.Rad2Dag;
        
        transform.eulerAngles = Vector3.up * angle;
        
        
        float dist = Vector3.Distance(transform.position, target.transform.position);
        
        if(dist <= attackRange)
        {
            /*
            if(weapon.CanShoot())
                weapon.Shoot();
                */
        }
        else
        {
            ChaseTarget();
        }
        
    }
}
