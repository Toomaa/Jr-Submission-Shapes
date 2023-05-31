using TMPro;
using UnityEngine;

public class ShapeSelection : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _nameText;
    [SerializeField] private GameObject _panel;

    private void OnMouseEnter()
    {
        _nameText.text = gameObject.name;
        _nameText.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        _nameText.gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        // deactivate other panels
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("Panel"))
        {
            if (_panel.gameObject.GetInstanceID() == o.GetInstanceID()) continue;
            o.SetActive(false);
        }

        _panel.gameObject.SetActive(true);
    }
}
