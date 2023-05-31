using TMPro;
using UnityEngine;

public class ShapeSelection : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _nameText;

    private void OnMouseEnter()
    {
        _nameText.text = gameObject.name;
        _nameText.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        _nameText.gameObject.SetActive(false);
    }
}
