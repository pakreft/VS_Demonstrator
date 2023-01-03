using TMPro;
using UnityEngine;

[DisallowMultipleComponent]
public class UIManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    
    [SerializeField] private TextMeshProUGUI stepCounter;
    [SerializeField] private TextMeshProUGUI mistakeCounter;
    [SerializeField] private TextMeshProUGUI hintCounter;
    [SerializeField] private TextMeshProUGUI infoText;
    
    public void OnClickHintButton()
    {
        //ToDo
    }
    
    // ========== Setter ==========
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
