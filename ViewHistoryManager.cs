using System.Collections.Generic;
using System.Windows.Forms;

namespace WeatherApp
{
    internal class ViewHistoryManager
    {
        private static ViewHistoryManager instance;

        private readonly Stack<Control[]> historyStack = new Stack<Control[]>();

        public int GetUserHistoryLength => historyStack.Count;

        private ViewHistoryManager() { }

        public static ViewHistoryManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ViewHistoryManager();
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
