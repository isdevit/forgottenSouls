
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;
using Firebase;
using Firebase.Database;
using Firebase.Extensions;




public class mainMenu : MonoBehaviour  
{
  private GameObject player;
  private DatabaseReference reference;
  private Firebase.Auth.FirebaseAuth auth3;


    private void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            if (task.Exception != null)
            {
                Debug.LogError($"Failed to initialize Firebase: {task.Exception}");
                return;
            }

            reference = FirebaseDatabase.DefaultInstance.RootReference;
            auth3 = Firebase.Auth.FirebaseAuth.DefaultInstance;
        });
    }
    public void startGame()
  {
     
        SceneManager.LoadScene("Town");
  }

  public void loadGame()
    {
        if (auth3.CurrentUser != null)
        {
            string userId = auth3.CurrentUser.UserId;

            reference.Child("players").Child(userId).GetValueAsync().ContinueWithOnMainThread(task =>
            {
                if (task.IsFaulted)
                {
                    Debug.LogError($"Failed to load player data from Firebase: {task.Exception}");
                    return;
                }

                if (task.Result.Exists)
                {
                    string json = task.Result.GetRawJsonValue();
                    PlayerData playerData = JsonUtility.FromJson<PlayerData>(json);

                    // Ensure the playerData.scene is valid before loading the scene
                    if (!string.IsNullOrEmpty(playerData.scene))
                    {
                        SceneManager.LoadScene(playerData.scene);
                        GameObject player = GameObject.FindGameObjectWithTag("Player");
                        player.transform.position = playerData.position;
                    }
                    else
                    {
                        Debug.LogWarning("Invalid scene ID in player data.");
                    }
                }
                else
                {
                    Debug.LogWarning("Player data does not exist in Firebase.");
                }
            });
        }
        else
        {
            Debug.LogError("User is not authenticated.");
        }
    
    Debug.Log("Load Button Pressed");
        
    }
  public void exitGame()
  {
    Application.Quit();
  }

  
  public void Test()
  {
    SceneManager.LoadScene("TestScene");
  }
}
