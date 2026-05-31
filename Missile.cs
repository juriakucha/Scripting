using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 2;
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
      transform.position += 
        transform.forward *
        speed * Time.deltaTime;
  
    }

    private void OnTriggerEnter(Collider other)
    {
    
        Enemy enemy = other.GetComponent<Enemy>();
        Destroy(enemy.gameObject);
        Destroy(gameObject);
    }
}
