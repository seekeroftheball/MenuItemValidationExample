// Author: https://github.com/seekeroftheball

using UnityEditor;

namespace MenuValidationExample
{
    /// <summary>
    /// Validation methods for menu items.
    /// </summary>
    public class MenuValidation
    {
        [MenuItem("Menu Validation / Example", true)]
        private static bool InitializeValidation()
        {
            return ValidateMenuItem(false);
        }

        [MenuItem("Menu Validation / Reset Validation", true)]
        private static bool ResetValidation()
        {
            if (EditorPrefs.HasKey("MenuValidated"))
                return ValidateMenuItem(true);
            return false;
        }

        private static bool ValidateMenuItem(bool validateIfCurrentStatus)
        {
            if (EditorPrefs.HasKey("MenuValidated"))
            {
                if (!EditorPrefs.GetBool("MenuValidated").Equals(validateIfCurrentStatus))
                    return false;
            }
            return true;
        }
    }
}