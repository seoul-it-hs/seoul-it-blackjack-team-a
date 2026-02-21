using Seoul.It.Blackjack.Client;
using UnityEngine;

public class UnityBlackjackClient : MonoBehaviour
{
    public static BlackjackClient Instance { get; } = new BlackjackClient();
}
