namespace MouseTest.Models
{
    public class MouseButton
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Clicked { get; set; }

        public bool UpdateState { get; set; }

        public MouseButton()
        {
            UpdateState = true;
        }
    }
}