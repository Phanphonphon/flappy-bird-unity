using UnityEngine;
using UnityEngine.UI;

public class KillManager : MonoBehaviour
{
    public static KillManager Instance; // ✅ THÊM DÒNG NÀY

    public Text killText;
    private int killCount = 0;

    void Awake() // ✅ THÊM HÀM AWAKE
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject); // tránh tạo trùng
        }
    }

    void Start()
    {
        UpdateKillText();
    }

    public void AddKill()
    {
        killCount++;
        UpdateKillText();
    }

    private void UpdateKillText()
    {
        if (killText != null)
        {
            killText.text = "Số quái đã hạ: " + killCount.ToString();
        }
    }
}