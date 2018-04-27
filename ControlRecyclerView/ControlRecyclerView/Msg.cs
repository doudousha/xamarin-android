using System;

namespace ControlRecyclerView
{
    public class Msg
    {
        public const int type_received = 0;
        public const int type_send = 1;
        public int Type { get; set; }
        public String Content { get; set; }

        public Msg(int type, string content)
        {
            Type = type;
            Content = content;
        }
    }
}