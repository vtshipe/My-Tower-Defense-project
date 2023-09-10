using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject impactEffect;
    private Transform target;
    public float speed = 70f; 
    public void Seek(Transform _target)
    {
        target = _target;
    }

    private void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }   

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame) 
        {
            HitTarget();
            return;
        }

        transform.Translate (dir.normalized * distanceThisFrame, Space.World ); 

    }
    void HitTarget ()
    {
      GameObject effectins = (GameObject) Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectins, 2f);
        Destroy(target.gameObject);
       Destroy (gameObject);
    }
}
