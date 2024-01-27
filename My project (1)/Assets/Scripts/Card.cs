using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField] CardSO cardSO;
    private Image background;
    private TextMeshProUGUI cardName;

    void Awake()
    {
        background = this.gameObject.GetComponentInChildren<Image>();
        cardName = this.gameObject.GetComponentInChildren<TextMeshProUGUI>();
    }

    void Start()
    {
        cardName.text = cardSO.Name;
    }

    void Update()
    {
        
    }
}
