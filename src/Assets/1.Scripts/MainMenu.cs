using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_InputField ID;
    public TMP_InputField DealerKey;
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
        Debug.Log("ID: " + ID);
        Debug.Log("DealerKey: " + DealerKey);

        if (ID == null)
        {
            Debug.LogError("ID is NULL");
            return;
        }

        if (!string.IsNullOrEmpty(ID.text))
        {
            user = ID.text;
            SceneManager.LoadScene("Waiting_Room");
        }
        else
        {
            Debug.Log("아이디 입력해");
        }
    }
}
