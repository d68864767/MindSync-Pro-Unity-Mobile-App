unity-project/FirebaseIntegration/FirebaseDependencies.cs

using UnityEngine;

public class FirebaseDependencies : MonoBehaviour
{
    private void Awake()
    {
        // Check and fix Firebase dependencies
        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            var dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available)
            {
                Debug.Log("Firebase dependencies are up to date!");
            }
            else
            {
                Debug.LogError($"Failed to resolve Firebase dependencies: {dependencyStatus}");
            }
        });
    }
}
