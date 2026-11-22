using UnityEngine;

public class ButtonActions : MonoBehaviour
{
    public int healthStat = 10;
    public int armorStat = 10;
    public int speedStat = 10;
    public int damageStat = 10;


    // The method must be public so the button can see it
    public void OnButtonPressed()
    {
        Debug.Log("Button was clicked! hp is " + StatsManager.Instance.health);
        // Add your game logic here (e.g., load a scene, open a menu)

        StatsManager.Instance.health = StatsManager.Instance.health + healthStat;
        StatsManager.Instance.armor = StatsManager.Instance.armor + armorStat;
        StatsManager.Instance.speed = StatsManager.Instance.speed + speedStat;
        StatsManager.Instance.damage = StatsManager.Instance.damage + damageStat;

        //Destroy(gameObject);
    }






// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
