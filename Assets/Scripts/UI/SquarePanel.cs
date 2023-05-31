using TMPro;
using UnityEngine;

public class SquarePanel : ShapePanel
{
    [Header("Inputs")]
    [SerializeField] protected TMP_InputField _sideAInput;

    private void Start()
    {
        _shape = new Square();
        _titleText.text = _shape.Name;
    }

    public override void ReadInputsAndCalculate()
    {
        float sideA = StringToFloat(_sideAInput.text);
        ((Square)_shape).Calculate(sideA);
        UpdateOutputText();
    }
}
