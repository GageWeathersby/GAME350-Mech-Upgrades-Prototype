using TMPro;
using UnityEngine;

public class StatsUI : MonoBehaviour
{
    public GameObject[] statsSlots; 

    private void Start()
    {
        UpdateAllStats();
    }
    private void Update()
    {
        UpdateAllStats();
    }
    public void UpdateHealth()
    {
        statsSlots[0].GetComponentInChildren<TMP_Text>().text = "Health: " + StatsManager.Instance.health;
    }

    public void UpdateDamage()
    {
        statsSlots[1].GetComponentInChildren<TMP_Text>().text = "Damage: " + StatsManager.Instance.damage;
    }

    public void UpdateArmor()
    {
        statsSlots[2].GetComponentInChildren<TMP_Text>().text = "Armor: " + StatsManager.Instance.armor;
    }

    public void UpdateSpeed()
    {
        statsSlots[3].GetComponentInChildren<TMP_Text>().text = "Speed: " + StatsManager.Instance.speed;
    }

    public void UpdateAllStats()
    {
        UpdateHealth();
        UpdateDamage();
        UpdateArmor();
        UpdateSpeed();
    }
}
