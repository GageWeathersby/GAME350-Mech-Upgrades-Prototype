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
        Debug.Log("Button was clicked!");
        // Add your game logic here (e.g., load a scene, open a menu)
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
