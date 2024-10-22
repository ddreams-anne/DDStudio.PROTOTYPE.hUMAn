using UnityEngine;
using UnityEditor;

namespace DDStudio.CORE
{
    public class ApplicationHandler : MonoBehaviour
    {
        private void Start()
        {
            // By default the cursor is hidden
            Cursor.visible = false;
        }

        public static void QuitApplication()
        {
            if (Application.isEditor) EditorApplication.ExitPlaymode();
            else Application.Quit();
        }
    }
}
