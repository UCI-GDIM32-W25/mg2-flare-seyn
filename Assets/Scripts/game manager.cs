using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("UI")]
    public TextMeshProUGUI pointsText;

    private int points = 0;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    void Start()
    {
        UpdateUI();
    }

    public void AddPoint(int amount = 1)
    {
        points += amount;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (pointsText != null)
            pointsText.text = "points: " + points;
    }
}
