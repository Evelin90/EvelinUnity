using TMPro;
using UnityEngine;

class Collector : MonoBehaviour
{
    [SerializeField] TMP_Text uiText;

    int collected = 0;

    private void Start()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (uiText != null)
            uiText.text = "Score" + collected;
    }

    private void OnTriggerEnter(Collider other)
    {
        Collectable c = other.GetComponent<Collectable> ();

        if (c != null)
        {
            collected += c.GetValue();
            Debug.Log(collected);


            UpdateUI();

            c.Teleport();
        }
    }

}

