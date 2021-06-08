using System;

namespace MouseTest.Models
{
    public class ErrorTracker
    {
        public const int MIN_DELAY = 100; //Minimum double click delay

        public ErrorTracker()
        {
            Initialize();
        }

        private void Initialize()
        {
            ButtonList = new MouseButtonStatus[3];
            ButtonList[0] = new MouseButtonStatus(MouseButton.Left);
            ButtonList[1] = new MouseButtonStatus(MouseButton.Middle);
            ButtonList[2] = new MouseButtonStatus(MouseButton.Right);
        }

        public void MouseClick(MouseButton button)
        {
            DateTime currentClick = DateTime.Now;
            int buttonId = (int)button;

            var clickInterval = currentClick - ButtonList[buttonId].LastClick;
            ButtonList[buttonId].LastClick = currentClick;

            if (clickInterval.Milliseconds < MIN_DELAY)
            {
                ButtonList[buttonId].ErrorCounter++;
            }
        }

        public MouseButtonStatus[] ButtonList { get; private set; }

        public enum MouseButton
        {
            Left = 0,
            Middle = 1,
            Right = 2
        }


        public class MouseButtonStatus
        {
            public MouseButtonStatus(MouseButton button)
            {
                Button = button;
                LastClick = DateTime.MinValue;
                ErrorCounter = 0;
            }

            public MouseButton Button { get; set; }

            public DateTime LastClick { get; set; }

            public int ErrorCounter { get; set; }

            public void ClearErrors()
            {
                ErrorCounter = 0;
            }
        }
    }
}
