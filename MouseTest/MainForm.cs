using System;
using System.Reflection;
using System.Windows.Forms;
using MouseTest.Models;

namespace MouseTest
{
    public partial class MainForm : Form
    {
        private readonly MouseStatus _mouseStatus;
        private readonly ErrorTracker _errorTracker;
        private const int MAX_POLL_RATE = 10;
        private DateTime _pollTime;

        public MainForm()
        {
            InitializeComponent();
            _mouseStatus = new MouseStatus();
            _errorTracker = new ErrorTracker();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _mouseStatus.LeftButton = new MouseButton { Id = 1, Name = "Left" };
            _mouseStatus.MiddleButton = new MouseButton { Id = 3, Name = "Middle" };
            _mouseStatus.RightButton = new MouseButton { Id = 2, Name = "Right" };

            _mouseStatus.Buttons.Add(_mouseStatus.LeftButton);
            _mouseStatus.Buttons.Add(_mouseStatus.RightButton);
            _mouseStatus.Buttons.Add(_mouseStatus.MiddleButton);

            Text = "Mouse Tester - " + Assembly.GetExecutingAssembly().ImageRuntimeVersion;
            lblThreshhold.Text = $"Trigger: {ErrorTracker.MIN_DELAY} ms";

            UpdateControlState(true);
        }

        private void picBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    _mouseStatus.LeftButton.Clicked = true;
                    _mouseStatus.LeftButton.UpdateState = true;
                    break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Right:
                    _mouseStatus.RightButton.Clicked = true;
                    _mouseStatus.RightButton.UpdateState = true;
                    break;
                case MouseButtons.Middle:
                    _mouseStatus.MiddleButton.Clicked = true;
                    _mouseStatus.MiddleButton.UpdateState = true;
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            UpdateControlState(true);
        }

        private void picBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    _mouseStatus.LeftButton.Clicked = false;
                    _mouseStatus.LeftButton.UpdateState = true;
                    break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Right:
                    _mouseStatus.RightButton.Clicked = false;
                    _mouseStatus.RightButton.UpdateState = true;
                    break;
                case MouseButtons.Middle:
                    _mouseStatus.MiddleButton.Clicked = false;
                    _mouseStatus.MiddleButton.UpdateState = true;
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            UpdateControlState(true);
        }

        private void picBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            _mouseStatus.Position = e.Location;

            UpdateControlState(false);
        }

        private void picBoxMain_MouseEnter(object sender, EventArgs e)
        {
            _mouseStatus.InArea = true;
        }

        private void picBoxMain_MouseLeave(object sender, EventArgs e)
        {
            _mouseStatus.InArea = false;
        }

        private void picBoxMain_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    _errorTracker.MouseClick(ErrorTracker.MouseButton.Left);
                    break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Right:
                    _errorTracker.MouseClick(ErrorTracker.MouseButton.Right);
                    break;
                case MouseButtons.Middle:
                    _errorTracker.MouseClick(ErrorTracker.MouseButton.Middle);
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            UpdateControlState(true);
        }

        private void picBoxMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void UpdateControlState(bool forceUpdate)
        {
            var dtNow = DateTime.Now;
            if (!forceUpdate && (dtNow - _pollTime).Milliseconds < MAX_POLL_RATE)
            {
                return;
            }

            _pollTime = dtNow;

            foreach (var button in _mouseStatus.Buttons)
            {
                if (button.UpdateState)
                {
                    button.UpdateState = false;
                    switch (button.Id)
                    {
                        case 1:
                            lblLeft.Text = button.Clicked ? "Down" : "Up";
                            break;
                        case 2:
                            lblRight.Text = button.Clicked ? "Down" : "Up";
                            break;
                        case 3:
                            lblMiddle.Text = button.Clicked ? "Down" : "Up";
                            break;
                    }
                }

                lblErrLeft.Text = _errorTracker.ButtonList[0].ErrorCounter.ToString();
                lblErrRight.Text = _errorTracker.ButtonList[2].ErrorCounter.ToString();
            }

            lblXpos.Text = _mouseStatus.Position.X.ToString();
            lblYPos.Text = _mouseStatus.Position.Y.ToString();
        }

        private void clearErrorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var button in _errorTracker.ButtonList)
            {
                button.ClearErrors();
            }

            UpdateControlState(true);
        }

        private void setTriggerTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you aure you want to exit the application?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}