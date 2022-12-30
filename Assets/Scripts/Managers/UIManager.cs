using TMPro;
using UnityEngine;

[DisallowMultipleComponent]
public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI stepCounter;
    [SerializeField] private TextMeshProUGUI mistakeCounter;
    [SerializeField] private TextMeshProUGUI hintCounter;
    [SerializeField] private TextMeshProUGUI infoText;

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }
    
    // Methods -----
    public void OnClickHintButton()
    {
        //ToDo
    }
    
    // Getter -----
    public TextMeshProUGUI GetStepCounter() { return stepCounter; }
    public TextMeshProUGUI GetMistakeCounter() { return mistakeCounter; }
    public TextMeshProUGUI GetHintCounter() { return hintCounter; }
    
    // Setter -----
    public void SetStepCounter(int c)
    {
        stepCounter.text = c + "x";
    }

    public void SetMistakeCounter(int c)
    {
        mistakeCounter.text = c + "x";
    }

    public void SetHintCounter(int c)
    {
        hintCounter.text = c + "x";
    }

    public void SetInfoText(string text)
    {
        infoText.text = text;
    }
    
}
