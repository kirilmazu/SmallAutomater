using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallAutomaterWFA
{
    class AutomateAction
    {
        private string actionName;
        private LinkedList<SingleAction> singleActions = new LinkedList<SingleAction>();

        public AutomateAction(string actionName, LinkedList<SingleAction> actions)
        {
            this.actionName = actionName;
            this.singleActions = actions;
        }

        public AutomateAction(string actionName) : this(actionName, new LinkedList<SingleAction>()) { }

        public string Name
        {
            get { return this.actionName; }
            set { this.actionName = value; }
        }

        public LinkedList<SingleAction> actions
        {
            get { return this.singleActions; }
            set { this.singleActions = value;  }
        }

        public void doAllActions()
        {
            // active all actions
            foreach (SingleAction action in this.singleActions)
            {
                action.doAction();
            }
        }

        public LinkedList<string> getActionsNames()
        {
            LinkedList<string> names = new LinkedList<string>();
            foreach (SingleAction action in this.singleActions)
            {
                names.AddLast(action.Name);
            }
            return names;
        }
    }
}
