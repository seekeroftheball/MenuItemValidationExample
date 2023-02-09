using UnityEditor;
using UnityEngine;

namespace MenuValidationExample
{ 
    public class MenuItemsExample
    {
        [MenuItem("Menu Validation / Example", priority = 11)]
        private static void DisplayMenu()
        {
            EditorPrefs.SetBool("MenuValidated", true);
            EditorApplication.Beep();
            Debug.Log("Pressed validated menu item!");
        }

        [MenuItem("Menu Validation / Reset Validation")]
        private static void ResetValidationEditorPrefs()
        {
            EditorPrefs.SetBool("MenuValidated", false);
            EditorApplication.Beep();
            Debug.Log("Reset menu validation!");
        }
    }
}
