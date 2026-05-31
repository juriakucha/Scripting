using UnityEngine;

public class Player : MonoBehaviour
{
   private  int _health = 10;
    public GameObject fireballPrefab;
    public Transform attackPoint;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, 
        attackPoint.
        position, attackPoint.
        rotation);
        }
    }
   public  void TakeDamage(int damage)
    {
        _health -= damage;
        print("здоровье игрока: "+_health);
    }

    
    
    
        
    
}
