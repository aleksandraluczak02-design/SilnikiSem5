using TMPro;
using UnityEngine;

public class UI_StatisticPanel : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public TextMeshProUGUI healthText;
    public PlayerCoins playerCoins;
    public TextMeshProUGUI coinText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
        private void Awake()
    {
        playerHealth.OnAddHealth += PlayerHealth_OnAddHealth;
        playerHealth.OnHealthInnit += PlayerHealth_OnHealthInnit;
        playerCoins.OnAddCoin += PlayerCoins_OnAddCoin;
        playerCoins.OnCoinInnit += PlayerCoins_OnCoinInnit;

    }

    private void PlayerHealth_OnHealthInnit(int health)
    {
        healthText.text = health.ToString();
    }

    private void PlayerHealth_OnAddHealth(int health)
    {
        healthText.text = health.ToString();
    }

    private void PlayerCoins_OnAddCoin(int coin)
    {
        coinText.text = coin.ToString();
    }

    private void PlayerCoins_OnCoinInnit(int coin)
    {
        coinText.text = coin.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
