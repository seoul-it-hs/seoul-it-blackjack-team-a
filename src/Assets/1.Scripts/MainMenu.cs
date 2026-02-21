using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public static TMP_InputField ID;
    public static TMP_InputField DealerKey;
    public Button RoomIn;

    public static string user;
    
    void Start()    
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnClickRoomIn()
    {
        if(ID.text != null)
        {
            user = ID.text.ToString();
            SceneManager.LoadScene("Waiting_Room");
        }
    }
}
