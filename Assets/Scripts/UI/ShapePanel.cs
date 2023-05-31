using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class ShapePanel : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI _titleText;
    [SerializeField] protected TextMeshProUGUI _outputText;
    [SerializeField] protected Button _calculateButton;

    protected Shape _shape;

    private void Awake()
    {
        
    }

    public abstract void ReadInputsAndCalculate();

    protected float StringToFloat(string text)
    {
        float.TryParse(text, out float f);
        return f;
    }
}
