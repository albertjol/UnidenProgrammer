using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UnidenProgrammer
{
    public enum Mode
    {
        AM,
        FM
    }
    public class Channel
    {
        public Channel(string message)
        {
            string[] components = message.Split(',');
            ChannelId = int.Parse(components[0]);
            Frequency = int.Parse(components[2].Substring(0, 4)) + int.Parse(components[2].Substring(4, 4)) / 10000.0;
            Mode = Enum.Parse<Mode>(components[3]);
            Delay = components[5] != "0";
            LockOut = components[6] != "0";
            Priority = components[7] != "0";
        }
        public int ChannelId { get; set; }
        public double Frequency { get; set; }
        public Mode Mode { get; set; }
        public bool Delay { get; set; }
        public bool LockOut { get; set; }
        public bool Priority { get; set; }

        public string GetMessage()
        {
            int frequency = (int)(Frequency * 10000);
            bool valid = (frequency != 0);
            return $"CIN,{ChannelId}," +
                $"," + // Name? 
                $"{frequency:0000000}," +
                $"{(valid ? Mode.ToString() : "")}," +
                $"," +
                $"{(Delay && valid ? 1 : 0)}," +
                $"{(LockOut || !valid ? 1 : 0)}," +
                $"{(Priority && valid ? 1 : 0)}";
        } 
    }

}
