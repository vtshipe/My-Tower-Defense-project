using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    private void Start()
    {
        target = waypoints.points[0];
    }

    private void Update()
    {
        Vector3 dri = target.position - transform.position;
        transform.Translate(dri.normalized * speed * Time.deltaTime, Space.World);    
        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            getnextwaypoint(); 
        }
    }
    void getnextwaypoint () 
    {
        if (wavepointIndex >= waypoints.points.Length - 1) 
        {
            Destroy(gameObject);
            return;
        }
        wavepointIndex++;
        target= waypoints.points[wavepointIndex];
    }
}
