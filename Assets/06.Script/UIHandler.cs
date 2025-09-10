using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIHandler : MonoBehaviour
{
    VisualElement m_Healthbar;
    public float CurrentHealth = 0.5f;
    void Start()
    {
        var uiDocument = GetComponent<UIDocument>();
        var healthBar = uiDocument.rootVisualElement.Q<VisualElement>("HealthBar");
       

    }
    public void SetHealthValue(float percentage)
    {
        m_Healthbar.style.width = Length.Percent(100 * percentage);

    }
}
