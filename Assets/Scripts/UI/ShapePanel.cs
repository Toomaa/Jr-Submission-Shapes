using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class ShapePanel : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI _titleText;
    [SerializeField] protected TextMeshProUGUI _outputText;
    [SerializeField] protected Button _calculateButton;

    protected Shape _shape;

    private const string OUTPUT_STRING = "Circumference: {0}\nSurface: {1}";

    private void Awake()
    {
        gameObject.SetActive(false);
        _calculateButton.onClick.AddListener(() => OnCalculateButtonClick());
    }

    private void OnCalculateButtonClick()
    {
        ReadInputsAndCalculate();
    }

    public abstract void ReadInputsAndCalculate();

    protected float StringToFloat(string text)
    {
        float.TryParse(text, out float f);
        return f;
    }

    protected void UpdateOutputText()
    {
        _outputText.text = string.Format(OUTPUT_STRING, _shape.Circumference, _shape.SurfaceArea);
    }
}
