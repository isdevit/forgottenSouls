/*using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Extensions;
using UnityEngine.SceneManagement;

public class SaveLoadManager : MonoBehaviour
{
    private DatabaseReference reference;
    private Firebase.Auth.FirebaseAuth auth2;

    void Start()
    {/*
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            if (task.Exception != null)
            {
                Debug.LogError($"Failed to initialize Firebase: {task.Exception}");
                return;
            }

            reference = FirebaseDatabase.DefaultInstance.RootReference;
            auth2 = Firebase.Auth.FirebaseAuth.DefaultInstance;
        });*/
  /*  }

    void OnApplicationQuit()
    {
        SavePlayerData();
    }

    void SavePlayerData()
    {
        if (auth.CurrentUser != null)
        {
            string userId = auth.CurrentUser.UserId;
            string sceneId = SceneManager.GetActiveScene().name;
            Vector3 playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;

            PlayerData playerData = new PlayerData
            {
                scene = sceneId,
                position = playerPosition
            };

            string json = JsonUtility.ToJson(playerData);
            reference.Child("players").Child(userId).SetRawJsonValueAsync(json).ContinueWithOnMainThread(task =>
            {
                if (task.IsFaulted)
                {
                    Debug.LogError($"Failed to save player data to Firebase: {task.Exception}");
                }
                else
                {
                    Debug.Log("Player data saved to Firebase successfully.");
                }
            });
        }
        else
        {
            Debug.LogError("User is not authenticated.");
        }
    }
}*/
