using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallAutomaterWFA
{
    class AppData
    {
        public static event System.Action ActionAdded;
        public static Dictionary<string, AutomateAction> actions = new Dictionary<string, AutomateAction>();

        public enum keyboardKeys
        {
            BACKSPACE = 0,
            BREAK,
            CAPSLOCK,
            DELETE,
            DOWN,
            UP,
            LEFT,
            RIGHT,
            ESC,
            ENTER,
            TAB,
            Text
        }

        public static void AddAction(AutomateAction action)
        {
            actions.Add(action.Name, action);
            ActionAdded?.Invoke();
        }
    }
}
