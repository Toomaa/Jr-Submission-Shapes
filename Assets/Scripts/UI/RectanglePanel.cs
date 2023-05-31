using TMPro;
using UnityEngine;

public class RectanglePanel : ShapePanel
{
    [Header("Inputs")]
    [SerializeField] protected TMP_InputField _sideAInput;
    [SerializeField] protected TMP_InputField _sideBInput;

    private void Start()
    {
        _shape = new Rectangle();
        _titleText.text = _shape.Name;
    }

    public override void ReadInputsAndCalculate()
    {
        float sideA = StringToFloat(_sideAInput.text);
        float sideB = StringToFloat(_sideBInput.text);
        ((Rectangle)_shape).Calculate(sideA, sideB);
        UpdateOutputText();
    }
}
