namespace ASPax.Utilities
{
    /// <summary>
    /// Debug that will only be executed in the Unity Editor
    /// and thus prevent unnecessary log files from being generated after the build
    /// impacting the application's performance.
    /// </summary>
    public class Debug
    {
        /// <summary>
        /// Logs a message to the Unity Console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        public static void Log(object message, UnityEngine.Object context = default)
        {
#if UNITY_EDITOR
            UnityEngine.Debug.Log($"<color=green>{message}</color>", context);
#else
            return;
#endif
        }
        /// <summary>
        /// A variant of Debug.Log that logs a warning message to the console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        public static void LogWarning(object message, UnityEngine.Object context = default)
        {
#if UNITY_EDITOR
            UnityEngine.Debug.LogWarning($"<color=yellow>{message}</color>", context);
#else
            return;
#endif
        }
        /// <summary>
        /// A variant of Debug.Log that logs a warning message to the console.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        public static void LogError(object message, UnityEngine.Object context = default)
        {
#if UNITY_EDITOR
            UnityEngine.Debug.LogWarning($"<color=red>{message}</color>", context);
#else
            return;
#endif
        }
    }
}
