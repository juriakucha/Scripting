using UnityEngine;
using TMPro;

public class Temperature : MonoBehaviour
{
  public Health health;
  public TextMeshProUGUI tempText;
  public int playerDamage = 2;
  public float temperatureCurrent = 36.6f;
  public float temperatureNormal = 36.6f;
  public float temperatureCritical = 34f;
  public float freezeSpeed = 0.05f;
  public float freezeDamageTimer = 1;
  public float freezeDamageDelay = 2;

   
    void Update()
    {
        temperatureCurrent -= freezeSpeed * Time.deltaTime;
        tempText.text = temperatureCurrent.ToString();
        if (temperatureCurrent <= temperatureCritical)
        {
            if (freezeDamageTimer <= 0)
            {
                health.TakeDamage(playerDamage);
                freezeDamageTimer += freezeDamageDelay;
            }
            else
            {
                freezeDamageTimer -= Time.deltaTime;
            }
            
        }
    }
}
