using TMPro;
using UnityEngine;

public class CirclePanel : ShapePanel
{
    [Header("Inputs")]
    [SerializeField] protected TMP_InputField _radiusInput;

    void Start()
    {
        _shape = new Circle();
        _titleText.text = _shape.Name;
    }

    public override void ReadInputsAndCalculate()
    {
        float sideA = StringToFloat(_radiusInput.text);
        ((Circle)_shape).Calculate(sideA);
        UpdateOutputText();
    }
}
