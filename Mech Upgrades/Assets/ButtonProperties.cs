using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Data;
using UnityEditor.EditorTools;

public class ButtonProperties : MonoBehaviour
{

    public static int buttonHealth;

   /* public int buttonDamage;

   public int buttonArmor;

   public int buttonSpeed;  */

    // 1. Define a custom structure to hold the name and properties for each state
    [System.Serializable]
    public struct ButtonStateData
    {

      /*  private ButtonProperties owner;

        public ButtonStateData(ButtonProperties controller)
        {
            owner = controller;
        }   */


        public string buttonName;

       // public int buttonHealth;

        public int buttonDamage;

        public int buttonArmor;

        public int buttonSpeed;

        public Color buttonColor;
        public Sprite buttonSprite;
        public bool isInteractable;
    }

    [Header("Data Array")]
    [SerializeField] private ButtonStateData[] states;

    private Button _button;
    private Image _buttonImage;
    private TextMeshProUGUI _buttonText;

    /*private int _buttonHealth;
    private int _buttonDamage;
    private int _buttonArmor;
    private int _buttonSpeed; */
    private int _currentIndex = 0;

    

    private void Awake()
    {
        // Cache components on the button and its child text object
        _button = GetComponent<Button>();
        _buttonImage = GetComponent<Image>();
        _buttonText = GetComponentInChildren<TextMeshProUGUI>();

        /* _buttonHealth =GetComponentInChildren<int>();
        _buttonDamage =GetComponentInChildren<int>();
        _buttonArmor = GetComponentInChildren<int>();
        _buttonSpeed = GetComponentInChildren<int>();   */
        Debug.Log("Awake fucntion works");
    }

    private void Start()
    {
        // Initialize the button with the first element in the array
        if (states != null && states.Length > 0)
        {
            ApplyState(states[0]);
            Debug.Log("start fucntion works");
        }

        // Subscribe to the click event
        _button.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        if (states == null || states.Length == 0) return;

        // Advance the index and wrap back to 0 at the end of the array
        _currentIndex = (_currentIndex + 1) % states.Length;

        ApplyState(states[_currentIndex]);

        StatsManager.Instance.health = StatsManager.Instance.health + buttonHealth;
       /* StatsManager.Instance.armor = StatsManager.Instance.armor + _buttonDamage;
        StatsManager.Instance.speed = StatsManager.Instance.speed + _buttonArmor;
        StatsManager.Instance.damage = StatsManager.Instance.damage + _buttonSpeed;  */
        Debug.Log("OnButtonClicked fucntion works");
        Debug.Log("Button was clicked! hp is " + StatsManager.Instance.health);

    }

    private void ApplyState(ButtonStateData data)
    {
        // Update the GameObject's name in the Hierarchy 
        gameObject.name = data.buttonName;

        // Update the visible button text
        if (_buttonText != null)
        {
            _buttonText.text = data.buttonName;
        }

        // Update visual and functional properties
        /* if (_buttonImage != null)
        {
            _buttonImage.color = data.buttonColor;
            if (data.buttonSprite != null)
            {
                _buttonImage.sprite = data.buttonSprite;
            }
        }  */

        _button.interactable = data.isInteractable;
        Debug.Log("ApplyState fucntion works");
    }

    private void OnDestroy()
    {
        // Clean up the listener when destroyed
        _button.onClick.RemoveListener(OnButtonClicked);
    }
}