using System.Collections.Generic;
using System.Windows.Forms;

namespace WeatherApp
{
    internal class UserHistoryManager
    {
        private static UserHistoryManager instance;

        private readonly Stack<Control[]> historyStack = new Stack<Control[]>();

        public int GetUserHistoryLength => historyStack.Count;

        private UserHistoryManager() { }

        public static UserHistoryManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserHistoryManager();
                }
                return instance;
            }
        }

        public void PushToHistory(Control[] controls)
        {
            if (controls != null && controls.Length > 0)
            {
                historyStack.Push(controls);
                MainForm.Instance.HeaderComponent.UpdateBackButtonVisibility();
            }
        }

        public Control[] PopFromHistory()
        {
            return historyStack.Count > 0 ? historyStack.Pop() : null;
        }


        public void ClearHistory()
        {
            historyStack.Clear();
            MainForm.Instance.HeaderComponent.UpdateBackButtonVisibility();
        }
    }
}
