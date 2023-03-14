using TMPro;
using UnityEngine;

public class HealthObject : MonoBehaviour
{
    [SerializeField, Min(1)] int maxHelath = 100;

    [SerializeField] TMP_Text uiHeathText;
    // [SerializeField] Color minColor = Color.red, maxColor = Color.green;
    [SerializeField] Gradient textColor;
    [SerializeField] GameObject restartUI;

    int currentHealth;
    void Start()
    {
        currentHealth = maxHelath;
        UpdateHelthTx();
    }

    public bool IsAlive()
    { 
    return currentHealth > 0;
    }

    public void Damage(int damage)
    {
        if (currentHealth <= 0) return;

        currentHealth = Mathf.Max(currentHealth - damage, 0);

        if (currentHealth <= 0)
        {
            Debug.Log("Good bye!");
        }

        UpdateHelthTx();
     
    }



    void UpdateHelthTx()
    {
        if (uiHeathText == null)
            return;
       
       uiHeathText.text = "Health" + currentHealth;
        //uiHeathText.color = Color.Lerp(minColor, maxColor, (float) currentHealth / maxHelath);

        uiHeathText.color = textColor.Evaluate((float) currentHealth / maxHelath);

        restartUI.SetActive(!IsAlive());
    }

}
