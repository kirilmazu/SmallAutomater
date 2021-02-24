using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SmallAutomaterWFA
{
    public class SingleAction
    {
        public enum names
        {
            moveMouseToXY,
            click,
            //copy,     //Not implemented
            //past,     //Not implemented
            dragToXY,
            KeyboardInput,
            wait
        }

        private names actionName;
        private string actionParams;

        private int x;
        private int y;

        private Func<string, int> action;

        public SingleAction(names actionName, string actionParams)
        {
            this.actionName = actionName;
            this.actionParams = actionParams;
            if (actionParams != null)
            {
                //if the param is point it should be "X:Y", if it not number will be thrown exaption
                if (actionParams.Contains(":"))
                {
                    try
                    {
                        x = Convert.ToInt32(actionParams.Split(':')[0]);
                        y = Convert.ToInt32(actionParams.Split(':')[1]);
                    } catch (Exception e)
                    {
                        //ignore, it can bee text with ':' as part of the string, x:y converted to int and than to string.
                    }
                }
            }

            //set the function once
            switch (this.actionName)
            {
                /*case names.copy:
                    action = copy;
                    break;

                case names.past:
                    action = past;
                    break;*/

                case names.click:
                    action = click;
                    break;

                case names.moveMouseToXY:
                    action = moveMouseToXY;
                    break;

                case names.dragToXY:
                    action = dragToXY;
                    break;

                case names.KeyboardInput:
                    action = KeyboardInput;
                    break;

                case names.wait:
                    action = wait;
                    break;

                default:
                    throw new NotSupportedException("The action not suported.");
            }
        }



        public string Name
        {
            get { return this.actionName.ToString(); }
        }

        public static string getMousePoint()
        {
            return Cursor.Position.X + ":" + Cursor.Position.Y;
        }

        public void doAction()
        {
            action(this.actionParams);
        }

        // move the cursore to new x:y point
        private int moveMouseToXY(string s)
        {
            VirtualMouse.MoveTo(x, y);
            return 0;
        }

        private int KeyboardInput(string type)
        {
            SendKeys.Send(type);
            return 0;
        }

        private int click(string param)
        {
            if (param == VirtualMouse.mouse_button.right_button.ToString())
                VirtualMouse.RightClick();
            else if (param == VirtualMouse.mouse_button.Left_button.ToString())
                VirtualMouse.LeftClick();
            else if(param == VirtualMouse.mouse_button.middle_button.ToString())
            {
                VirtualMouse.MiddleClick();
            }
            else
                throw new NotSupportedException("Parameter can be only right or left, get parameter: " + param);

            return 0;
        }



        private int copy(string s)
        {
            // TODO: implement
            return 0;
        }

        private int past(string s)
        {
            // TODO: implement
            return 0;
        }

        private int dragToXY(string s)
        {
            // TODO: implement
            return 0;
        }

        private int wait(string sleepTime)
        {
            System.Threading.Thread.Sleep(Convert.ToInt32(sleepTime));
            return 0;
        }

        public string toString()
        {
            string returnString = this.actionName.ToString();

            switch (this.actionName)
            {
                case names.click:
                    returnString += " " + this.actionParams;
                    break;

                case names.dragToXY:
                case names.moveMouseToXY:
                    returnString += " " + this.x + ":" + this.y;
                    break;

                case names.KeyboardInput:
                    returnString += ": " + this.actionParams;
                    break;

                case names.wait:
                    string time;
                    if (Convert.ToInt32(this.actionParams) < 60000) time = Convert.ToInt32(this.actionParams)/1000 + " seconds";
                    else time = Convert.ToInt32(this.actionParams) / 60000 + " minutes";
                    returnString += " " + time;
                    break;

            }

            return returnString;
        }

    }
}
