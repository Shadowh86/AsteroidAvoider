using UnityEngine;
using UnityEngine.Rendering;
using TMPro;

public class Money : MonoBehaviour
{
    int money;
    [SerializeField] private TMP_Text ammountText;

    public void AddMoney(int ammount)
    {
        money += ammount;
        ammountText.text = money.ToString();
    }
}
