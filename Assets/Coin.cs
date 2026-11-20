using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coin = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerCoins playercoin))
        {
            playercoin.AddCoin(coin);
            Destroy(gameObject);
        }

    }
}
