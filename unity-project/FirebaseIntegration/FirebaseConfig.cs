using UnityEngine;

public class FirebaseConfig : MonoBehaviour
{
    private const string FirebaseApiKey = "YOUR_FIREBASE_API_KEY";
    private const string FirebaseProjectId = "YOUR_FIREBASE_PROJECT_ID";
    private const string FirebaseAppId = "YOUR_FIREBASE_APP_ID";

    private void Awake()
    {
        // Configure Firebase with the provided API key, project ID, and app ID
        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            var dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available)
            {
                Firebase.FirebaseApp app = Firebase.FirebaseApp.DefaultInstance;
                Debug.Log("Firebase initialized successfully!");
            }
            else
            {
                Debug.LogError($"Failed to initialize Firebase: {dependencyStatus}");
            }
        });
    }
}
